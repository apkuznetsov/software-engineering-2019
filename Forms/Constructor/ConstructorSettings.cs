using System.Drawing;
using GasStationMs.App.TemplateElements;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor
    {
        const int CellSizeInPx = 30;

        private void SetSettings()
        {
            SetCellsSize();
            SetRbsNames();
            SetTemplateElementsImages();
        }

        private void SetCellsSize()

        {
            for (int i = 0; i < dgvTopology.ColumnCount; i++)
            {
                dgvTopology.Columns[i].Width = CellSizeInPx;
            }

            for (int j = 0; j < dgvTopology.RowCount; j++)
            {
                dgvTopology.Rows[j].Height = CellSizeInPx;
            }
        }

        private void SetTemplateElementsImages()
        {
            FuelDispenser.Image = new Bitmap(Properties.Resources.Fuel, CellSizeInPx, CellSizeInPx);
            FuelTank.Image = new Bitmap(Properties.Resources.FuelTank, CellSizeInPx, CellSizeInPx);
            CashCounter.Image = new Bitmap(Properties.Resources.CashCounter, CellSizeInPx, CellSizeInPx);
            Entry.Image = new Bitmap(Properties.Resources.Entry, CellSizeInPx, CellSizeInPx);
            Exit.Image = new Bitmap(Properties.Resources.Exit, CellSizeInPx, CellSizeInPx);
            ServiceArea.Image = new Bitmap(Properties.Resources.ServiceArea, CellSizeInPx, CellSizeInPx);
            Road.Image = new Bitmap(Properties.Resources.Road, CellSizeInPx, CellSizeInPx);
        }
    }
}
