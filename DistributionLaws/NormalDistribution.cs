using System;

namespace GasStationMs.App.DistributionLaws
{
    public class NormalDistribution : IDistributionLaw
    {
        public double GetRandNumber()
        {
            double x = 0;

            Random random = new Random();
            double y;

            for (int i = 0; i < 12; i++)
            {
                y = random.NextDouble();
                x += y - 6;
            }
   
            return x;
        }
    }
}
