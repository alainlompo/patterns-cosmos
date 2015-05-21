using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Excelta.GOF.Patterns.Structural.Bridge
{
    public class StandardWindowImplementor:WindowImplementor
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
        }
    }
}
