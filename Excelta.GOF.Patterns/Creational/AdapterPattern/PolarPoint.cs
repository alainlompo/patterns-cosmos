using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.AdapterPattern
{
    public class PolarPoint
    {
        protected double _r, _theta;

        public PolarPoint(double r, double theta)
        {
            _r = r;
            _theta = theta;
        }

        public override string ToString()
        {
            return "(" + _r.ToString() + "," + _theta.ToString() + ")";

        }
    }
}
