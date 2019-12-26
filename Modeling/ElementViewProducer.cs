using System;
using GasStationMs.App.DB.Models;
using GasStationMs.App.Modeling.Models.Views;

namespace GasStationMs.App.Modeling
{
    internal static class ElementViewProducer
    {
        internal static CashCounterView CreateCashCounterView(string name, int maxCashVolume)
        {
            return new CashCounterView(name, maxCashVolume);
        }

        internal static CarView CreateCarView( /*CarModel*/)
        {
            //var id = _timerTicksCount;
            var id = 0;
            var name = "mycar";
            var tankVolume = 80;
            var fuelRemained = 20;
            //FuelModel fuel = new FuelModel(1, "АИ-92", 42.9);
            FuelModel fuel = ModelSettings.Fuels[new Random().Next(0, ModelSettings.Fuels.Count)];
            var isTruck = false;

            return new CarView(id, name, tankVolume, fuelRemained,
                fuel, isTruck);
        }

        internal static CollectorView CreateCollectorView()
        {
            var speedOfCashCollectingPerSecond = 10000;
            return new CollectorView(speedOfCashCollectingPerSecond);
        }

        public static RefuellerView CreateRefuellerView(FuelTankView fuelTank)
        {
            var speedOfRefillingPerSecond = 5000;
            return new RefuellerView(speedOfRefillingPerSecond)
            {
                FuelTank = fuelTank
            };
        }

        internal static FuelDispenserView CreateFuelDispenserView(string name, int speedOfFilling)
        {
            return new FuelDispenserView(name, speedOfFilling);
        }

        internal static FuelTankView CreateFuelTankView(string name, int volume, double currentFullness, FuelModel fuel)
        {
            return new FuelTankView(name, volume, currentFullness, fuel);
        }
    }
}
