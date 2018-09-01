using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionRadaro
{
    public class MouseClickMessageFilter : IMessageFilter
    {
        private const int LButtonDown = 0x201;
        private const int LButtonUp = 0x202;
        private const int LButtonDoubleClick = 0x203;
        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case LButtonDown:
                case LButtonUp:
                case LButtonDoubleClick:
                    return true;
            }
            return false;
        }
    } 
}
