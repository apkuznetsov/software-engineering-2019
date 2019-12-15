using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder
    {
        private int colsCount;
        private int rowsCount;
        private int serviceAreaInCells;

        private DataGridView dgv;

        public TopologyBuilder(DataGridView dgv)
        {
            colsCount = Topology.MinColsCount;
            rowsCount = Topology.MinColsCount;

            serviceAreaInCells = RecalculateServiceArea();

            #region dgv
            this.dgv = dgv ?? throw new NullReferenceException();

            this.dgv.RowHeadersVisible = false;
            this.dgv.ColumnHeadersVisible = false;

            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;

            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < colsCount; i++)
            {
                this.dgv.Columns.Add(new CustomImageColumn(Properties.Resources.Blank));
            }
            this.dgv.RowCount = rowsCount;
            #endregion /dgv
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
                    for (int i = 0; i < value - colsCount; i++)
                    {
                        dgv.Columns.Add(new CustomImageColumn(Properties.Resources.Blank));
                    }
                }
                else
                {
                    for (int i = 0; i < colsCount - value; i++)
                    {
                        dgv.Columns.Remove(dgv.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None));
                    }
                }

                colsCount = value;
                serviceAreaInCells = RecalculateServiceArea();
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

                rowsCount = value;
                dgv.RowCount = rowsCount;

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
