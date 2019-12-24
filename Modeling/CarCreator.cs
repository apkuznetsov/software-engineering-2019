using System;
using static GasStationMs.App.Modeling.DestinationPointsDefiner;

namespace GasStationMs.App.Modeling
{
    internal static class CarCreator
    {
        // test
        private static readonly Random Rnd = new Random();
        // /test
       
        internal static void SpawnCar( /*CarModel carModel*/)
        {
            var carView = ElementViewProducer.CreateCarView( /*caeModel*/);

            // Some Distribution law here
            if (Rnd.NextDouble() >= 0.5)
            {
                carView.IsGoesFilling = true;
            }
            //carView.IsGoesFilling = true;


            if (!carView.IsGoesFilling)
            {
                carView.AddDestinationPoint(LeavePointNoFilling);
            }

            ElementPictureBoxProducer.CreateCarPictureBox(carView);
        }
    }
}
