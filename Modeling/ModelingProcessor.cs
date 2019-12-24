using System.Collections.Generic;
using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;
using GasStationMs.App.Modeling.Models.PictureBoxes;

namespace GasStationMs.App.Modeling
{
    internal static class ModelingProcessor
    {
        internal static PictureBox CashCounter { get; private set; }
        internal static List<PictureBox> FuelDispensersList { get; private set; }
        internal static List<PictureBox> FuelTanksList { get; private set; }

        private static bool _isCollectingMoney;

        internal static void SetUpModelingProcessor(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            CashCounter = mappedTopology.CashCounter;
            FuelDispensersList = mappedTopology.FuelDispensersList;
            FuelTanksList = mappedTopology.FuelTanksList;

            CarMover.SetUpCarMover(modelingForm);
            CarRouter.SetUpCarRouter(modelingForm);
        }

        internal static void StartFilling(CarPictureBox car, PictureBox fuelDispenser)
        {
            var carView = car.Tag as CarView;
            var fuelDispenserView = (FuelDispenserView) fuelDispenser.Tag;

            fuelDispenserView.ChoseFuelTank(FuelTanksList, carView.Fuel);

            carView.PayForOrderedFuel((CashCounterView) CashCounter.Tag);

            car.IsFilling = true;
            fuelDispenserView.IsBusy = true;
        }

        internal static void FillCar(CarPictureBox car, FuelDispenserView fuelDispenser)
        {
            var carView = car.Tag as CarView;

            carView.FuelRemained += fuelDispenser.GetFuelFromTank();

            if (fuelDispenser.ChosenFuelTank.IsEmpty)
            {
                // CallRefiller()
            }

            if (((CashCounterView) CashCounter.Tag).IsFull && !_isCollectingMoney)
            {
                CallCollector();
                _isCollectingMoney = true;
            }

            // test

            if (carView.FuelRemained >= carView.DesiredFilling)
            {
                StopFilling(car, fuelDispenser);
            }
        }

        private static void StopFilling(CarPictureBox car, FuelDispenserView fuelDispenser)
        {
            var carView = car.Tag as CarView;

            if (carView.FuelRemained > carView.TankVolume)
            {
                carView.FuelRemained = carView.TankVolume;

                var fuelSurplus = carView.FuelRemained - carView.TankVolume;
                fuelDispenser.ReturnFuelToTank(fuelSurplus);
            }

            car.IsFilling = false;
            car.IsFilled = true;
            fuelDispenser.CarsInQueue--;
            fuelDispenser.IsBusy = false;
        }

        private static void CallCollector()
        {
            CarCreator.SpawnCollector();
        }

        internal static void CollectCash(CollectorPictureBox collector, CashCounterView cashCounter)
        {
            var collectorView = collector.Tag as CollectorView;

            collectorView.GetCashFromCashCounter();

            if (cashCounter.CurrentCashVolume < 0)
            {
                StopCollectingCash(collector, cashCounter);
            }
        }

        internal static void StartCollectingCash(CollectorPictureBox collector, CashCounterView cashCounter)
        {
            collector.IsFilling = true;
        }

        private static void StopCollectingCash(CollectorPictureBox collector, CashCounterView cashCounter)
        {
            var collectorView = collector.Tag as CollectorView;

            collectorView.ReturnCashToCashCounter(0 - cashCounter.CurrentCashVolume);

            collector.IsFilling = false;
            collector.IsFilled = true;

            //cashCounter.IsFull = false;

            _isCollectingMoney = false;
        }
    }
}