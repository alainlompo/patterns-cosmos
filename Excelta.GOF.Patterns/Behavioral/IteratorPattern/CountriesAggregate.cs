using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.IteratorPattern
{
    public class CountriesAggregate:AbstractAggregate<Country>
    {
        private List<Country> _countries = new List<Country>();


        public override Iterator<Country> CreateIterator()
        {
            return new CountriesIterator(this);
        }
        public CountriesAggregate Append(Country c)
        {
            _countries.Add(c);
            return this;
        }
        public bool Remove(Country c)
        {
           return _countries.Remove(c);
        }
        public int Count()
        {
            return _countries.Count;
        }

        public Country Get(int index)
        {
            return _countries.ElementAt(index);

        }
    }
}
