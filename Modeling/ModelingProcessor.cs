using System.Collections.Generic;
using System.Windows.Forms;
using GasStationMs.App.Modeling.Models;

namespace GasStationMs.App.Modeling
{
    internal class ModelingProcessor
    {
        private readonly PictureBox _cashCounter;
        internal List<PictureBox> FuelDispensersList { get; }
        internal List<PictureBox> FuelTanksList { get; }

        internal ModelingProcessor(MappedTopology mappedTopology)
        {
            _cashCounter = mappedTopology.CashCounter;
            FuelDispensersList = mappedTopology.FuelDispensersList;
            FuelTanksList = mappedTopology.FuelTanksList;
        }

        internal void StartFilling(PictureBox car, PictureBox fuelDispenser)
        {
            var carView = (CarView)car.Tag;
            var fuelDispenserView = (FuelDispenserView)fuelDispenser.Tag;

            fuelDispenserView.ChoseFuelTank(FuelTanksList, carView.Fuel);

            carView.PayForOrderedFuel((CashCounterView)_cashCounter.Tag);

            carView.IsFilling = true;
            fuelDispenserView.IsBusy = true;
        }

        internal void FillCar(CarView car, FuelDispenserView fuelDispenser)
        {
            car.FuelRemained += fuelDispenser.GetFuelFromTank();

            if (fuelDispenser.ChosenFuelTank.IsEmpty)
            {
                // CallRefiller()
            }

            if (((CashCounterView)_cashCounter.Tag).IsFull)
            {
                // CallCollector()
            }

            // test

            if (car.FuelRemained >= car.DesiredFilling)
            {
                StopFilling(car, fuelDispenser);
            }
        }

        internal void StopFilling(CarView car, FuelDispenserView fuelDispenser)
        {
            if (car.FuelRemained > car.TankVolume)
            {
                car.FuelRemained = car.TankVolume;

                var fuelSurplus = car.FuelRemained - car.TankVolume;
                fuelDispenser.ReturnFuelToTank(fuelSurplus);
            }

            car.IsFilling = false;
            car.IsFilled = true;
            fuelDispenser.CarsInQueue--;
            fuelDispenser.IsBusy = false;
        }
    }
}
