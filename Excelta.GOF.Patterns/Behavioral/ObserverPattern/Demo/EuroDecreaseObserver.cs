using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern.Demo
{
   public class EuroDecreaseObserver:IDeviseObserver
    {
       DeviseState _observerState;
       private EuroDevise _subject;


       public EuroDecreaseObserver(EuroDevise subject)
       {
           _subject = subject;
       }

       public void Update()
       {
           _observerState = _subject.GetState();
           if (_observerState == DeviseState.Decreased)
               Console.WriteLine("Wow we are in trouble there, it's a decrease...");



            
       }
    }
}
