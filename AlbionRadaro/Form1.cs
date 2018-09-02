using AlbionRadaro.Mobs;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        MobsHandler mobsHandler = new MobsHandler();

        MapForm mapForm = new MapForm();

        public Form1()
        {
            InitializeComponent();
            mapForm.Show();
            Settings.loadSettings(this);
            updateSettings();
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
                _eventHandler = new PacketHandler(playerHandler, harvestableHandler, mobsHandler);
                photonPacketHandler = new PhotonPacketHandler(_eventHandler);

                Thread t = new Thread(() => createListener());
                t.Start();

                Thread d = new Thread(() => drawerThread());
                d.Start();
            }
            catch (Exception ea)
            {
                Console.WriteLine(ea.ToString());
                while (true) ;
            }
        }

        private void drawerThread()
        {
            Pen linePen = new Pen(Color.Red,3);
            Brush[] harvestBrushes = {
                Brushes.Black,
                Brushes.Gray, 
                Brushes.Gray, 
                Brushes.Gray, 
                Brushes.Blue, 
                Brushes.Red, 
                Brushes.Coral, 
                Brushes.Goldenrod, 
                Brushes.Silver
            };
            Brush[] fontPerColor = {
                Brushes.White,
                Brushes.White, 
                Brushes.White, 
                Brushes.White, 
                Brushes.White, 
                Brushes.White, 
                Brushes.Black, 
                Brushes.Black, 
                Brushes.Black
                                        
            };
            Pen[] chargePen = {
                new Pen (Color.Green, 1.5f),
                new Pen(Color.Blue, 1.5f), 
                new Pen(Color.Purple, 1.5f), 
            };
            Pen playerPen = new Pen(Color.Red, 2f);
            Brush playerBrush = Brushes.Red;
            Brush mobBrush = Brushes.Black;

            int HEIGHT, WIDTH, MULTIPLER = 4;
            HEIGHT = mapForm.pictureBox2.Height;
            WIDTH = mapForm.pictureBox2.Height;
            Bitmap bitmap = new Bitmap(WIDTH, HEIGHT);
            bitmap.SetResolution(100, 100);
            Single lpX;
            Single lpY;
            Font font = new Font("Arial", 3, FontStyle.Bold);

            float scale = 4.0f;
            mapForm.pictureBox2.Image = bitmap;
            while (true)
            {

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    
                    g.Clear(Color.Transparent);
                    lpX = playerHandler.localPlayerPosX();
                    lpY = playerHandler.localPlayerPosY();

                    g.TranslateTransform(WIDTH / 2, HEIGHT / 2);

                    g.FillEllipse(Brushes.Black, -2, -2, 4, 4);
                    g.DrawEllipse(linePen, -80, -80, 160, 160);
                    g.DrawEllipse(linePen, -170, -170, 340, 340);
                    g.DrawEllipse(linePen, -WIDTH / 2, -HEIGHT / 2, WIDTH - 1, HEIGHT - 1);

                    g.ScaleTransform(scale, scale);
                    
                    List<Harvestable> hLis = new List<Harvestable>();
                    lock (harvestableHandler) { 
                        try{
                            hLis = this.harvestableHandler.HarvestableList.ToList();
                        }catch (Exception e1){}
                    }
                    foreach (Harvestable h in hLis){
                        if (!Settings.IsInTiers(h.Tier, h.Charges)) continue;
                        if (!Settings.IsInHarvestable((HarvestableType)h.Type)) continue;
                        
                        if (h.Size == 0) continue;

                        Single hX = -1* h.PosX + lpX;
                        Single hY = h.PosY - lpY;

                        g.FillEllipse(harvestBrushes[h.Tier], (float)(hX - 2.5f), (float)(hY - 2.5f), 5f, 5f);
                        g.TranslateTransform(hX, hY);
                        g.RotateTransform(135f);
                        g.DrawString(h.getMapInfo(), font, fontPerColor[h.Tier]/*harvestBrushes[h.Tier]*/, -2.5f, -2.5f);
                        g.RotateTransform(-135f);
                        g.TranslateTransform(-hX, -hY);


                        if (h.Charges > 0) g.DrawEllipse(chargePen[h.Charges - 1], hX - 3, hY - 3, 6, 6);
                    }

                    if (Settings.DisplayPeople){
                        List<Player> pLis = new List<Player>();
                        lock (this.playerHandler.PlayersInRange){
                            try{
                                pLis = this.playerHandler.PlayersInRange.ToList();
                            }catch (Exception e2){}
                        }

                        foreach (Player p in pLis) {
                            Single hX = -1 * p.PosX + lpX;
                            Single hY = p.PosY - lpY;
                            g.FillEllipse(playerBrush, hX, hY, 4, 4);
                        }
                    }
                    if (Settings.LivingEntities)
                    { 
                        List<Mob> mList = new List<Mob>();
                        lock (mobsHandler.MobList){
                            try{
                                mList = this.mobsHandler.MobList.ToList();
                            }catch (Exception e1){}
                        }

                        foreach (Mob m in mList) {
                            Single hX = -1 * m.PosX + lpX;
                            Single hY = m.PosY - lpY;
                            g.FillEllipse(mobBrush, hX, hY, 3, 3);
                        }
                    }
                    mapForm.pictureBox2.Image = RotateImage(bitmap, 225f);

                    if (mapForm.pictureBox2.InvokeRequired)
                    {
                        mapForm.pictureBox2.Invoke((Action)(() => { 
                            //invoked code
                        }));
                    }

                }
                Thread.Sleep(10);
               /* if(false)
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


                   List<Mob> mList = new List<Mob>();
                      lock (mobsHandler.MobList)
                      {
                          try
                          {
                              mList = this.mobsHandler.MobList.ToList();
                          }
                          catch (Exception e1)
                          {
                              //TODO - there is thread conflict. From time to time there is exception // maybe thread safe list?
                          }
                      }
                      foreach (Mob m in mList)
                          g.FillEllipse(mobBrush, m.PosX * MULTIPLER - 3 - lpX, m.PosY * MULTIPLER - 3 - lpY, 6, 6);
                            
                              
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
                */
                ///Thread.Sleep(1000);
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
            Settings.UpdateTier(1, 0, this.cbTier1230.Checked);
            Settings.UpdateTier(2, 0, this.cbTier1230.Checked);
            Settings.UpdateTier(3, 0, this.cbTier1230.Checked);

            Settings.UpdateTier(4, 0, this.cbTier40.Checked);
            Settings.UpdateTier(4, 1, this.cbTier41.Checked);
            Settings.UpdateTier(4, 2, this.cbTier42.Checked);
            Settings.UpdateTier(4, 3, this.cbTier43.Checked);

            Settings.UpdateTier(5, 0, this.cbTier50.Checked);
            Settings.UpdateTier(5, 1, this.cbTier51.Checked);
            Settings.UpdateTier(5, 2, this.cbTier52.Checked);
            Settings.UpdateTier(5, 3, this.cbTier53.Checked);

            Settings.UpdateTier(6, 0, this.cbTier60.Checked);
            Settings.UpdateTier(6, 1, this.cbTier61.Checked);
            Settings.UpdateTier(6, 2, this.cbTier62.Checked);
            Settings.UpdateTier(6, 3, this.cbTier63.Checked);

            Settings.UpdateTier(7, 0, this.cbTier70.Checked);
            Settings.UpdateTier(7, 1, this.cbTier71.Checked);
            Settings.UpdateTier(7, 2, this.cbTier72.Checked);
            Settings.UpdateTier(7, 3, this.cbTier73.Checked);

            Settings.UpdateTier(8, 0, this.cbTier80.Checked);
            Settings.UpdateTier(8, 1, this.cbTier81.Checked);
            Settings.UpdateTier(8, 2, this.cbTier82.Checked);
            Settings.UpdateTier(8, 3, this.cbTier83.Checked);

            

            Settings.UpdateHarvestable(new List<HarvestableType>{
                HarvestableType.FIBER,
                HarvestableType.FIBER_CRITTER,
                HarvestableType.FIBER_GUARDIAN_DEAD,
                HarvestableType.FIBER_GUARDIAN_RED
            }, this.cbFiber.Checked);
            Settings.UpdateHarvestable(new List<HarvestableType>{
                HarvestableType.WOOD,
                HarvestableType.WOOD_CRITTER_DEAD,
                HarvestableType.WOOD_CRITTER_GREEN,
                HarvestableType.WOOD_CRITTER_RED,
                HarvestableType.WOOD_GIANTTREE,
                HarvestableType.WOOD_GUARDIAN_RED
            }, this.cbWood.Checked);
            Settings.UpdateHarvestable(new List<HarvestableType>{
                HarvestableType.ORE,
                HarvestableType.ORE_CRITTER_DEAD,
                HarvestableType.ORE_CRITTER_GREEN,
                HarvestableType.ORE_CRITTER_RED,
                HarvestableType.ORE_GUARDIAN_RED
            }, this.cbOre.Checked);
            Settings.UpdateHarvestable(new List<HarvestableType>{
                HarvestableType.ROCK,
                HarvestableType.ROCK_CRITTER_DEAD,
                HarvestableType.ROCK_CRITTER_GREEN,
                HarvestableType.ROCK_CRITTER_RED,
                HarvestableType.ROCK_GUARDIAN_RED
            }, this.cbRock.Checked);
            Settings.UpdateHarvestable(new List<HarvestableType>{
                HarvestableType.HIDE,
                HarvestableType.HIDE_CRITTER,
                HarvestableType.HIDE_FOREST,
                HarvestableType.HIDE_GUARDIAN,
                HarvestableType.HIDE_HIGHLAND,
                HarvestableType.HIDE_MOUNTAIN,
                HarvestableType.HIDE_STEPPE,
                HarvestableType.HIDE_SWAMP
            }, this.cbTreasures.Checked);
            Settings.setSoundsOnPlayer(cbSounds.Checked);
            Settings.showEntities(this.cbEntities.Checked);


            Settings.saveSettings(this);
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


        private void cbSounds_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

    }
}
