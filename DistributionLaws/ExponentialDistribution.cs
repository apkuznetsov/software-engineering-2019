using System;

namespace GasStationMs.App.DistributionLaws
{
    public class ExponentialDistribution : IDistributionLaw
    {
        private readonly double _lambda;

        public ExponentialDistribution(double lambda)
        {
            if (lambda <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this._lambda = lambda;
        }

        public double Lambda { get; }

        public double GetRandNumber()
        {
            Random random = new Random();
            double y = random.NextDouble();

            return -(1 / _lambda) * Math.Log(y);
        }
    }
}
