using System;

namespace GasStationMs.App.DistributionLaws
{
    public class UniformDistribution : IDistributionLaw
    {
        private readonly double _a;
        private readonly double _b;

        public UniformDistribution(double a, double b)
        {
            if (a > b)
            {
                throw new ArgumentOutOfRangeException();
            }

            this._a = a;
            this._b = b;
        }

        public double A { get; }
        public int B { get; }

        public double GetRandNumber()
        {
            Random random = new Random();

            return random.NextDouble() * (_b - _a) + _a;
        }
    }
}
