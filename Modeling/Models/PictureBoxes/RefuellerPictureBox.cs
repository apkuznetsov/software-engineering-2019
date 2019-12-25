using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models.Views;

namespace GasStationMs.App.Modeling.Models.PictureBoxes
{
    internal class RefuellerPictureBox : MoveablePictureBox
    {
        public RefuellerPictureBox(ModelingForm modelingForm, RefuellerView refuellerView)
        {
            Tag = refuellerView;
            Image = Properties.Resources.refueler_30x35_;
            Location = DestinationPointsDefiner.RefuellerSpawnPoint;
            SizeMode = PictureBoxSizeMode.AutoSize;

            MouseClick += new MouseEventHandler(ClickEventProvider.RefuellerPictureBox_Click);

            modelingForm.PlaygroundPanel.Controls.Add(this);
            BringToFront();
        }
    }
}
