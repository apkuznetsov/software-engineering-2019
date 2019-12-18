using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Elements;
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
            cellsHorizontally.Minimum = Topology.Topology.MinColsCount;
            cellsHorizontally.Maximum = Topology.Topology.MaxColsCount;

            cellsVertically.Minimum = Topology.Topology.MinRowsCount;
            cellsVertically.Maximum = Topology.Topology.MaxRowsCount;

            cellsHorizontally.Text = dgvTopology.ColumnCount.ToString();
            cellsVertically.Text = dgvTopology.RowCount.ToString();
        }

        private void SetTemplateElementsImages()
        {
            FuelDispenser.Image = new Bitmap(Properties.Resources.Fuel, Settings.CellSizeInPx, Settings.CellSizeInPx);
            FuelTank.Image = new Bitmap(Properties.Resources.FuelTank, Settings.CellSizeInPx, Settings.CellSizeInPx);
            CashCounter.Image = new Bitmap(Properties.Resources.CashCounter, Settings.CellSizeInPx, Settings.CellSizeInPx);
            Entry.Image = new Bitmap(Properties.Resources.Entry, Settings.CellSizeInPx, Settings.CellSizeInPx);
            Exit.Image = new Bitmap(Properties.Resources.Exit, Settings.CellSizeInPx, Settings.CellSizeInPx);
            ServiceArea.Image = new Bitmap(Properties.Resources.ServiceArea, Settings.CellSizeInPx, Settings.CellSizeInPx);
            Road.Image = new Bitmap(Properties.Resources.Road, Settings.CellSizeInPx, Settings.CellSizeInPx);
        }
    }
}
