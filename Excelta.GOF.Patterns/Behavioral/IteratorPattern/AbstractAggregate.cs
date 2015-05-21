using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.IteratorPattern
{
    public abstract class AbstractAggregate<T>:IIterable
    {
        public abstract Iterator<T> CreateIterator();


    }
}
