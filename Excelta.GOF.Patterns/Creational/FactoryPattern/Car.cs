using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.FactoryPattern
{
    public class Car: IAccelerable, IStartable
    {
        public CarType UsageType { get; set; }
        public long MaximumSpeed { get; set; }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        
        
        public Car(CarType usageType, long maximumSpeed, string name,string manufacturer)
        {

            UsageType = usageType;
            MaximumSpeed = maximumSpeed;
            Name = name;
            Manufacturer = manufacturer;

        }
       

        public void accelerate(int speed)
        {
            throw new NotImplementedException();
        }

        public void start()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }


    }
}
