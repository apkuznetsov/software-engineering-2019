using System;
using static GasStationMs.App.Modeling.DestinationPointsDefiner;
using static GasStationMs.App.Modeling.ElementPictureBoxProducer;
using static GasStationMs.App.Modeling.ElementViewProducer;

namespace GasStationMs.App.Modeling
{
    internal static class CarCreator
    {
        // test
        private static readonly Random Rnd = new Random();
        // /test
       
        internal static void SpawnCar( /*CarModel carModel*/)
        {
            var carView = CreateCarView( /*carModel*/);
            var car = CreateCarPictureBox(carView);

            // Some Distribution law here
            if (Rnd.NextDouble() >= 0.5)
            {
                car.IsGoesFilling = true;
            }
            //carView.IsGoesFilling = true;


            if (!car.IsGoesFilling)
            {
                car.AddDestinationPoint(LeavePointNoFilling);
            }
        }

        internal static void SpawnCollector()
        {
            var collectorView = CreateCollectorView();
            CreateCollectorPictureBox(collectorView);
        }
    }
}
