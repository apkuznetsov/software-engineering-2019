using System;
using GasStationMs.App.DistributionLaws;

namespace GasStationMs.App.Models
{
    public class TrafficFlow
    {
        #region статика
        public static readonly double MinParamForDeterminedFlow = 2.0;
        public static readonly double MaxParamForDeterminedFlow = 10.0;

        public static readonly double MinAaParamForUniformFlow = 2.0;
        public static readonly double MaxAaParamForUniformFlow = 10.0;
        public static readonly double MinBbParamForUniformFlow = 2.0;
        public static readonly double MaxBbParamForUniformFlow = 10.0;

        public static readonly double MinVarianceForNormalFlow = 0.0;
        public static readonly double MaxVarianceForNormalFlow = 2.0;
        public static readonly double MinExpectedValueForNormalFlow = 0.0;
        public static readonly double MaxExpectedValueForNormalFlow = 5.0;

        public static readonly double MinLambdaForExponentialFlow = 0.1;
        public static readonly double MaxLambdaForExponentialFlow = 5.0;

        public static readonly double MinProbabilityOfStoppingAtGasStation = 0.1;
        public static readonly double MaxProbabilityOfStoppingAtGasStation = 0.99;
        #endregion /статика

        private readonly IDistributionLaw timeBetweenCarsGenerator;
        private readonly double probabilityOfStoppingAtGasStation;

        public TrafficFlow(IDistributionLaw timeBetweenCarsGenerator, double probabilityOfStoppingAtGasStation)
        {
            this.timeBetweenCarsGenerator = timeBetweenCarsGenerator ?? throw new NullReferenceException();

            if (probabilityOfStoppingAtGasStation < 0 || probabilityOfStoppingAtGasStation > 1)
                throw new ArgumentOutOfRangeException();

            this.probabilityOfStoppingAtGasStation = probabilityOfStoppingAtGasStation;
        }

        public double TimeBetweenCars
        {
            get
            {
                return timeBetweenCarsGenerator.GetRandNumber();
            }
        }

        public double ProbabilityOfStoppingAtGasStation
        {
            get
            {
                return probabilityOfStoppingAtGasStation;
            }
        }
    }
}
