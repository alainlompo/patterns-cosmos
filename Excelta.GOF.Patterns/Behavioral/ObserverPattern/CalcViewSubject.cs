using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern
{
    public class CalcViewSubject:Subject
    {
        ObserverComparer comparer = new ObserverComparer();
        private CalcViewTypes _subjectState = CalcViewTypes.Standard;

        public CalcViewTypes GetState()
        {
            return _subjectState;
        }

        public void SetState(CalcViewTypes state)
        {
            _subjectState = state;
        }

        
        public  override void Attach(Observer obs)
        {
            if (_observers == null)
            {
                _observers = new List<Observer>();
            }
            _observers.Add(obs);

        }
         public override void Detach(Observer obs)
         {
             try
             {
                 _observers.Remove(obs);
             }

             catch { }
         }

         public override void Notify()
         {
             foreach (Observer obs in _observers)
                 obs.Update();

         }
    }
}
