using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.IteratorPattern
{
    public class CountriesIterator:Iterator<Country>
        
    {
        private CountriesAggregate _aggregate;
        private int _currentIndex = 0;
        public CountriesIterator(CountriesAggregate aggregate)
        {
            _aggregate = aggregate;

        } 
        public override Country First()
        {
            return _aggregate.Get(0);
        }

        public override Country Next()
        {
            if (!IsDone())
                return _aggregate.Get(_currentIndex++);
            else return null;

        }

        public override bool IsDone()
        {
            return (_currentIndex > _aggregate.Count()-1);

        }

        public override Country CurrentItem()
        {
            if (!IsDone())
                return _aggregate.Get(_currentIndex);
            else return null;

        }
    }
}
