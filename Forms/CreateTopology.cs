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
            string dotExt = Topology.Topology.DotExt;
            string filter = " " + dotExt + "|" + "*" + dotExt;

            SaveFileDialog sfd = new SaveFileDialog
            {
                DefaultExt = dotExt,
                Filter = filter
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = sfd.FileName;
                btnOpenConstructor.Enabled = true;
            }
        }

        private void btnOpenConstructor_Click(object sender, EventArgs e)
        {
            Constructor.Constructor constructor = new Constructor.Constructor(fullFilePath, (int)nudChooseColsCount.Value, (int)nudChooseRowsCount.Value);
            constructor.Show();

            this.Close();
        }
    }
}
