using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Strategy
{
    public class ITSARLTax:ITaxManager
    {
        private readonly double _taxRate = 0.20d;


       

        public double ComputeTax(double volumeOfMoney)
        {
            return  _taxRate * volumeOfMoney;
            
        }

        
    }
}
