using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Bridge
{
    public abstract class WindowImplementor
    {
        protected System.Windows.Forms.Form _winForm;
        public abstract void Paint();
        public abstract void DrawRect(int x, int y, int width, int height);
        public void Initialize()
        {
            _winForm = new System.Windows.Forms.Form();
            _winForm.Size = new System.Drawing.Size(800, 600);

        }

    }
}
