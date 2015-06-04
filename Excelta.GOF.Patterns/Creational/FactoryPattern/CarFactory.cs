using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.FactoryPattern
{
    public class CarFactory
    {
        public Car GetCar(string style)
        {
            if (style.Trim().ToUpper().Contains("PURE HORSE")) 
            {
                return new FiatGT1();
            }

            if (style.Trim().ToUpper().Contains("RACE CAR"))
            {
                return new PoloRWRC();
            }

            return new SnowSpeeder();
        }
    }
}
