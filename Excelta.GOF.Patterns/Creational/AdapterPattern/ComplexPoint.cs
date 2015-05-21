using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.AdapterPattern
{
    public class ComplexPoint
    {
        private double _x, _y;
        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        public ComplexPoint(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return _x.ToString() + " i" + _y.ToString();

        }
    }
}
