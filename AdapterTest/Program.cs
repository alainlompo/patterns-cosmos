using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excelta.GOF.Patterns.Creational.AdapterPattern;

namespace AdapterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez les coordonnées du point complexe x + Entrée + y + Entrée");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            ComplexPoint cp = new ComplexPoint(x, y);
            ComplexPointAdapter cpA = new ComplexPointAdapter(cp);

            Console.WriteLine("Le point complexe " + cp + " correspond au point polaire " + cpA);
            Console.ReadKey();

        }
    }
}
