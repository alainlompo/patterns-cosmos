using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern.Demo
{
    public class EuroDevise:BaseDeviseSubject
    {
        private DeviseState _state;
        public DeviseState GetState()
        {
            return _state;
        }

        public void SetState(DeviseState state)
        {
            _state = state;
            Notify();

        }
        public override void Attach(IDeviseObserver observer)
        {
            List<IDeviseObserver> myObservers = GetObservers();
            myObservers.Add(observer);

        }

        public override void Detach(IDeviseObserver observer)
        {
            List<IDeviseObserver> myObservers = GetObservers();
            myObservers.Remove(observer);

        }
    }
}
