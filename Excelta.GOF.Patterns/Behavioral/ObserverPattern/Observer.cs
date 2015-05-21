using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern
{
    public abstract class Observer
    {
        public abstract int GetID();
        public abstract void Update();
       
    }
}
