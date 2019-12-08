using System.Windows.Forms;
using GasStationMs.App.Models;

namespace GasStationMs.App
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

            
            for (int i = 0; i < Topology.MinNumOfCellsHorizontally; i++)
            {
               // DataGridViewImageColumn DataGridViewImageColumn = new DataGridViewImageColumn(true);
                fillingStationField.Columns.Add(new CustomImageColumn(Properties.Resources.Blank));
            }// Blank - белый цвет 30 на 30 и нет проблем с размерами
            
            fillingStationField.RowCount = Topology.MinNumOfCellsVertically;
            
            // remove default [x] image for data DataGridViewImageColumn columns
            //foreach (DataGridViewImageColumn column in fillingStationField.Columns)
            //{                
            //        column.DefaultCellStyle.NullValue = null;// почему блять не работает для последнего ряда?
            //}

            //DataGridViewRow row = fillingStationField.RowTemplate;
            //row.DefaultCellStyle.NullValue = null;
        }

        private void SetCellsSize() 
            // чото с imagecolumncell не работает ни фига при создании грида - делает 20 на20,
            // размер ячейки получают от Blank
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
            cellsHorizontally.Minimum = Topology.MinNumOfCellsHorizontally;
            cellsHorizontally.Maximum = Topology.MaxNumOfCellsHorizontally;

            cellsVertically.Minimum = Topology.MinNumOfCellsVertically;
            cellsVertically.Maximum = Topology.MaxNumOfCellsVertically;

            cellsHorizontally.Text = fillingStationField.ColumnCount.ToString();
            cellsVertically.Text = fillingStationField.RowCount.ToString();
        }
    }
}
