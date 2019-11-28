using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_engineering_2019
{
    public partial class TopologyConstructor : Form
    {
        public TopologyConstructor()
        {
            InitializeComponent();

            SetSettings();
        }

        private void SetSettings()
        {
            fillingStationField.RowHeadersVisible = false;
            fillingStationField.ColumnHeadersVisible = false;

            fillingStationField.AllowUserToResizeColumns = false;
            fillingStationField.AllowUserToResizeRows = false;

            fillingStationField.RowCount = Settings.MinNumOfCellsVertically;
            fillingStationField.ColumnCount = Settings.MinNumOfCellsHorizontally;

            SetCellsSize();
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
    }
}
