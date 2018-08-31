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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onlyRares = new System.Windows.Forms.CheckBox();
            this.tier8 = new System.Windows.Forms.CheckBox();
            this.tier7 = new System.Windows.Forms.CheckBox();
            this.tier6 = new System.Windows.Forms.CheckBox();
            this.tier5 = new System.Windows.Forms.CheckBox();
            this.tier4 = new System.Windows.Forms.CheckBox();
            this.tier3 = new System.Windows.Forms.CheckBox();
            this.tier2 = new System.Windows.Forms.CheckBox();
            this.tier1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTreasures = new System.Windows.Forms.CheckBox();
            this.cbMob = new System.Windows.Forms.CheckBox();
            this.cbElemental = new System.Windows.Forms.CheckBox();
            this.cbRock = new System.Windows.Forms.CheckBox();
            this.cbAnimal = new System.Windows.Forms.CheckBox();
            this.cbOre = new System.Windows.Forms.CheckBox();
            this.cbWood = new System.Windows.Forms.CheckBox();
            this.cbFiber = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSounds = new System.Windows.Forms.CheckBox();
            this.cbDisplayPeople = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onlyRares);
            this.groupBox1.Controls.Add(this.tier8);
            this.groupBox1.Controls.Add(this.tier7);
            this.groupBox1.Controls.Add(this.tier6);
            this.groupBox1.Controls.Add(this.tier5);
            this.groupBox1.Controls.Add(this.tier4);
            this.groupBox1.Controls.Add(this.tier3);
            this.groupBox1.Controls.Add(this.tier2);
            this.groupBox1.Controls.Add(this.tier1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiers";
            // 
            // onlyRares
            // 
            this.onlyRares.AutoSize = true;
            this.onlyRares.Location = new System.Drawing.Point(6, 203);
            this.onlyRares.Name = "onlyRares";
            this.onlyRares.Size = new System.Drawing.Size(73, 17);
            this.onlyRares.TabIndex = 8;
            this.onlyRares.Text = "Only Rare";
            this.onlyRares.UseVisualStyleBackColor = true;
            this.onlyRares.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier8
            // 
            this.tier8.AutoSize = true;
            this.tier8.Checked = true;
            this.tier8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tier8.Location = new System.Drawing.Point(6, 180);
            this.tier8.Name = "tier8";
            this.tier8.Size = new System.Drawing.Size(32, 17);
            this.tier8.TabIndex = 7;
            this.tier8.Text = "8";
            this.tier8.UseVisualStyleBackColor = true;
            this.tier8.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier7
            // 
            this.tier7.AutoSize = true;
            this.tier7.Checked = true;
            this.tier7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tier7.Location = new System.Drawing.Point(6, 157);
            this.tier7.Name = "tier7";
            this.tier7.Size = new System.Drawing.Size(32, 17);
            this.tier7.TabIndex = 6;
            this.tier7.Text = "7";
            this.tier7.UseVisualStyleBackColor = true;
            this.tier7.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier6
            // 
            this.tier6.AutoSize = true;
            this.tier6.Checked = true;
            this.tier6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tier6.Location = new System.Drawing.Point(6, 134);
            this.tier6.Name = "tier6";
            this.tier6.Size = new System.Drawing.Size(32, 17);
            this.tier6.TabIndex = 5;
            this.tier6.Text = "6";
            this.tier6.UseVisualStyleBackColor = true;
            this.tier6.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier5
            // 
            this.tier5.AutoSize = true;
            this.tier5.Checked = true;
            this.tier5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tier5.Location = new System.Drawing.Point(6, 111);
            this.tier5.Name = "tier5";
            this.tier5.Size = new System.Drawing.Size(32, 17);
            this.tier5.TabIndex = 4;
            this.tier5.Text = "5";
            this.tier5.UseVisualStyleBackColor = true;
            this.tier5.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier4
            // 
            this.tier4.AutoSize = true;
            this.tier4.Location = new System.Drawing.Point(6, 88);
            this.tier4.Name = "tier4";
            this.tier4.Size = new System.Drawing.Size(32, 17);
            this.tier4.TabIndex = 3;
            this.tier4.Text = "4";
            this.tier4.UseVisualStyleBackColor = true;
            this.tier4.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier3
            // 
            this.tier3.AutoSize = true;
            this.tier3.Location = new System.Drawing.Point(6, 65);
            this.tier3.Name = "tier3";
            this.tier3.Size = new System.Drawing.Size(32, 17);
            this.tier3.TabIndex = 2;
            this.tier3.Text = "3";
            this.tier3.UseVisualStyleBackColor = true;
            this.tier3.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier2
            // 
            this.tier2.AutoSize = true;
            this.tier2.Location = new System.Drawing.Point(6, 42);
            this.tier2.Name = "tier2";
            this.tier2.Size = new System.Drawing.Size(32, 17);
            this.tier2.TabIndex = 1;
            this.tier2.Text = "2";
            this.tier2.UseVisualStyleBackColor = true;
            this.tier2.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // tier1
            // 
            this.tier1.AutoSize = true;
            this.tier1.Location = new System.Drawing.Point(6, 19);
            this.tier1.Name = "tier1";
            this.tier1.Size = new System.Drawing.Size(32, 17);
            this.tier1.TabIndex = 0;
            this.tier1.Text = "1";
            this.tier1.UseVisualStyleBackColor = true;
            this.tier1.CheckedChanged += new System.EventHandler(this.tierCheckChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTreasures);
            this.groupBox2.Controls.Add(this.cbMob);
            this.groupBox2.Controls.Add(this.cbElemental);
            this.groupBox2.Controls.Add(this.cbRock);
            this.groupBox2.Controls.Add(this.cbAnimal);
            this.groupBox2.Controls.Add(this.cbOre);
            this.groupBox2.Controls.Add(this.cbWood);
            this.groupBox2.Controls.Add(this.cbFiber);
            this.groupBox2.Location = new System.Drawing.Point(114, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 223);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ressources";
            // 
            // cbTreasures
            // 
            this.cbTreasures.AutoSize = true;
            this.cbTreasures.Checked = true;
            this.cbTreasures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTreasures.Location = new System.Drawing.Point(6, 180);
            this.cbTreasures.Name = "cbTreasures";
            this.cbTreasures.Size = new System.Drawing.Size(73, 17);
            this.cbTreasures.TabIndex = 7;
            this.cbTreasures.Text = "Treasures";
            this.cbTreasures.UseVisualStyleBackColor = true;
            this.cbTreasures.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbMob
            // 
            this.cbMob.AutoSize = true;
            this.cbMob.Enabled = false;
            this.cbMob.Location = new System.Drawing.Point(6, 157);
            this.cbMob.Name = "cbMob";
            this.cbMob.Size = new System.Drawing.Size(47, 17);
            this.cbMob.TabIndex = 6;
            this.cbMob.Text = "Mob";
            this.cbMob.UseVisualStyleBackColor = true;
            this.cbMob.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbElemental
            // 
            this.cbElemental.AutoSize = true;
            this.cbElemental.Enabled = false;
            this.cbElemental.Location = new System.Drawing.Point(6, 134);
            this.cbElemental.Name = "cbElemental";
            this.cbElemental.Size = new System.Drawing.Size(72, 17);
            this.cbElemental.TabIndex = 5;
            this.cbElemental.Text = "Elemental";
            this.cbElemental.UseVisualStyleBackColor = true;
            this.cbElemental.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbRock
            // 
            this.cbRock.AutoSize = true;
            this.cbRock.Checked = true;
            this.cbRock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRock.Location = new System.Drawing.Point(6, 111);
            this.cbRock.Name = "cbRock";
            this.cbRock.Size = new System.Drawing.Size(52, 17);
            this.cbRock.TabIndex = 4;
            this.cbRock.Text = "Rock";
            this.cbRock.UseVisualStyleBackColor = true;
            this.cbRock.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbAnimal
            // 
            this.cbAnimal.AutoSize = true;
            this.cbAnimal.Enabled = false;
            this.cbAnimal.Location = new System.Drawing.Point(6, 88);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(57, 17);
            this.cbAnimal.TabIndex = 3;
            this.cbAnimal.Text = "Animal";
            this.cbAnimal.UseVisualStyleBackColor = true;
            this.cbAnimal.CheckedChanged += new System.EventHandler(this.harvestableCheckChange);
            // 
            // cbOre
            // 
            this.cbOre.AutoSize = true;
            this.cbOre.Checked = true;
            this.cbOre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOre.Location = new System.Drawing.Point(6, 65);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSounds);
            this.groupBox3.Controls.Add(this.cbDisplayPeople);
            this.groupBox3.Location = new System.Drawing.Point(14, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 72);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "People Radar";
            // 
            // cbSounds
            // 
            this.cbSounds.AutoSize = true;
            this.cbSounds.Enabled = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Make map better";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Hide map background";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 297);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(429, 360);
            this.MinimumSize = new System.Drawing.Size(429, 360);
            this.Name = "Form1";
            this.Text = "AO RADARO - V 1.12.365";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox onlyRares;
        private System.Windows.Forms.CheckBox tier8;
        private System.Windows.Forms.CheckBox tier7;
        private System.Windows.Forms.CheckBox tier6;
        private System.Windows.Forms.CheckBox tier5;
        private System.Windows.Forms.CheckBox tier4;
        private System.Windows.Forms.CheckBox tier3;
        private System.Windows.Forms.CheckBox tier2;
        private System.Windows.Forms.CheckBox tier1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTreasures;
        private System.Windows.Forms.CheckBox cbMob;
        private System.Windows.Forms.CheckBox cbElemental;
        private System.Windows.Forms.CheckBox cbRock;
        private System.Windows.Forms.CheckBox cbAnimal;
        private System.Windows.Forms.CheckBox cbOre;
        private System.Windows.Forms.CheckBox cbWood;
        private System.Windows.Forms.CheckBox cbFiber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbSounds;
        private System.Windows.Forms.CheckBox cbDisplayPeople;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

