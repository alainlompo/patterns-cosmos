using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern.Demo
{
    public abstract class BaseDeviseSubject
    {

        private List<IDeviseObserver> _observers = new List<IDeviseObserver>();

        protected List<IDeviseObserver> GetObservers()
        {
            return _observers;
        }

        
        public abstract void Attach(IDeviseObserver observer);
        public abstract void Detach(IDeviseObserver observer);
        public void Notify()
        {
            foreach (IDeviseObserver obs in _observers)
            {
                obs.Update();
            }
        }

    }
}
