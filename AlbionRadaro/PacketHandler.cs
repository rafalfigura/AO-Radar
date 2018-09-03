using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AlbionRadaro.Mobs;

namespace AlbionRadaro
{
    class PacketHandler : IPhotonPackageHandler
    {
        PlayerHandler playerHandler;
        HarvestableHandler harvestableHandler;
        MobsHandler mobsHandler;

        public PacketHandler(PlayerHandler playerHandler, HarvestableHandler harvestableHandler, MobsHandler mobsHandler)
        {
            this.playerHandler = playerHandler;
            this.harvestableHandler = harvestableHandler;
            this.mobsHandler = mobsHandler;
        }
        public void OnEvent(byte code, Dictionary<byte, object> parameters)
        {
            if (code == 2) {
                //player movement comes with binary format - not normal.
                onPlayerMovement(parameters);
                return;
            } 

            object val;
            parameters.TryGetValue((byte)252, out val);
            if (val == null) return;

            int iCode = 0;
            if(!int.TryParse(val.ToString(), out iCode)) return;

            EventCodes eventCode = (EventCodes)iCode;


            Console.WriteLine("Event: " + eventCode);
            switch (eventCode)
            {
                case EventCodes.HarvestableChangeState:
                    onHarvestableChangeState(parameters);
                    break;
                case EventCodes.HarvestFinished:
                    onHarvestFinished(parameters);
                    break;
                case EventCodes.NewCharacter:
                    onNewCharacterEvent(parameters);
                    break;
                case EventCodes.NewHarvestableObject:
                      onNewHarvestableObject(parameters);
                    break;
                case EventCodes.NewSimpleHarvestableObjectList:
                    onNewSimpleHarvestableObjectList(parameters);
                    break;
                case EventCodes.Leave:
                    onLeave(parameters);
                    break;
                case EventCodes.NewMob:
                    onNewMob(parameters);
                    break;
                case EventCodes.JoinFinished:
                    onJoinFinished(parameters);
                    break;
                case EventCodes.InCombatStateUpdate:
                    onInCombatStateUpdate(parameters);
                    break;
                case EventCodes.CastSpell:
                    onCastSpell(parameters);
                    break;
                default: break;
            }
        }


        public void OnResponse(byte operationCode, short returnCode, Dictionary<byte, object> parameters)
        {
            //    Console.WriteLine("OnResponse: " + operationCode + " returnCode: " + returnCode);
        }
        public void OnRequest(byte operationCode, Dictionary<byte, object> parameters)
        {
            //OperationCodes code = (OperationCodes)parameters[253];
            int iCode = 0;
            if (!int.TryParse(parameters[253].ToString(), out iCode)) return;
            OperationCodes code = (OperationCodes)iCode;

            //Console.WriteLine("OnRequest: " + code);
            switch (code)
            {
                case OperationCodes.Move:
                    onLocalPlayerMovement(parameters);
                    break;
            }
        }

        private void onCastSpell(Dictionary<byte, object> parameters)
        {
            foreach (KeyValuePair<byte, object> kvp in parameters)
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }

        private void onInCombatStateUpdate(Dictionary<byte, object> parameters)
        {
            foreach (KeyValuePair<byte, object> kvp in parameters)
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
        private void onJoinFinished(Dictionary<byte, object> parameters)
        {
            this.harvestableHandler.HarvestableList.Clear();
            this.mobsHandler.MobList.Clear();
           // this.playerHandler.PlayersInRange.Clear();
        }
        private void onNewMob(Dictionary<byte, object> parameters)
        {
            /*
                Key = 0, Value = 7987 //obj id
                Key = 1, Value = 44 //type id
                Key = 2, Value = 255
                Key = 6, Value =
                Key = 7, Value = System.Single[]//pos
                Key = 8, Value = System.Single[] //pos target
                Key = 9, Value = 35362072
                Key = 10, Value = 6,401981
                Key = 11, Value = 3
                Key = 13, Value = 20 //health
                Key = 14, Value = 20
                Key = 16, Value = 35254961
                Key = 20, Value = 261954
                Key = 252, Value = 106
                [0] objectId
                [1] typeId
                [8] moveTarget
                [13] Health
             */
            int id = int.Parse(parameters[0].ToString());
            int typeId = int.Parse(parameters[1].ToString());
            Single[] loc = (Single[])parameters[8];
            Single posX = (Single)loc[0];
            Single posY = (Single)loc[1];
            int health = int.Parse(parameters[13].ToString());

            mobsHandler.AddMob(id, typeId, posX, posY, health);
        }
        private void onNewSimpleHarvestableObjectList(Dictionary<byte, object> parameters)
        {
            //return;
           // foreach (KeyValuePair<byte, object> kvp in parameters)
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            List<int> a0 = new List<int>();
            if (parameters[0].GetType() == typeof(Byte[]))
            {
                Byte[] typeListByte = (Byte[])parameters[0]; //list of types
                foreach (Byte b in typeListByte)
                    a0.Add(b);
            }
            else if (parameters[0].GetType() == typeof(Int16[]))
            {
                Int16[] typeListByte = (Int16[])parameters[0]; //list of types
                foreach (Int16 b in typeListByte)
                    a0.Add(b);
            }
            else
            {
                Console.WriteLine("onNewSimpleHarvestableObjectList type error: " + parameters[0].GetType());
                return;
            }
            try
            {
                /*
                Key = 0, Value = System.Int16[] //id
                Key = 1, Value = System.Byte[] // type WOOD etc
                Key = 2, Value = System.Byte[] // tier
                Key = 3, Value = System.Single[] //location
                Key = 4, Value = System.Byte[] // size
                Key = 252, Value = 29
                 */
                Byte[] a1 = (Byte[])parameters[1]; //list of types
                Byte[] a2 = (Byte[])parameters[2]; //list of tiers
                Single[] a3 = (Single[])parameters[3]; //list of positions X1, Y1, X2, Y2 ...
                Byte[] a4 = (Byte[])parameters[4]; //size

                for (int i = 0; i < a0.Count; i++)
                {
                    int id = (int)a0.ElementAt(i);
                    byte type = (byte)a1[i];
                    byte tier = (byte)a2[i];
                    Single posX = (Single)a3[i * 2];
                    Single posY = (Single)a3[i * 2 + 1];
                    Byte count = (byte)a4[i];
                    byte charges = (byte)0;
                    harvestableHandler.AddHarvestable(id, type, tier, posX, posY, charges, count);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("eL: " + e.ToString());
            }
        }
        private void onNewHarvestableObject(Dictionary<byte, object> parameters)
        {
           // Console.WriteLine("onNewHarvestableObject");
          //  foreach (KeyValuePair<byte, object> kvp in parameters)
         //        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            /*
                //Key = 10, Value = 2 //count. If not set its empty
                Key = 0, Value = 7589
                Key = 2, Value = 636712223127023853
                Key = 5, Value = 11
                Key = 6, Value = -1
                Key = 7, Value = 6
                Key = 8, Value = System.Single[]
                Key = 9, Value = 270
                Key = 11, Value = 1
                Key = 252, Value = 30
             */
            int id = int.Parse(parameters[0].ToString());
            byte type = byte.Parse(parameters[5].ToString()); //TODO - check if 5 is type
            byte tier = byte.Parse(parameters[7].ToString()); //Tier
            Single[] loc = (Single[])parameters[8];
            Single posX = (Single)loc[0];
            Single posY = (Single)loc[1];
            byte charges = 0;
            byte size = 0;
            if (!byte.TryParse(parameters[10].ToString(), out size))
                size = 0; //nothink in stack

            if (!byte.TryParse(parameters[11].ToString(), out charges))
                charges = 0; // charge 

            harvestableHandler.AddHarvestable(id, type, tier, posX, posY, charges, size);
        }
        private void onHarvestFinished(Dictionary<byte, object> parameters)
        {//
           // foreach (KeyValuePair<byte, object> kvp in parameters)
           //     Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            int harvestableId = int.Parse(parameters[3].ToString());
            //Int32 count = Int32.Parse(parameters[2].ToString());

            harvestableHandler.RemoveHarvestable(harvestableId);
            //harvestableHandler.UpdateHarvestable(harvestableId, count);
        }
        private void onHarvestableChangeState(Dictionary<byte, object> parameters)
        {
            /*
             onHarvestableChangeState
                Key = 0, Value = 5803
                Key = 1, Value = 2 //how much more to mine
                Key = 2, Value = 1 //tier
                Key = 252, Value = 33
             */
           // Console.WriteLine("onHarvestableChangeState");
            //foreach (KeyValuePair<byte, object> kvp in parameters)
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
        private void onLeave(Dictionary<byte, object> parameters)
        {

            /*
             onLeave contains strange data. It should delete Harvestable + Players + Monsters. But its sketchy.
             */
             int id = int.Parse(parameters[0].ToString());
           //  if (harvestableHandler.RemoveHarvestable(id))
           //      Console.WriteLine("Removed harvestable: " + id);
           //  else 
             if (playerHandler.RemovePlayer(id))
                 playerHandler.RemovePlayer(id);
                 //Console.WriteLine("Removed player: " + id);
            // else
            //     Console.WriteLine("None removed: " + id);
            
        }
        private void onLocalPlayerMovement(Dictionary<byte, object> parameters)
        {
            Single[] location = (Single[])parameters[1]; //if we switch to [3] we will have future position of player instead of 'right now'
            Single posX = Single.Parse(location[0].ToString());
            Single posY = Single.Parse(location[1].ToString());
            // Console.WriteLine("onLocalPlayerMovement: " +posX + " " + posY);
            // 373,6958 -358,3227 top of map
            //-375,2436 366,6795 bottom of map

            playerHandler.UpdateLocalPlayerPosition(posX, posY);
        }
        private void onPlayerMovement(Dictionary<byte, object> parameters)
        {
            int id = int.Parse(parameters[0].ToString());
            Byte[] a = (Byte[])parameters[1];
            Single posX = BitConverter.ToSingle(a, 9);
            Single posY = BitConverter.ToSingle(a, 13);
            //Console.WriteLine("X:" + posX + " Y:" + posY);

            playerHandler.UpdatePlayerPosition(id, posX, posY);
        }
        private void onNewCharacterEvent(Dictionary<byte, object> parameters){

            if (Settings.PlaySoundOnPlayer())
                new Thread(() => Console.Beep(1000,1000)).Start();


            int id = int.Parse(parameters[0].ToString());
            string nick = parameters[1].ToString();
            object oGuild = "";
            parameters.TryGetValue((byte)8, out oGuild);
            string guild = oGuild == null ? "" : oGuild.ToString();

            //string guild = parameters[8].ToString() || null;
            string alliance = parameters[44].ToString();

            Single[] a13 = (Single[])parameters[13]; //pos1

            playerHandler.AddPlayer(a13[0], a13[1], nick, guild, alliance, id);
        }
    }
}
