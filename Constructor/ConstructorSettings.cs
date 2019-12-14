using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Models;
using GasStationMs.App.TemplateElements;

namespace GasStationMs.App
{
    public partial class Constructor
    {
        private void SetSettings()
        {
            SetField();
            SetCellsSize();
            SetSpinners();
            SetRbsNames();

            SetTemplateElementsImages();
        }

        private void SetField()
        {
            dgvTopology.RowHeadersVisible = false;
            dgvTopology.ColumnHeadersVisible = false;

            dgvTopology.AllowUserToResizeColumns = false;
            dgvTopology.AllowUserToResizeRows = false;

            dgvTopology.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTopology.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            for (int i = 0; i < Topology.NumOfCellsHorizontally; i++)
            {

                dgvTopology.Columns.Add(new CustomImageColumn(Properties.Resources.Blank));
            }
            dgvTopology.RowCount = Topology.NumOfCellsVertically;
        }

        private void SetCellsSize()

        {
            for (int i = 0; i < dgvTopology.ColumnCount; i++)
            {
                dgvTopology.Columns[i].Width = Settings.CellSizeInPx;
            }

            for (int j = 0; j < dgvTopology.RowCount; j++)
            {
                dgvTopology.Rows[j].Height = Settings.CellSizeInPx;
            }
        }

        private void SetSpinners()
        {
            cellsHorizontally.Minimum = Topology.MinNumOfCellsHorizontally;
            cellsHorizontally.Maximum = Topology.MaxNumOfCellsHorizontally;

            cellsVertically.Minimum = Topology.MinNumOfCellsVertically;
            cellsVertically.Maximum = Topology.MaxNumOfCellsVertically;

            cellsHorizontally.Text = dgvTopology.ColumnCount.ToString();
            cellsVertically.Text = dgvTopology.RowCount.ToString();
        }

        private void SetRbsNames()
        {
            rbFuelDispenser.Name = typeof(FuelDispenser).ToString();
            rbFuelTank.Name = typeof(FuelTank).ToString();
            rbCashCounter.Name = typeof(CashCounter).ToString();
        }

        private void SetTemplateElementsImages()
        {
            FuelDispenser.Image = new Bitmap(Properties.Resources.fuel, Settings.CellSizeInPx, Settings.CellSizeInPx);
            FuelTank.Image = new Bitmap(Properties.Resources.FuelTank, Settings.CellSizeInPx, Settings.CellSizeInPx);
            //CashCounter.Image = new Bitmap(Properties.Resources.CashCounter, Settings.CellSizeInPx, Settings.CellSizeInPx);
        }
    }
}
