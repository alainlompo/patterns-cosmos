using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Excelta.GOF.Patterns.Structural.Bridge
{
    public class Window3DImplementor:WindowImplementor
    {
        public override void Paint()
        {
            if (_winForm == null)
                return;
            _winForm.Show();
        }

        public override void DrawRect(int x, int y, int width, int height)
        {
            Graphics g = _winForm.CreateGraphics();
            g.DrawRectangle(new Pen(Brushes.Aquamarine), new Rectangle(x, y, width, height));
            g.FillRectangle(Brushes.Black, new Rectangle(x+5, y+height, width, 10));
            g.FillRectangle(Brushes.Black, new Rectangle(x + width, y +5 , 10, height));





            
        }
    }
}
