using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.AdapterPattern
{
    public class ComplexPointAdapter:PolarPoint
    {
        private ComplexPoint _complexPoint;
        public ComplexPointAdapter(ComplexPoint cp):base(0,0)
        {
            // z = x+iy = rexp(itheta) = r*(cos(theta) + isin(theta))
            // x = rcos(theta) y = rsin(theta)
            // y/x = tan(theta) ==> theta = arctg(y/x)
            // r = abs(y/sin(theta))

            _complexPoint = cp;
            _theta = Math.Atan(cp.Y / cp.X);
            _r = Math.Abs(cp.Y / Math.Sin(_theta));



        }
    }
}
