using System;

namespace GasStationMs.App.DistributionLaws
{
    public class UniformDistribution : IDistributionLaw
    {
        private readonly double a;
        private readonly double b;

        public UniformDistribution(double a, double b)
        {
            if (a > b)
                throw new ArgumentOutOfRangeException("ОШИБКА: левая граница больше правой");

            this.a = a;
            this.b = b;
        }

        public double A { get; }
        public int B { get; }

        public double GetRandNumber()
        {
            Random random = new Random();

            return random.NextDouble() * (b - a) + a;
        }
    }
}
