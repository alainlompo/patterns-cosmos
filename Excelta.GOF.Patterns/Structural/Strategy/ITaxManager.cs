using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Strategy
{
    public interface ITaxManager
    {
         double ComputeTax(double volumeOfMoney);
    }
}
