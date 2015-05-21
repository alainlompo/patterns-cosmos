using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.ObserverPattern
{
   public class ObserverComparer:IEqualityComparer<Observer>
    {

        public bool Equals(Observer x, Observer y)
        {
            if ((x == null) || (y == null))
                return false;
            if (x.GetID() == y.GetID())
                return true;
            else return false;
        }

        public int GetHashCode(Observer obj)
        {
           return (obj.GetID() ^ System.DateTime.Now.Minute^System.DateTime.Now.Month^System.DateTime.Now.Second^System.DateTime.Now.Millisecond);


        }
    }
}
