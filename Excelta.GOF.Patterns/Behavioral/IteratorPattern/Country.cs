using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.IteratorPattern
{
    public class Country
    {
        private string _name;
        private CountryType _type = CountryType.Republic;
        private int _size;
        private int _population;
        public Country(string n, CountryType t, int s, int p)
        {
            _name = n;
            _type = t;
            _size = s;
            _population = p;

        }

        public Country(string name):this(name, CountryType.Republic,0,0)
        {

        }

        public Country(string name, CountryType type)
            : this(name, type, 0, 0)
        {
        }
        public Country(string name, CountryType type, int size)
            : this(name, type, size,0)
        {
        }

        public override string ToString()
        {
            return _name + "(" + _type.ToString() + ")";
        }


    }
}
