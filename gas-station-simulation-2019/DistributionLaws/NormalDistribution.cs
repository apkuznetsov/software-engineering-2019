using System;

namespace GasStationMs.App.DistributionLaws
{
    public class NormalDistribution : IDistributionLaw
    {
        private readonly double expectedValue;
        private readonly double variance;

        public NormalDistribution(double expectedValue, double variance)
        {
            this.expectedValue = expectedValue;
            this.variance = variance;
        }

        public double ExpectedValue { get; }

        public double Variance { get; }

        public double GetRandNumber()
        {
            Random random = new Random();

            double sum = 0;
            for (int i = 0; i <= 12; i++)
                sum += random.NextDouble();

            return Math.Abs(Math.Round((expectedValue + variance * (sum - 6)), 2));
        }
    }
}
