using GasStationMs.App.Topology;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class CreateTopology : Form
    {
        private static readonly int smallColsCount = Topology.Topology.MinColsCount;
        private static readonly int smallRowsCount = Topology.Topology.MinRowsCount;

        private static readonly int bigColsCount = Topology.Topology.MaxColsCount;
        private static readonly int bigRowsCount = Topology.Topology.MaxRowsCount;

        private static readonly int mediumColsCount = (int)(smallColsCount + 0.5 * (bigColsCount - smallColsCount));
        private static readonly int mediumRowsCount = (int)(smallRowsCount + 0.5 * (bigRowsCount - smallRowsCount));

        private string fullFilePath;

        public CreateTopology()
        {
            InitializeComponent();

            SetupSettings();
        }

        private void SetupSettings()
        {
            btnOpenConstructor.Enabled = false;
            rbChosenSmallSize.Checked = true;
            MakeChosenOtherSizeInvisible();

            SetupRbsTexts();
            SetupNudsSettings();
        }

        private void MakeChosenOtherSizeVisible()
        {
            nudChooseColsCount.Visible = true;
            labelTimes.Visible = true;
            nudChooseRowsCount.Visible = true;
        }

        private void MakeChosenOtherSizeInvisible()
        {
            nudChooseColsCount.Visible = false;
            labelTimes.Visible = false;
            nudChooseRowsCount.Visible = false;
        }

        private void SetupRbsTexts()
        {
            rbChosenSmallSize.Text = "Маленькая " + smallColsCount + " x " + smallRowsCount;
            rbChosenBigSize.Text = "Большая " + bigColsCount + " x " + bigRowsCount;
            rbChosenMediumSize.Text = "Средняя " + mediumColsCount + " x " + mediumRowsCount;
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
                tbFullFilePath.Text = fullFilePath;
                btnOpenConstructor.Enabled = true;
            }
        }

        private void btnOpenConstructor_Click(object sender, EventArgs e)
        {
            Constructor.Constructor constructor;

            if ((rbChosenSmallSize.Checked == true))
            {
                constructor = new Constructor.Constructor(fullFilePath, smallColsCount, smallRowsCount);
            }
            else if (rbChosenBigSize.Checked == true)
            {
                constructor = new Constructor.Constructor(fullFilePath, bigColsCount, bigRowsCount);
            }
            else if (rbChosenMediumSize.Checked == true)
            {
                constructor = new Constructor.Constructor(fullFilePath, mediumColsCount, mediumRowsCount);
            }
            else
            {
                constructor = new Constructor.Constructor(fullFilePath, (int)nudChooseColsCount.Value, (int)nudChooseRowsCount.Value);
            }

            constructor.Show();

            Dispose();
            Close();
        }

        private void rbChosenOtherSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChosenOtherSize.Checked == true)
            {
                MakeChosenOtherSizeVisible();
            }
            else
            {
                MakeChosenOtherSizeInvisible();
            }
        }
    }
}
