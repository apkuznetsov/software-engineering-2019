using System;

namespace GasStationMs.App.DistributionLaws
{
    public class ExponentialDistribution : IDistributionLaw
    {
        private readonly double lambda;

        public ExponentialDistribution(double lambda)
        {
            if (lambda <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.lambda = lambda;
        }

        public int Lambda { get; }

        public double GetRandNumber()
        {
            Random random = new Random();
            double y = random.NextDouble();

            return -(1 / lambda) * Math.Log(y);
        }
    }
}
