using System.Windows.Forms;

namespace software_engineering_2019
{
    public partial class TopologyConstructor
    {
        private void SetSettings()
        {
            SetField();
            SetCellsSize();

            SetSpinners();
        }

        private void SetField()
        {
            fillingStationField.RowHeadersVisible = false;
            fillingStationField.ColumnHeadersVisible = false;

            fillingStationField.AllowUserToResizeColumns = false;
            fillingStationField.AllowUserToResizeRows = false;

            fillingStationField.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            fillingStationField.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            fillingStationField.RowCount = Settings.MinNumOfCellsVertically;
            fillingStationField.ColumnCount = Settings.MinNumOfCellsHorizontally;
        }

        private void SetCellsSize()
        {
            for (int i = 0; i < fillingStationField.ColumnCount; i++)
            {
                fillingStationField.Columns[i].Width = Settings.CellSizeInPx;
            }

            for (int j = 0; j < fillingStationField.RowCount; j++)
            {
                fillingStationField.Rows[j].Height = Settings.CellSizeInPx;
            }
        }

        private void SetSpinners()
        {
            cellsHorizontally.Minimum = Settings.MinNumOfCellsHorizontally;
            cellsHorizontally.Maximum = Settings.MaxNumOfCellsHorizontally;

            cellsVertically.Minimum = Settings.MinNumOfCellsVertically;
            cellsVertically.Maximum = Settings.MaxNumOfCellsVertically;

            cellsHorizontally.Text = fillingStationField.ColumnCount.ToString();
            cellsVertically.Text = fillingStationField.RowCount.ToString();
        }
    }
}
