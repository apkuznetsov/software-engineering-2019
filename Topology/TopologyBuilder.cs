using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder
    {
        #region поля
        private int colsCount;
        private int rowsCount;

        private int serviceAreaInCells;

        private DataGridView dgv;
        #endregion /поля

        public TopologyBuilder(DataGridView dgv)
        {
            colsCount = Topology.MinColsCount;
            rowsCount = Topology.MinRowsCount;

            serviceAreaInCells = RecalculateServiceArea();

            this.dgv = dgv ?? throw new NullReferenceException();
            SetupDgv();
        }

        private void SetupDgv()
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;

            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            AddDgvCols(colsCount);
            dgv.RowCount = rowsCount;
        }

        private void AddDgvCols(int colsCount)
        {
            for (int i = 0; i < colsCount; i++)
            {
                dgv.Columns.Add(new BlankTopologyBuilderCol());
            }
        }

        public int ColsCount
        {
            get
            {
                return colsCount;
            }

            set
            {
                if (value < Topology.MinColsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > Topology.MaxColsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (colsCount < value)
                {
                    AddDgvCols(value - colsCount);
                }
                else
                {
                    RemoveDgvCols(colsCount - value);
                }

                colsCount = value;

                serviceAreaInCells = RecalculateServiceArea();
            }
        }

        private void RemoveDgvCols(int colsCount)
        {
            for (int i = 0; i < colsCount; i++)
            {
                dgv.Columns.Remove(dgv.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None));
            }
        }

        public int RowsCount
        {
            get
            {
                return rowsCount;
            }

            set
            {
                if (value < Topology.MinRowsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > Topology.MaxRowsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                dgv.RowCount = value;
                rowsCount = dgv.RowCount;

                serviceAreaInCells = RecalculateServiceArea();
            }
        }

        private int RecalculateServiceArea()
        {
            return (int)(colsCount * rowsCount * Topology.ServiceAreaInShares);
        }

        public Topology CreateAndGetTopology()
        {
            IGasStationElement[,] gseArr = new IGasStationElement[dgv.RowCount, dgv.ColumnCount];

            DataGridViewImageCell cell;
            for (int currRow = 0; currRow < gseArr.GetLength(0); currRow++)
            {
                for (int currCol = 0; currCol < gseArr.GetLength(1); currCol++)
                {
                    cell = (DataGridViewImageCell)dgv.Rows[currRow].Cells[currCol];
                    gseArr[currRow, currCol] = (IGasStationElement)cell.Tag;
                }
            }

            return new Topology(gseArr);
        }
    }
}
