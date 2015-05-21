using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.AbstractFactoryPattern
{
    public class ShadowStyleInterfaceFactory:ApplicationInterfaceFactory
    {

        public override void CreateMenu()
        {
            throw new NotImplementedException();
        }

        public override void CreateToolBar()
        {
            throw new NotImplementedException();
        }

        public override void CreateStatusBar()
        {
            throw new NotImplementedException();
        }

        public override void ConfigureInnerSpace()
        {
            throw new NotImplementedException();
        }

        public override void DisplayInterface()
        {
            throw new NotImplementedException();
        }
    }
}
