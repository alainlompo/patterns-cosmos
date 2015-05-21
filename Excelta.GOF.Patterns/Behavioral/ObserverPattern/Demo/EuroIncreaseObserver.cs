using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern.Demo
{
   public class EuroIncreaseObserver:IDeviseObserver
    {
       DeviseState _observerState;
       private EuroDevise _subject;


       public EuroIncreaseObserver(EuroDevise subject)
       {
           _subject = subject;
       }

       public void Update()
       {
           _observerState = _subject.GetState();
           if (_observerState == DeviseState.Increased)
               Console.WriteLine("We have a nice increase in the euro value...");



            
       }
    }
}
