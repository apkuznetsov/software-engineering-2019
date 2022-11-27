namespace GasStationMs.App.DistributionLaws
{
    public class DeterminedDistribution : IDistributionLaw
    {
        private readonly double constNumber;

        public DeterminedDistribution(double constNumber)
        {
            this.constNumber = constNumber;
        }

        public double ConstNumber { get; }

        public double GetRandNumber()
        {
            return constNumber;
        }
    }
}
