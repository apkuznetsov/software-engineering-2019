using System.Linq;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models.PictureBoxes;
using GasStationMs.App.Modeling.Models.Views;
using GasStationMs.App.Modeling.MovingLogic.Car;
using GasStationMs.App.Modeling.MovingLogic.Refueller;
using System.Windows.Forms;
using GasStationMs.App.Models;
using static GasStationMs.App.Modeling.ClickEventProvider;
using static GasStationMs.App.Modeling.ModelingTimeManager;

namespace GasStationMs.App.Modeling
{
    internal static class ModelingTicker
    {
        private static PictureBox _selectedItem;
        private static PictureBox _selectedFuelDispenser;
        private static PictureBox _selectedFuelTank;
        internal static void Tick(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            if (IsPaused)
            {
                return;
            }

            TimerTicksCount++;
            TicksAfterLastCarSpawning++;

            if (TimeAfterLastCarSpawningInSeconds >= TimeBetweenCars)
            {
                CarCreator.SpawnCar();
                TimeBetweenCars = ModelSettings.TrafficFlow.TimeBetweenCars;
                TicksAfterLastCarSpawning = 0;
            }

            //if (!_paused)
            //{
            //    //return;
            //    //CarCreator.SpawnCar();
            //    CarCreator.SpawnCollector();

            //    _paused = true;
            //}


            //if (TimerTicksCount % 20 == 0)
            //{
            //    CarCreator.SpawnCar();
            //}

            #region LoopingControls

            var panelPlayground = modelingForm.PlaygroundPanel;

            foreach (Control control in panelPlayground.Controls)
            {
                if (!(control is MoveablePictureBox))
                {
                    continue;
                }

                var moveablePictureBox = control as MoveablePictureBox;

                // Car
                if (moveablePictureBox is CarPictureBox car)
                {
                    CarRouter.RouteCar(car);

                    CarMover.MoveCarToDestination(car);

                    continue;
                }

                // Collector
                if (moveablePictureBox is CollectorPictureBox collector)
                {
                    CarRouter.RouteCar(collector);

                    CarMover.MoveCarToDestination(collector);

                    continue;
                }

                // Refueller
                if (moveablePictureBox is RefuellerPictureBox refueller)
                {
                    RefuellerRouter.RouteRefueller(refueller);

                    RefuellerMover.MoveRefuellerToDestination(refueller);
                }
            }

            #endregion /LoopingControls

            #region UI

           UpdateUI(modelingForm, mappedTopology);

            #endregion UI
        }

        private static void UpdateUI(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            UpdateCashCounterInfo(modelingForm, mappedTopology);
            UpdateFuelDispenserInfo(modelingForm, mappedTopology);
            UpdateFuelTankInfo(modelingForm, mappedTopology);

            _selectedItem = modelingForm.SelectedItem;

            if (_selectedItem != null)
            {
                if (_selectedItem.Tag is CarView)
                {
                    CarPictureBox_Click(_selectedItem, null);
                }

                if (_selectedItem.Tag is FuelDispenserView)
                {
                    FuelDispenserPictureBox_Click(_selectedItem, null);
                }

                if (_selectedItem.Tag is FuelTankView)
                {
                    FuelTankPictureBox_Click(_selectedItem, null);
                }

                if (_selectedItem.Tag is CashCounterView)
                {
                    CashCounterPictureBox_Click(_selectedItem, null);
                }

                if (_selectedItem is CollectorPictureBox)
                {
                    CashCollectorPictureBox_Click(_selectedItem, null);
                }
            }
        }

        private static void UpdateCashCounterInfo(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            modelingForm.LabelCashCounterSumValue.Text =
                ((int)((CashCounterView)mappedTopology.CashCounter.Tag).CurrentCashVolume).ToString();
        }

        private static void UpdateFuelDispenserInfo(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            _selectedFuelDispenser = modelingForm.SelectedFuelDispenser ?? mappedTopology.FuelDispensersList.First();
            var fuelDispenserView = _selectedFuelDispenser.Tag as FuelDispenserView;

            modelingForm.LabelSpeedOfFillingValue.Text = fuelDispenserView.SpeedOfFillingPerMinute.ToString();
        }

        private static void UpdateFuelTankInfo(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            _selectedFuelTank = modelingForm.SelectedFuelTank ?? mappedTopology.FuelTanksList.First();
            var fuelTankView = _selectedFuelTank.Tag as FuelTankView;

            modelingForm.LabelFuelValue.Text = fuelTankView.Fuel.ToString();
            modelingForm.LabelVolumeValue.Text = fuelTankView.Volume.ToString();
            modelingForm.LabelCurrentFullnessValue.Text = fuelTankView.CurrentFullness.ToString();

        }
    }
}
