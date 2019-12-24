using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationMs.App.DistributionLaws
{
    public class DeterminedDistribution : IDistributionLaw
    {
        private readonly double _constNumber;

        public DeterminedDistribution(double constNumber)
        {
            this._constNumber = constNumber;
        }

        public double GetRandNumber()
        {            
            return this._constNumber;
        }
    }
}
