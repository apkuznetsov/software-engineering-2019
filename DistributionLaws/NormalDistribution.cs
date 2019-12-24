using System;

namespace GasStationMs.App.DistributionLaws
{
    public class NormalDistribution : IDistributionLaw
    {
        private readonly double _mu;
        private readonly double _sigma;

       public NormalDistribution(double mu, double sigma)
        {
            this._mu = mu;
            this._sigma = sigma;
        }


        public double GetRandNumber()
        {            
                double summ = 0, randValue = 0;
                Random ran = new Random();
                summ = 0;
                for (int i = 0; i <= 12; i++)
                {
                    double r = ran.NextDouble();
                    summ += r;
                }
                randValue = Math.Abs(Math.Round((_mu + _sigma * (summ - 6)), 2));
                return randValue;
            //double x = 0;

            //Random random = new Random();
            //double y;

            //for (int i = 0; i < 12; i++)
            //{
            //    y = random.NextDouble();
            //    x += y - 6;
            //}

            //return x;

        }
    }
}
