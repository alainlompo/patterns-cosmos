using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern
{
    public class CalcViewObserver:Observer
    {
        private static int _idCounter = 0;
        private CalcViewSubject _subject;
        private CalcViewTypes _observerState;

        public CalcViewObserver()
        {
            _idCounter++;
        }
        public CalcViewObserver(CalcViewSubject subject)
            : this()
        {
            _subject = subject;

        }
        public override int GetID()
        {
            return _idCounter;
        }
        public override void Update()
        {
            _observerState = _subject.GetState();
        }


    }
}
