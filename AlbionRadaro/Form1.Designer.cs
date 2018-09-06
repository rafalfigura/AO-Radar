namespace AlbionRadaro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRock = new System.Windows.Forms.CheckBox();
            this.cbOre = new System.Windows.Forms.CheckBox();
            this.cbWood = new System.Windows.Forms.CheckBox();
            this.cbTreasures = new System.Windows.Forms.CheckBox();
            this.cbFiber = new System.Windows.Forms.CheckBox();
            this.cbHarvestable = new System.Windows.Forms.CheckBox();
            this.cbSkinnable = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSounds = new System.Windows.Forms.CheckBox();
            this.cbDisplayPeople = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTier1230 = new System.Windows.Forms.CheckBox();
            this.cbTier40 = new System.Windows.Forms.CheckBox();
            this.cbTier50 = new System.Windows.Forms.CheckBox();
            this.cbTier60 = new System.Windows.Forms.CheckBox();
            this.cbTier70 = new System.Windows.Forms.CheckBox();
            this.cbTier80 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTier43 = new System.Windows.Forms.CheckBox();
            this.cbTier42 = new System.Windows.Forms.CheckBox();
            this.cbTier41 = new System.Windows.Forms.CheckBox();
            this.cbTier83 = new System.Windows.Forms.CheckBox();
            this.cbTier82 = new System.Windows.Forms.CheckBox();
            this.cbTier73 = new System.Windows.Forms.CheckBox();
            this.cbTier72 = new System.Windows.Forms.CheckBox();
            this.cbTier63 = new System.Windows.Forms.CheckBox();
            this.cbTier62 = new System.Windows.Forms.CheckBox();
            this.cbTier53 = new System.Windows.Forms.CheckBox();
            this.cbTier52 = new System.Windows.Forms.CheckBox();
            this.cbTier81 = new System.Windows.Forms.CheckBox();
            this.cbTier71 = new System.Windows.Forms.CheckBox();
            this.cbTier61 = new System.Windows.Forms.CheckBox();
            this.cbTier51 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbOtherMobs = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nRadarY = new System.Windows.Forms.NumericUpDown();
            this.nRadarX = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadarX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRock);
            this.groupBox2.Controls.Add(this.cbOre);
            this.groupBox2.Controls.Add(this.cbWood);
            this.groupBox2.Controls.Add(this.cbTreasures);
            this.groupBox2.Controls.Add(this.cbFiber);
            this.groupBox2.Location = new System.Drawing.Point(129, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 93);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resources";
            // 
            // cbRock
            // 
            this.cbRock.AutoSize = true;
            this.cbRock.Checked = true;
            this.cbRock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRock.Location = new System.Drawing.Point(73, 19);
            this.cbRock.Name = "cbRock";
            this.cbRock.Size = new System.Drawing.Size(52, 17);
            this.cbRock.TabIndex = 4;
            this.cbRock.Text = "Rock";
            this.cbRock.UseVisualStyleBackColor = true;
            this.cbRock.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbOre
            // 
            this.cbOre.AutoSize = true;
            this.cbOre.Checked = true;
            this.cbOre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOre.Location = new System.Drawing.Point(73, 42);
            this.cbOre.Name = "cbOre";
            this.cbOre.Size = new System.Drawing.Size(43, 17);
            this.cbOre.TabIndex = 2;
            this.cbOre.Text = "Ore";
            this.cbOre.UseVisualStyleBackColor = true;
            this.cbOre.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbWood
            // 
            this.cbWood.AutoSize = true;
            this.cbWood.Checked = true;
            this.cbWood.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWood.Location = new System.Drawing.Point(6, 42);
            this.cbWood.Name = "cbWood";
            this.cbWood.Size = new System.Drawing.Size(55, 17);
            this.cbWood.TabIndex = 1;
            this.cbWood.Text = "Wood";
            this.cbWood.UseVisualStyleBackColor = true;
            this.cbWood.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbTreasures
            // 
            this.cbTreasures.AutoSize = true;
            this.cbTreasures.Checked = true;
            this.cbTreasures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTreasures.Location = new System.Drawing.Point(6, 65);
            this.cbTreasures.Name = "cbTreasures";
            this.cbTreasures.Size = new System.Drawing.Size(73, 17);
            this.cbTreasures.TabIndex = 7;
            this.cbTreasures.Text = "Treasures";
            this.cbTreasures.UseVisualStyleBackColor = true;
            this.cbTreasures.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbFiber
            // 
            this.cbFiber.AutoSize = true;
            this.cbFiber.Checked = true;
            this.cbFiber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFiber.Location = new System.Drawing.Point(6, 19);
            this.cbFiber.Name = "cbFiber";
            this.cbFiber.Size = new System.Drawing.Size(49, 17);
            this.cbFiber.TabIndex = 0;
            this.cbFiber.Text = "Fiber";
            this.cbFiber.UseVisualStyleBackColor = true;
            this.cbFiber.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbHarvestable
            // 
            this.cbHarvestable.AutoSize = true;
            this.cbHarvestable.Location = new System.Drawing.Point(6, 42);
            this.cbHarvestable.Name = "cbHarvestable";
            this.cbHarvestable.Size = new System.Drawing.Size(83, 17);
            this.cbHarvestable.TabIndex = 6;
            this.cbHarvestable.Text = "Harvestable";
            this.cbHarvestable.UseVisualStyleBackColor = true;
            this.cbHarvestable.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbSkinnable
            // 
            this.cbSkinnable.AutoSize = true;
            this.cbSkinnable.Location = new System.Drawing.Point(6, 19);
            this.cbSkinnable.Name = "cbSkinnable";
            this.cbSkinnable.Size = new System.Drawing.Size(73, 17);
            this.cbSkinnable.TabIndex = 3;
            this.cbSkinnable.Text = "Skinnable";
            this.cbSkinnable.UseVisualStyleBackColor = true;
            this.cbSkinnable.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSounds);
            this.groupBox3.Controls.Add(this.cbDisplayPeople);
            this.groupBox3.Location = new System.Drawing.Point(14, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 72);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "People Radar";
            // 
            // cbSounds
            // 
            this.cbSounds.AutoSize = true;
            this.cbSounds.Location = new System.Drawing.Point(6, 42);
            this.cbSounds.Name = "cbSounds";
            this.cbSounds.Size = new System.Drawing.Size(103, 17);
            this.cbSounds.TabIndex = 10;
            this.cbSounds.Text = "Sound on player";
            this.cbSounds.UseVisualStyleBackColor = true;
            this.cbSounds.CheckedChanged += new System.EventHandler(this.cbSounds_CheckedChanged);
            // 
            // cbDisplayPeople
            // 
            this.cbDisplayPeople.AutoSize = true;
            this.cbDisplayPeople.Checked = true;
            this.cbDisplayPeople.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDisplayPeople.Location = new System.Drawing.Point(6, 19);
            this.cbDisplayPeople.Name = "cbDisplayPeople";
            this.cbDisplayPeople.Size = new System.Drawing.Size(96, 17);
            this.cbDisplayPeople.TabIndex = 8;
            this.cbDisplayPeople.Text = "Display People";
            this.cbDisplayPeople.UseVisualStyleBackColor = true;
            this.cbDisplayPeople.CheckedChanged += new System.EventHandler(this.cbDisplayPeople_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Made by Sahee#1014";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // cbTier1230
            // 
            this.cbTier1230.AutoSize = true;
            this.cbTier1230.Location = new System.Drawing.Point(8, 17);
            this.cbTier1230.Name = "cbTier1230";
            this.cbTier1230.Size = new System.Drawing.Size(56, 17);
            this.cbTier1230.TabIndex = 0;
            this.cbTier1230.Text = "1, 2, 3";
            this.cbTier1230.UseVisualStyleBackColor = true;
            this.cbTier1230.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier40
            // 
            this.cbTier40.AutoSize = true;
            this.cbTier40.Location = new System.Drawing.Point(8, 58);
            this.cbTier40.Name = "cbTier40";
            this.cbTier40.Size = new System.Drawing.Size(32, 17);
            this.cbTier40.TabIndex = 3;
            this.cbTier40.Text = "4";
            this.cbTier40.UseVisualStyleBackColor = true;
            this.cbTier40.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier50
            // 
            this.cbTier50.AutoSize = true;
            this.cbTier50.Checked = true;
            this.cbTier50.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier50.Location = new System.Drawing.Point(8, 79);
            this.cbTier50.Name = "cbTier50";
            this.cbTier50.Size = new System.Drawing.Size(32, 17);
            this.cbTier50.TabIndex = 4;
            this.cbTier50.Text = "5";
            this.cbTier50.UseVisualStyleBackColor = true;
            this.cbTier50.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier60
            // 
            this.cbTier60.AutoSize = true;
            this.cbTier60.Checked = true;
            this.cbTier60.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier60.Location = new System.Drawing.Point(8, 99);
            this.cbTier60.Name = "cbTier60";
            this.cbTier60.Size = new System.Drawing.Size(32, 17);
            this.cbTier60.TabIndex = 5;
            this.cbTier60.Text = "6";
            this.cbTier60.UseVisualStyleBackColor = true;
            this.cbTier60.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier70
            // 
            this.cbTier70.AutoSize = true;
            this.cbTier70.Checked = true;
            this.cbTier70.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier70.Location = new System.Drawing.Point(8, 118);
            this.cbTier70.Name = "cbTier70";
            this.cbTier70.Size = new System.Drawing.Size(32, 17);
            this.cbTier70.TabIndex = 6;
            this.cbTier70.Text = "7";
            this.cbTier70.UseVisualStyleBackColor = true;
            this.cbTier70.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier80
            // 
            this.cbTier80.AutoSize = true;
            this.cbTier80.Checked = true;
            this.cbTier80.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier80.Location = new System.Drawing.Point(8, 139);
            this.cbTier80.Name = "cbTier80";
            this.cbTier80.Size = new System.Drawing.Size(32, 17);
            this.cbTier80.TabIndex = 7;
            this.cbTier80.Text = "8";
            this.cbTier80.UseVisualStyleBackColor = true;
            this.cbTier80.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTier43);
            this.groupBox1.Controls.Add(this.cbTier42);
            this.groupBox1.Controls.Add(this.cbTier41);
            this.groupBox1.Controls.Add(this.cbTier40);
            this.groupBox1.Controls.Add(this.cbTier1230);
            this.groupBox1.Controls.Add(this.cbTier83);
            this.groupBox1.Controls.Add(this.cbTier82);
            this.groupBox1.Controls.Add(this.cbTier73);
            this.groupBox1.Controls.Add(this.cbTier72);
            this.groupBox1.Controls.Add(this.cbTier63);
            this.groupBox1.Controls.Add(this.cbTier62);
            this.groupBox1.Controls.Add(this.cbTier53);
            this.groupBox1.Controls.Add(this.cbTier52);
            this.groupBox1.Controls.Add(this.cbTier81);
            this.groupBox1.Controls.Add(this.cbTier71);
            this.groupBox1.Controls.Add(this.cbTier61);
            this.groupBox1.Controls.Add(this.cbTier51);
            this.groupBox1.Controls.Add(this.cbTier80);
            this.groupBox1.Controls.Add(this.cbTier70);
            this.groupBox1.Controls.Add(this.cbTier60);
            this.groupBox1.Controls.Add(this.cbTier50);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = ".3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = ".2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = ".1";
            // 
            // cbTier43
            // 
            this.cbTier43.AutoSize = true;
            this.cbTier43.Location = new System.Drawing.Point(82, 59);
            this.cbTier43.Name = "cbTier43";
            this.cbTier43.Size = new System.Drawing.Size(15, 14);
            this.cbTier43.TabIndex = 31;
            this.cbTier43.UseVisualStyleBackColor = true;
            this.cbTier43.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier42
            // 
            this.cbTier42.AutoSize = true;
            this.cbTier42.Location = new System.Drawing.Point(61, 59);
            this.cbTier42.Name = "cbTier42";
            this.cbTier42.Size = new System.Drawing.Size(15, 14);
            this.cbTier42.TabIndex = 30;
            this.cbTier42.UseVisualStyleBackColor = true;
            this.cbTier42.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier41
            // 
            this.cbTier41.AutoSize = true;
            this.cbTier41.Location = new System.Drawing.Point(40, 59);
            this.cbTier41.Name = "cbTier41";
            this.cbTier41.Size = new System.Drawing.Size(15, 14);
            this.cbTier41.TabIndex = 29;
            this.cbTier41.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier83
            // 
            this.cbTier83.AutoSize = true;
            this.cbTier83.Checked = true;
            this.cbTier83.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier83.Location = new System.Drawing.Point(82, 139);
            this.cbTier83.Name = "cbTier83";
            this.cbTier83.Size = new System.Drawing.Size(15, 14);
            this.cbTier83.TabIndex = 43;
            this.cbTier83.UseVisualStyleBackColor = true;
            this.cbTier83.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier82
            // 
            this.cbTier82.AutoSize = true;
            this.cbTier82.Checked = true;
            this.cbTier82.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier82.Location = new System.Drawing.Point(61, 139);
            this.cbTier82.Name = "cbTier82";
            this.cbTier82.Size = new System.Drawing.Size(15, 14);
            this.cbTier82.TabIndex = 42;
            this.cbTier82.UseVisualStyleBackColor = true;
            this.cbTier82.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier73
            // 
            this.cbTier73.AutoSize = true;
            this.cbTier73.Checked = true;
            this.cbTier73.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier73.Location = new System.Drawing.Point(82, 119);
            this.cbTier73.Name = "cbTier73";
            this.cbTier73.Size = new System.Drawing.Size(15, 14);
            this.cbTier73.TabIndex = 40;
            this.cbTier73.UseVisualStyleBackColor = true;
            this.cbTier73.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier72
            // 
            this.cbTier72.AutoSize = true;
            this.cbTier72.Checked = true;
            this.cbTier72.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier72.Location = new System.Drawing.Point(61, 119);
            this.cbTier72.Name = "cbTier72";
            this.cbTier72.Size = new System.Drawing.Size(15, 14);
            this.cbTier72.TabIndex = 39;
            this.cbTier72.UseVisualStyleBackColor = true;
            this.cbTier72.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier63
            // 
            this.cbTier63.AutoSize = true;
            this.cbTier63.Checked = true;
            this.cbTier63.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier63.Location = new System.Drawing.Point(82, 99);
            this.cbTier63.Name = "cbTier63";
            this.cbTier63.Size = new System.Drawing.Size(15, 14);
            this.cbTier63.TabIndex = 37;
            this.cbTier63.UseVisualStyleBackColor = true;
            this.cbTier63.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier62
            // 
            this.cbTier62.AutoSize = true;
            this.cbTier62.Checked = true;
            this.cbTier62.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier62.Location = new System.Drawing.Point(61, 99);
            this.cbTier62.Name = "cbTier62";
            this.cbTier62.Size = new System.Drawing.Size(15, 14);
            this.cbTier62.TabIndex = 36;
            this.cbTier62.UseVisualStyleBackColor = true;
            this.cbTier62.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier53
            // 
            this.cbTier53.AutoSize = true;
            this.cbTier53.Location = new System.Drawing.Point(82, 79);
            this.cbTier53.Name = "cbTier53";
            this.cbTier53.Size = new System.Drawing.Size(15, 14);
            this.cbTier53.TabIndex = 34;
            this.cbTier53.UseVisualStyleBackColor = true;
            this.cbTier53.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier52
            // 
            this.cbTier52.AutoSize = true;
            this.cbTier52.Location = new System.Drawing.Point(61, 79);
            this.cbTier52.Name = "cbTier52";
            this.cbTier52.Size = new System.Drawing.Size(15, 14);
            this.cbTier52.TabIndex = 33;
            this.cbTier52.UseVisualStyleBackColor = true;
            this.cbTier52.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier81
            // 
            this.cbTier81.AutoSize = true;
            this.cbTier81.Checked = true;
            this.cbTier81.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier81.Location = new System.Drawing.Point(40, 139);
            this.cbTier81.Name = "cbTier81";
            this.cbTier81.Size = new System.Drawing.Size(15, 14);
            this.cbTier81.TabIndex = 41;
            this.cbTier81.UseVisualStyleBackColor = true;
            this.cbTier81.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier71
            // 
            this.cbTier71.AutoSize = true;
            this.cbTier71.Checked = true;
            this.cbTier71.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTier71.Location = new System.Drawing.Point(40, 119);
            this.cbTier71.Name = "cbTier71";
            this.cbTier71.Size = new System.Drawing.Size(15, 14);
            this.cbTier71.TabIndex = 38;
            this.cbTier71.UseVisualStyleBackColor = true;
            this.cbTier71.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier61
            // 
            this.cbTier61.AutoSize = true;
            this.cbTier61.Location = new System.Drawing.Point(40, 99);
            this.cbTier61.Name = "cbTier61";
            this.cbTier61.Size = new System.Drawing.Size(15, 14);
            this.cbTier61.TabIndex = 35;
            this.cbTier61.UseVisualStyleBackColor = true;
            this.cbTier61.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // cbTier51
            // 
            this.cbTier51.AutoSize = true;
            this.cbTier51.Location = new System.Drawing.Point(40, 79);
            this.cbTier51.Name = "cbTier51";
            this.cbTier51.Size = new System.Drawing.Size(15, 14);
            this.cbTier51.TabIndex = 32;
            this.cbTier51.UseVisualStyleBackColor = true;
            this.cbTier51.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbSkinnable);
            this.groupBox4.Controls.Add(this.cbHarvestable);
            this.groupBox4.Controls.Add(this.cbOtherMobs);
            this.groupBox4.Location = new System.Drawing.Point(129, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 68);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monsters";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cbOtherMobs
            // 
            this.cbOtherMobs.AutoSize = true;
            this.cbOtherMobs.Location = new System.Drawing.Point(84, 19);
            this.cbOtherMobs.Name = "cbOtherMobs";
            this.cbOtherMobs.Size = new System.Drawing.Size(52, 17);
            this.cbOtherMobs.TabIndex = 5;
            this.cbOtherMobs.Text = "Other";
            this.cbOtherMobs.UseVisualStyleBackColor = true;
            this.cbOtherMobs.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nRadarY);
            this.groupBox5.Controls.Add(this.nRadarX);
            this.groupBox5.Location = new System.Drawing.Point(129, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 57);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Radar Offset";
            // 
            // nRadarY
            // 
            this.nRadarY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nRadarY.Location = new System.Drawing.Point(85, 20);
            this.nRadarY.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nRadarY.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.nRadarY.Name = "nRadarY";
            this.nRadarY.Size = new System.Drawing.Size(60, 20);
            this.nRadarY.TabIndex = 1;
            this.nRadarY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nRadarY.ValueChanged += new System.EventHandler(this.MoveRadarValueChanged);
            // 
            // nRadarX
            // 
            this.nRadarX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nRadarX.Location = new System.Drawing.Point(19, 20);
            this.nRadarX.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nRadarX.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.nRadarX.Name = "nRadarX";
            this.nRadarX.Size = new System.Drawing.Size(60, 20);
            this.nRadarX.TabIndex = 0;
            this.nRadarX.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nRadarX.ValueChanged += new System.EventHandler(this.MoveRadarValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 260);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(306, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(306, 299);
            this.Name = "Form1";
            this.Text = "AO RADARO - V 1.12.365";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nRadarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadarX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox cbTreasures;
        public System.Windows.Forms.CheckBox cbHarvestable;
        public System.Windows.Forms.CheckBox cbRock;
        public System.Windows.Forms.CheckBox cbSkinnable;
        public System.Windows.Forms.CheckBox cbOre;
        public System.Windows.Forms.CheckBox cbWood;
        public System.Windows.Forms.CheckBox cbFiber;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.CheckBox cbSounds;
        public System.Windows.Forms.CheckBox cbDisplayPeople;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox cbTier1230;
        public System.Windows.Forms.CheckBox cbTier40;
        public System.Windows.Forms.CheckBox cbTier50;
        public System.Windows.Forms.CheckBox cbTier60;
        public System.Windows.Forms.CheckBox cbTier70;
        public System.Windows.Forms.CheckBox cbTier80;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox cbTier83;
        public System.Windows.Forms.CheckBox cbTier82;
        public System.Windows.Forms.CheckBox cbTier73;
        public System.Windows.Forms.CheckBox cbTier72;
        public System.Windows.Forms.CheckBox cbTier63;
        public System.Windows.Forms.CheckBox cbTier62;
        public System.Windows.Forms.CheckBox cbTier53;
        public System.Windows.Forms.CheckBox cbTier52;
        public System.Windows.Forms.CheckBox cbTier43;
        public System.Windows.Forms.CheckBox cbTier42;
        public System.Windows.Forms.CheckBox cbTier81;
        public System.Windows.Forms.CheckBox cbTier71;
        public System.Windows.Forms.CheckBox cbTier61;
        public System.Windows.Forms.CheckBox cbTier51;
        public System.Windows.Forms.CheckBox cbTier41;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.CheckBox cbOtherMobs;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.NumericUpDown nRadarY;
        public System.Windows.Forms.NumericUpDown nRadarX;
    }
}

