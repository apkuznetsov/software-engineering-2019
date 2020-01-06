using GasStationMs.App.Topology;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class CreateTopology : Form
    {
        private string fullFilePath;

        public CreateTopology()
        {
            InitializeComponent();

            SetupSettings();
        }

        private void SetupSettings()
        {
            btnOpenConstructor.Enabled = false;
            SetupNudsSettings();
        }

        private void SetupNudsSettings()
        {
            nudChooseColsCount.Minimum = Topology.Topology.MinColsCount;
            nudChooseColsCount.Maximum = Topology.Topology.MaxColsCount;

            nudChooseRowsCount.Minimum = Topology.Topology.MinRowsCount;
            nudChooseRowsCount.Maximum = Topology.Topology.MaxRowsCount;
        }

        private void btnChooseFullFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                DefaultExt = TopologySaverAndLoader.DotExt,
                Filter = TopologySaverAndLoader.Filter
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = saveFileDialog.FileName;
                btnOpenConstructor.Enabled = true;
            }
        }

        private void btnOpenConstructor_Click(object sender, EventArgs e)
        {
            Constructor.Constructor constructor = new Constructor.Constructor(fullFilePath, (int)nudChooseColsCount.Value, (int)nudChooseRowsCount.Value);
            constructor.ShowDialog();

            Dispose();
            Close();
        }
    }
}
