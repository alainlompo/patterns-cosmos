using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Bridge
{
    public class StandardWindow: Window
    {
        public StandardWindow(WindowImplementor impl)
        {
            _implementor = impl;
        }
        public override void DrawDemoRectangle()
        {

            _implementor.Initialize();
            _implementor.DrawRect(120, 120, 150, 75);
            _implementor.Paint();

            
            
        }
    }
}
