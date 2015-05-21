using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.IteratorPattern
{
    public abstract class Iterator<T>
    {
        public abstract T First();
        public abstract T Next();
        public abstract Boolean IsDone();
        public abstract T CurrentItem();
    }
}
