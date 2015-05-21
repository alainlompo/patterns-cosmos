using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Excelta.GOF.Patterns.Creational.AbstractFactoryPattern
{
    public abstract class ApplicationInterfaceFactory
    {
        protected Form _mainForm;
        protected ToolBar _toolBar;
        protected MainMenu _menu;
        protected Panel _innerSpacePanel;

        public abstract void CreateMenu();
        public abstract void CreateToolBar();
        public abstract void CreateStatusBar();
        public abstract void ConfigureInnerSpace();
        public abstract void DisplayInterface();



    }
}
