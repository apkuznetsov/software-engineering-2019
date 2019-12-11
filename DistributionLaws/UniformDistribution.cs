using System;

namespace GasStationMs.App.DistributionLaws
{
    public class UniformDistribution : IDistributionLaw
    {
        private readonly int minValue;
        private readonly int maxValue;

        public UniformDistribution(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public int MinValue { get; }
        public int MaxValue { get; }

        public int GetRandInt()
        {
            Random random = new Random();

            return random.Next(minValue, maxValue + 1);
        }
    }
}
