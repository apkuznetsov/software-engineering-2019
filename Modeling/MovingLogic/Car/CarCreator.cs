using System;

namespace GasStationMs.App.Modeling.MovingLogic.Car
{
    internal static class CarCreator
    {
        // test
        private static readonly Random Rnd = new Random();
        // /test
       
        internal static void SpawnCar( /*CarModel carModel*/)
        {
            var carView = ElementViewProducer.CreateCarView( /*carModel*/);
            var car = ElementPictureBoxProducer.CreateCarPictureBox(carView);

            // Some Distribution law here
            if (Rnd.NextDouble() >= 0.5)
            {
                car.IsGoesFilling = true;
            }
            //carView.IsGoesFilling = true;


            if (!car.IsGoesFilling)
            {
                car.AddDestinationPoint(DestinationPointsDefiner.LeavePointNoFilling);
            }
        }

        internal static void SpawnCollector()
        {
            var collectorView = ElementViewProducer.CreateCollectorView();
            ElementPictureBoxProducer.CreateCollectorPictureBox(collectorView);
        }
    }
}
