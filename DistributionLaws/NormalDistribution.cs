using System;

namespace GasStationMs.App.DistributionLaws
{
    public class NormalDistribution : IDistributionLaw
    {
        private readonly double mu;
        private readonly double sigma;

       public NormalDistribution(double mu, double sigma)
        {
            this.mu = mu;
            this.sigma = sigma;
        }


        public double GetRandNumber()
        {            
                double Summ = 0, RandValue = 0;
                Random ran = new Random();
                Summ = 0;
                for (int i = 0; i <= 12; i++)
                {
                    double R = ran.NextDouble();
                    Summ += R;
                }
                RandValue = Math.Abs(Math.Round((mu + sigma * (Summ - 6)), 2));
                return RandValue;
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
