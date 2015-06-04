using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.FactoryPattern
{
    public interface IStartable
    {
         void start();
         void stop();
    }
}
