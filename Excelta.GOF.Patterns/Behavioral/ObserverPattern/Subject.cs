using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern
{
    public abstract class Subject
    {
        protected List<Observer> _observers;
        public abstract void Attach (Observer obs);
        public abstract void Detach(Observer obs);
        public abstract void Notify();

    }
}
