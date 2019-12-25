using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;
using GasStationMs.App.Modeling.Models.PictureBoxes;
using GasStationMs.App.Modeling.Models.Views;
using GasStationMs.App.Modeling.MovingLogic.Car;
using GasStationMs.App.Modeling.MovingLogic.Refueller;
using static GasStationMs.App.Modeling.ClickEventProvider;

namespace GasStationMs.App.Modeling
{
    internal static class ModelingTicker
    {
        private static int _timerTicksCount;
        private static bool _paused;
        internal static void Tick(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            var selectedItem = modelingForm.SelectedItem;
            var panelPlayground = modelingForm.PlaygroundPanel;


            _timerTicksCount++;

            modelingForm.LabelCashCounterSumValue.Text = ((int)((CashCounterView)mappedTopology.CashCounter.Tag).CurrentCashVolume).ToString();

            if (selectedItem != null)
            {
                if (selectedItem.Tag is CarView)
                {
                    CarPictureBox_Click(selectedItem, null);
                }

                if (selectedItem.Tag is FuelDispenserView)
                {
                    FuelDispenserPictureBox_Click(selectedItem, null);
                }

                if (selectedItem.Tag is FuelTankView)
                {
                    FuelTankPictureBox_Click(selectedItem, null);
                }

                if (selectedItem.Tag is CashCounterView)
                {
                    CashCounterPictureBox_Click(selectedItem, null);
                }

                if (selectedItem is CollectorPictureBox)
                {
                    CashCollectorPictureBox_Click(selectedItem, null);
                }
            }

            //if (!_paused)
            //{
            //    //return;
            //    //CarCreator.SpawnCar();
            //    CarCreator.SpawnCollector();

            //    _paused = true;
            //}

            if (_timerTicksCount % 20 == 0)
            {
                CarCreator.SpawnCar();
            }

            #region LoopingControls

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
        }
    }
}
