using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excelta.GOF.Patterns.Behavioral.IteratorPattern;

namespace CountriesTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CountriesAggregate cSystem = new CountriesAggregate();
            cSystem.Append(new Country("Niger", CountryType.Republic))
                .Append(new Country("Benin", CountryType.Republic))
                .Append(new Country("Gabon", CountryType.Republic))
                .Append(new Country("Mali", CountryType.Republic))
                .Append(new Country("Maroc", CountryType.Monarchy));


            Iterator<Country> iterator = cSystem.CreateIterator();
            while (!iterator.IsDone())
                Console.WriteLine(iterator.Next());
            Console.ReadKey();




        }
    }
}
