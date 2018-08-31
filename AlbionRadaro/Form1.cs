using PcapDotNet.Core;
using PcapDotNet.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AlbionRadaro
{
    public partial class Form1 : Form
    {

        PacketHandler _eventHandler;
        PhotonPacketHandler photonPacketHandler;

        PlayerHandler playerHandler = new PlayerHandler();
        HarvestableHandler harvestableHandler = new HarvestableHandler();
        MapForm mapForm = new MapForm();

        public Form1()
        {
            InitializeComponent();
            mapForm.Show();

            //harvestableHandler.HarvestableList.Add(new Harvestable(0, 0, 0, 100, 100, 0));
            // harvestableHandler.HarvestableList.Add(new Harvestable(0, 0, 0, 200, 200, 0));
            // harvestableHandler.HarvestableList.Add(new Harvestable(0, 0, 0, 100, 200, 0));
            // harvestableHandler.HarvestableList.Add(new Harvestable(0, 0, 0, 200, 100, 0));
        }
        public static Bitmap RotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            updateSettings();
            try
            {
                _eventHandler = new PacketHandler(playerHandler, harvestableHandler);
                photonPacketHandler = new PhotonPacketHandler(_eventHandler);

                Thread t = new Thread(() =>
                {
                    createListener();
                });
                t.Start();

                Thread d = new Thread(() =>
                {
                    Pen linePen = new Pen(Color.Black, 2f);
                    Brush[] harvestBrushes = {
                                           Brushes.Black,
                                           Brushes.Gray, 
                                           Brushes.Gray, 
                                           Brushes.Gray, 
                                           Brushes.Blue, 
                                           Brushes.Red, 
                                           Brushes.Orange, 
                                           Brushes.Gold, 
                                           Brushes.Silver
                                       };
                    Pen[] chargePen = {
                            new Pen (Color.Green, 3f),
                            new Pen(Color.Blue, 4f), 
                            new Pen(Color.Purple, 5f), 
                        };
                    Pen playerPen = new Pen(Color.Red, 2f);
                    Brush playerBrush = Brushes.Red;
                    int HEIGHT, WIDTH, MULTIPLER = 4;
                    HEIGHT = mapForm.pictureBox1.Height;
                    WIDTH = mapForm.pictureBox1.Height;
                    Bitmap bitmap = new Bitmap(WIDTH, HEIGHT);

                    Single lpX;
                    Single lpY;
                    Font font = new Font("Arial", 11, FontStyle.Bold);
                    while (true)
                    {

                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            g.Clear(Color.Transparent);
                            lpX = playerHandler.localPlayerPosX() * MULTIPLER;
                            lpY = playerHandler.localPlayerPosY() * MULTIPLER;
                            g.InterpolationMode = InterpolationMode.NearestNeighbor;
                            g.TranslateTransform(WIDTH / 2, HEIGHT / 2);

                            g.FillEllipse(Brushes.Black, -2, -2, 4, 4);
                            g.DrawEllipse(linePen, -80, -80, 160, 160);
                            g.DrawEllipse(linePen, -170, -170, 340, 340);
                            g.DrawEllipse(linePen, -WIDTH / 2, -HEIGHT / 2, WIDTH - 1, HEIGHT - 1);

                            List<Harvestable> hLis = new List<Harvestable>();
                            lock (harvestableHandler)
                            {
                                try
                                {
                                    hLis = this.harvestableHandler.HarvestableList.ToList();
                                }
                                catch (Exception e1)
                                {
                                    //TODO - there is thread conflict. From time to time there is exception // maybe thread safe list?
                                }
                            }
                            foreach (Harvestable h in hLis)
                            {
                                if (!Settings.IsInTiers(h.Tier)) continue;
                                if (!Settings.IsInHarvestable((HarvestableType)h.Type)) continue;
                                if (Settings.OnlyRares() && h.Charges == 0) continue;
                                if (h.Size == 0) continue;

                                SizeF sizeOfMapInfo = g.MeasureString(h.getMapInfo(), font);

                                Bitmap b = new Bitmap((int)sizeOfMapInfo.Width * 2, (int)sizeOfMapInfo.Width * 2);
                                b.MakeTransparent();
                                Graphics gg = Graphics.FromImage(b);
                                gg.InterpolationMode = InterpolationMode.NearestNeighbor;
                                gg.Clear(Color.Transparent);
                                gg.TranslateTransform(sizeOfMapInfo.Width / 2, sizeOfMapInfo.Width / 2);
                                gg.RotateTransform(-45f);
                                gg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                                gg.DrawString(h.getMapInfo(), font, harvestBrushes[h.Tier], 0, 0);
                                gg.TranslateTransform(-sizeOfMapInfo.Width / 2, -sizeOfMapInfo.Width / 2);
                                b.RotateFlip(RotateFlipType.Rotate180FlipX);

                                float imagePosX = h.PosX * MULTIPLER - lpX - (sizeOfMapInfo.Width / 2) - (sizeOfMapInfo.Width / 2);
                                float imagePosY = h.PosY * MULTIPLER - lpY - (sizeOfMapInfo.Width / 2) - (sizeOfMapInfo.Height / 2);

                                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                                g.FillEllipse(Brushes.Black, h.PosX * MULTIPLER - 10 - lpX + 2, h.PosY * MULTIPLER - 10 - lpY + 7, 20, 20);


                                g.DrawImage(b, imagePosX, imagePosY);

                                if (h.Charges == 1) g.DrawEllipse(chargePen[0], h.PosX * MULTIPLER - 10 - lpX + 2, h.PosY * MULTIPLER - 10 - lpY + 7, 20, 20);
                                else if (h.Charges == 2) g.DrawEllipse(chargePen[1], h.PosX * MULTIPLER - 12 - lpX + 2, h.PosY * MULTIPLER - 12 - lpY + 7, 24, 24);
                                else if (h.Charges == 3) g.DrawEllipse(chargePen[2], h.PosX * MULTIPLER - 14 - lpX + 2, h.PosY * MULTIPLER - 14 - lpY + 7, 28, 28);

                            }
                            if (Settings.DisplayPeople)
                            {
                                List<Player> pLis = new List<Player>();
                                lock (this.playerHandler.PlayersInRange)
                                {
                                    try
                                    {
                                        pLis = this.playerHandler.PlayersInRange.ToList();
                                    }
                                    catch (Exception e2)
                                    {
                                        //TODO - there is thread conflict. From time to time there is exception 
                                    }
                                }

                                foreach (Player p in pLis)
                                    g.FillEllipse(playerBrush, p.PosX * MULTIPLER - 3 - lpX, p.PosY * MULTIPLER - 3 - lpY, 6, 6);
                            }

                            g.TranslateTransform(-WIDTH / 2, -HEIGHT / 2);
                            bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                            mapForm.pictureBox1.Image = RotateImage(bitmap, -45f);

                        }
                        Thread.Sleep(100);
                    }
                });
                d.Start();
            }
            catch (Exception ea)
            {
                Console.WriteLine(ea.ToString());
                while (true) ;
            }
        }
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        private void createListener()
        {
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
            if (allDevices.Count == 0)
            {
                MessageBox.Show("No interfaces found! Make sure WinPcap is installed.");
                return;
            }
            // Print the list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];

                if (device.Description != null)
                    Console.WriteLine(" (" + device.Description + ")");
                else
                    Console.WriteLine(" (No description available)");
            }

            foreach (PacketDevice selectedDevice in allDevices.ToList())
            {
                // Open the device
                Thread t = new Thread(() =>
                {
                    using (PacketCommunicator communicator =
                           selectedDevice.Open(65536,                                  // portion of the packet to capture
                        // 65536 guarantees that the whole packet will be captured on all the link layers
                                               PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                               1000))                                  // read timeout
                    {
                        // Check the link layer. We support only Ethernet for simplicity.
                        if (communicator.DataLink.Kind != DataLinkKind.Ethernet)
                        {
                            Console.WriteLine("This program works only on Ethernet networks.");
                            return;
                        }

                        // Compile the filter
                        using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and udp"))
                        {
                            // Set the filter
                            communicator.SetFilter(filter);
                        }

                        Console.WriteLine("Listening on " + selectedDevice.Description + "...");

                        // start the capture
                        communicator.ReceivePackets(0, photonPacketHandler.PacketHandler);

                    }
                });
                t.Start();
            }

        }

        private void updateSettings()
        {
            Settings.UpdateTier(1, this.tier1.Checked);
            Settings.UpdateTier(2, this.tier2.Checked);
            Settings.UpdateTier(3, this.tier3.Checked);
            Settings.UpdateTier(4, this.tier4.Checked);
            Settings.UpdateTier(5, this.tier5.Checked);
            Settings.UpdateTier(6, this.tier6.Checked);
            Settings.UpdateTier(7, this.tier7.Checked);
            Settings.UpdateTier(8, this.tier8.Checked);
            Settings.UpdateOnlyRares(this.onlyRares.Checked);
            Settings.UpdateHarvestable(HarvestableType.FIBER, this.cbFiber.Checked);
            Settings.UpdateHarvestable(HarvestableType.WOOD, this.cbWood.Checked);
            Settings.UpdateHarvestable(HarvestableType.ORE, this.cbOre.Checked);
            Settings.UpdateHarvestable(HarvestableType.ROCK, this.cbRock.Checked);
            Settings.UpdateHarvestable(HarvestableType.HIDE, this.cbTreasures.Checked);
            Settings.setSoundsOnPlayer(cbSounds.Checked);
        }
        private void tierCheckChange(object sender, EventArgs e)
        {
            updateSettings();
        }
        private void harvestableCheckChange(object sender, EventArgs e)
        {
            updateSettings();

        }

        private void cbDisplayPeople_CheckedChanged(object sender, EventArgs e)
        {
            Settings.UpdateDisplayPeople(this.cbDisplayPeople.Checked);
        }
        private MouseClickMessageFilter Filter;

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        bool mapFormIsVisible = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!mapFormIsVisible)
            {
                mapForm.Opacity = 1;
                mapForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                var location = mapForm.PointToScreen(new Point(0, 0));
                mapForm.Top = location.Y - 30;

                mapForm.BackColor = System.Drawing.SystemColors.Control;
                mapForm.TransparencyKey = Color.Transparent;
                mapFormIsVisible = true;
                button1.Text = "Hide map window";
            }
            else
            {
                button1.Text = "Show map window";
                mapFormIsVisible = false;

                mapForm.FormBorderStyle = FormBorderStyle.None;
                if ((this.Filter != null))
                {
                    Application.RemoveMessageFilter(this.Filter);
                    this.Filter = null;
                }
                UInt32 initialStyle = GetWindowLong(mapForm.Handle, -20);
                SetWindowLong(mapForm.Handle, -20, (uint)initialStyle | 0x80000 | 0x20);
                SetWindowPos(mapForm.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }


        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (mapForm.BackColor != System.Drawing.SystemColors.Control)
            {
                mapForm.BackColor = System.Drawing.SystemColors.Control;
                mapForm.TransparencyKey = Color.Transparent;
            }
            else
            {
                mapForm.BackColor = Color.White;
                mapForm.TransparencyKey = Color.White;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {

        }

        private void cbSounds_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }


    }
}
