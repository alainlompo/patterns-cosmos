using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.FactoryPattern
{
    public class FiatGT1: Car
    {
        public FiatGT1()
            : base(CarType.RACE_CAR, 350, "FiatGT1", "FIAT")
        {

        }
    }
}
