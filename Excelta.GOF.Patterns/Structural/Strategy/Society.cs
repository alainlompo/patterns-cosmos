using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Strategy
{
    public class Society
    {
        private double _capital;
        private ITaxManager _taxSystem;
        public void SetTaxSystem(ITaxManager _taxType)
        {
            _taxSystem = _taxType;
        }

        public double ComputeTTCFor(double volumeOfMoney)
        {
            double taxes = _taxSystem.ComputeTax(volumeOfMoney);
            return (volumeOfMoney + taxes);

        }
    }
}
