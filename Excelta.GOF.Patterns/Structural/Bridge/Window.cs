using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Bridge
{
    public abstract class Window
    {
        protected WindowImplementor _implementor;
        public abstract void DrawDemoRectangle();

    }
}
