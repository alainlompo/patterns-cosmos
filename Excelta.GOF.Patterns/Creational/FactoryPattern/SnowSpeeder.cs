using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.FactoryPattern
{
    public class SnowSpeeder:Car
    {
        public SnowSpeeder()
            : base(CarType.HOVERCRAFT, 850, "Snow Speeder", "George Lucas")
        {
        }
    }
}
