using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models.Views;
using System.Windows.Forms;
using GasStationMs.App.Modeling.MovingLogic;

namespace GasStationMs.App.Modeling.Models.PictureBoxes
{
    internal class CarPictureBox : MoveablePictureBox
    {
        public CarPictureBox(ModelingForm modelingForm, CarView carView)
        {
            Tag = carView;
            Image = Properties.Resources.car_32x17__left;
            Location = DestinationPointsDefiner.SpawnPoint;
            SizeMode = PictureBoxSizeMode.AutoSize;

            IsGoesFilling = false;

            MouseClick += ClickEventProvider.CarPictureBox_Click;

            modelingForm.PlaygroundPanel.Controls.Add(this);
            BringToFront();
        }
    }
}
