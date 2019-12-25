using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models.Views;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models.PictureBoxes
{
    internal class CollectorPictureBox : MoveablePictureBox
    {
        public CollectorPictureBox(ModelingForm modelingForm, CollectorView collectorView)
        {
            Tag = collectorView;
            Image = Properties.Resources.collector_35x17_;
            Location = DestinationPointsDefiner.SpawnPoint;
            SizeMode = PictureBoxSizeMode.AutoSize;

            IsGoesFilling = true;

            MouseClick += new MouseEventHandler(ClickEventProvider.CashCollectorPictureBox_Click);

            modelingForm.PlaygroundPanel.Controls.Add(this);
            BringToFront();
        }
    }
}
