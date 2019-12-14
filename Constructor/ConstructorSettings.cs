using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Elements;
using GasStationMs.App.Topology;

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


            for (int i = 0; i < tb.ColsCount; i++)
            {

                dgvTopology.Columns.Add(new CustomImageColumn(Properties.Resources.Blank));
            }
            dgvTopology.RowCount = tb.RowsCount;
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
            cellsHorizontally.Minimum = TopologyBuilder.MinColsCount;
            cellsHorizontally.Maximum = TopologyBuilder.MaxColsCount;

            cellsVertically.Minimum = TopologyBuilder.MinRowsCount;
            cellsVertically.Maximum = TopologyBuilder.MaxRowsCount;

            cellsHorizontally.Text = dgvTopology.ColumnCount.ToString();
            cellsVertically.Text = dgvTopology.RowCount.ToString();
        }

        private void SetTemplateElementsImages()
        {
            FuelDispenser.Image = new Bitmap(Properties.Resources.fuel, Settings.CellSizeInPx, Settings.CellSizeInPx);
            FuelTank.Image = new Bitmap(Properties.Resources.FuelTank, Settings.CellSizeInPx, Settings.CellSizeInPx);
            //CashCounter.Image = new Bitmap(Properties.Resources.CashCounter, Settings.CellSizeInPx, Settings.CellSizeInPx);
        }
    }
}
