using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;
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
            }

            //if (!_paused)
            //{
            //    //return;
            //    CarCreator.SpawnCar();

            //    _paused = true;
            //}

            if (_timerTicksCount % 40 == 0)
            {
                CarCreator.SpawnCar();
            }

            #region LoopingControls

            foreach (Control c in panelPlayground.Controls)
            {
                if (!(c is PictureBox) || c.Tag == null)
                {
                    continue;
                }

                var pictureBox = (PictureBox)c;

                // Car
                if (pictureBox.Tag is CarView)
                {
                    var car = pictureBox;
                    var carView = (CarView)car.Tag;

                    CarRouter.RouteCar(car);

                    CarMover.MoveCarToDestination(car);
                }
            }

            #endregion /LoopingControls
        }
    }
}
