using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationMs.App.DistributionLaws
{
    public class DeterminedDistribution : IDistributionLaw
    {
        private double time;

        public DeterminedDistribution(double time)
        {
            this.time = time;
        }

        public double GetRandNumber()
        {            
            return this.time;
        }
    }
}
