using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.FactoryPattern
{
    public class PoloRWRC:Car
    {
        public PoloRWRC()
            : base(CarType.RACE_CAR, 345, "VW Polo R WRC", "Volkswagen")
        {
        }
    }
}
