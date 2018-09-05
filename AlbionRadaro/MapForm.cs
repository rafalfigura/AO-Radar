using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionRadaro
{
    public partial class MapForm : PerPixelAlphaForm
    {
        public MapForm()
        {
            InitializeComponent();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.DoubleBuffered = true;
            
           // this.SetStyle( ControlStyles.AllPaintingInWmPaint, true);
           // this.SetStyle( ControlStyles.UserPaint, true);
           // this.SetStyle( ControlStyles.DoubleBuffer, true);
           // this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);


           // this.BackColor = Color.Magenta;
           // this.TransparencyKey = Color.Magenta;
        }

        private void MapForm_Paint(object sender, PaintEventArgs e)
        {
         //   e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
            
        }


       
    }
}
