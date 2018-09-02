using ExitGames.Client.Photon;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRadaro
{
    class PhotonPacketHandler
    {
        PacketHandler _eventHandler;
        public PhotonPacketHandler(PacketHandler p)
        {
            this._eventHandler = p;
        }
        public void PacketHandler(Packet packet)
        {
            try
            {
                // Make this static or at least dont create a new Protocol16 for every package
                Protocol16 protocol16 = new Protocol16();

                IpV4Datagram ip = packet.Ethernet.IpV4;
                UdpDatagram udp = ip.Udp;
                if (udp.SourcePort != 5056 && udp.DestinationPort != 5056)
                    return;


                var ms = udp.Payload.ToMemoryStream();
                var p = new BinaryReader(ms);

                var peerId = IPAddress.NetworkToHostOrder(p.ReadUInt16());
                var crcEnabled = p.ReadByte();
                var commandCount = p.ReadByte();
                var timestamp = IPAddress.NetworkToHostOrder(p.ReadInt32());
                var challenge = IPAddress.NetworkToHostOrder(p.ReadInt32());

                var commandHeaderLength = 12;
                var signifierByteLength = 1;

                for (int commandIdx = 0; commandIdx < commandCount; commandIdx++)
                {

                    var commandType = p.ReadByte();
                    var channelId = p.ReadByte();
                    var commandFlags = p.ReadByte();
                    var unkBytes = p.ReadByte();
                    var commandLength = IPAddress.NetworkToHostOrder(p.ReadInt32());
                    var sequenceNumber = IPAddress.NetworkToHostOrder(p.ReadInt32());

                    switch (commandType)
                    {
                        case 4://Disconnect
                            break;
                        case 7://Send unreliable
                            p.BaseStream.Position += 4;
                            commandLength -= 4;
                            goto case 6;
                        case 6://Send reliable
                            p.BaseStream.Position += signifierByteLength;
                            var messageType = p.ReadByte();

                            var operationLength = commandLength - commandHeaderLength - 2;
                            var payload = new StreamBuffer(p.ReadBytes(operationLength));
                            switch (messageType)
                            {
                                case 2://Operation Request
                                    var requestData = protocol16.DeserializeOperationRequest(payload);
                                    _eventHandler.OnRequest(requestData.OperationCode, requestData.Parameters);
                                    break;
                                case 3://Operation Response
                                    var responseData = protocol16.DeserializeOperationResponse(payload);
                                    _eventHandler.OnResponse(responseData.OperationCode, responseData.ReturnCode, responseData.Parameters);
                                    break;
                                case 4://Event
                                    var eventData = protocol16.DeserializeEventData(payload);
                                    _eventHandler.OnEvent(eventData.Code, eventData.Parameters);
                                    break;
                                default:
                                    p.BaseStream.Position += operationLength;
                                    break;
                            }

                            break;

                        default:
                            p.BaseStream.Position += commandLength - commandHeaderLength;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("PackeHandler Exception: " + e.ToString());
            }
        }
    }

}