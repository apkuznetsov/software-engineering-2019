using System.Collections.Generic;
using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;

namespace GasStationMs.App.Modeling
{
    internal static class ModelingProcessor
    {
        private static  PictureBox _cashCounter;
        internal static List<PictureBox> FuelDispensersList { get; private set; }
        internal static List<PictureBox> FuelTanksList { get; private set; }

        internal static void SetUpModelingProcessor(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            _cashCounter = mappedTopology.CashCounter;
            FuelDispensersList = mappedTopology.FuelDispensersList;
            FuelTanksList = mappedTopology.FuelTanksList;

            CarMover.SetUpCarMover(modelingForm);
            CarRouter.SetUpCarRouter(modelingForm);
        }

        internal static void StartFilling(PictureBox car, PictureBox fuelDispenser)
        {
            var carView = (CarView)car.Tag;
            var fuelDispenserView = (FuelDispenserView)fuelDispenser.Tag;

            fuelDispenserView.ChoseFuelTank(FuelTanksList, carView.Fuel);

            carView.PayForOrderedFuel((CashCounterView)_cashCounter.Tag);

            carView.IsFilling = true;
            fuelDispenserView.IsBusy = true;
        }

        internal static void FillCar(CarView car, FuelDispenserView fuelDispenser)
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

        internal static void StopFilling(CarView car, FuelDispenserView fuelDispenser)
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
