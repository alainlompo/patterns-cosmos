using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excelta.GOF.Patterns.Behavioral.ObserverPattern.Demo;

namespace EuroTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            EuroDevise euro = new EuroDevise();
            euro.Attach(new EuroDecreaseObserver(euro));
            euro.Attach(new EuroIncreaseObserver(euro));
            euro.SetState(DeviseState.Increased);
            euro.SetState(DeviseState.Decreased);
            Console.ReadKey();




        }
    }
}
