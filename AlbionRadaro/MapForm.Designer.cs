namespace AlbionRadaro
{
    partial class MapForm
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
        {//
          //  this.overImage = new System.Windows.Forms.PictureBox();
            //((System.ComponentModel.ISupportInitialize)(this.overImage)).BeginInit();
            this.SuspendLayout();
            // 
            // overImage
            // 
           // this.overImage.BackColor = System.Drawing.Color.Transparent;
            //this.overImage.Location = new System.Drawing.Point(1, 2);
           // this.overImage.MaximumSize = new System.Drawing.Size(500, 500);
            //this.overImage.MinimumSize = new System.Drawing.Size(500, 500);
           // this.overImage.Name = "overImage";
           // this.overImage.Size = new System.Drawing.Size(500, 500);
           // this.overImage.TabIndex = 2;
          //  this.overImage.TabStop = false;

            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1113, 502);
            this.ControlBox = false;
            //this.Controls.Add(this.overImage);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MapForm";
            this.Load += new System.EventHandler(this.MapForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MapForm_Paint);
            //((System.ComponentModel.ISupportInitialize)(this.overImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      //  public System.Windows.Forms.PictureBox overImage;

    }
}