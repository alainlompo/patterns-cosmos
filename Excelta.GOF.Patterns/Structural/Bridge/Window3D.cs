using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Bridge
{
    public class Window3D:Window
    {
        public Window3D(WindowImplementor _impl)
        {
            _implementor = _impl;
        }
        public override void DrawDemoRectangle()
        {
            _implementor.Initialize();
            _implementor.DrawRect(310, 100, 125, 85);
            _implementor.Paint();
        }
    }
}
