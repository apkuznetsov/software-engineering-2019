using GasStationMs.App.Forms;
using System;
using System.Windows.Forms;
using Container = SimpleInjector.Container;

namespace GasStationMs.App.Forms
{
    public partial class CreatingTopologyForm : Form
    {
        private readonly Container _container;

        private string filePath;

        public CreatingTopologyForm(Container container)
        {
            _container = container;
            InitializeComponent();

            btnOpenConstructorForm.Enabled = false;

            SetupNudsSettings();
        }

        private void SetupNudsSettings()
        {
            nudChooseColsCount.Minimum = Topology.Topology.MinColsCount;
            nudChooseColsCount.Maximum = Topology.Topology.MaxColsCount;

            nudChooseRowsCount.Minimum = Topology.Topology.MinRowsCount;
            nudChooseRowsCount.Maximum = Topology.Topology.MaxRowsCount;
        }

        private void btnFilePath_Click(object sender, EventArgs e)
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
                filePath = sfd.FileName;
                btnOpenConstructorForm.Enabled = true;
            }
        }

        private void btnOpenConstructorForm_Click(object sender, EventArgs e)
        {
            Constructor.Constructor formConstructor = _container.GetInstance<Constructor.Constructor>();
            formConstructor.Show();

            formConstructor.TopologyBuilder.SetupField((int)nudChooseColsCount.Value, (int)nudChooseRowsCount.Value);
            formConstructor.CurrFilePath = filePath;

            this.Close();
        }
    }
}
