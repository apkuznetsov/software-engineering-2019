using GasStationMs.App.Elements;
using GasStationMs.App.Topology.TopologyBuilderHelpers;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder
    {
        private DataGridView dgv;
        private int serviceAreaInCells;
        private int serviceAreaBorderColIndex;

        public TopologyBuilder(DataGridView dgv)
        {
            this.dgv = dgv ?? throw new NullReferenceException();
            SetupDgv();

            serviceAreaInCells = RecalculateServiceArea();

            SetupServiceArea();
        }

        private void SetupDgv()
        {
            AddDgvCols(Topology.MinColsCount);
            dgv.RowCount = Topology.MinRowsCount;

            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;

            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void AddDgvCols(int colsCount)
        {
            for (int i = 0; i < colsCount; i++)
            {
                dgv.Columns.Add(new BlankTopologyBuilderCol());
            }
        }

        private void AddDgvRows(int rowsCount)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                dgv.Rows.Add();
            }
        }

        public void SetupServiceArea()
        {
            int serviceAreaCellsLeftToAdd = serviceAreaInCells;

            DataGridViewImageCell cell;

            int currCol;
            int currRow;

            for (currCol = dgv.ColumnCount - 1; currCol >= 0; currCol--)
            {
                for (currRow = 0; currRow < dgv.RowCount; currRow++)
                {
                    if (serviceAreaCellsLeftToAdd > 0)
                    {
                        cell = (DataGridViewImageCell)dgv.Rows[currRow].Cells[currCol];
                        cell.Tag = new ServiceArea();
                        cell.Value = ServiceArea.Image;

                        serviceAreaCellsLeftToAdd--;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        public int ColsCount
        {
            get
            {
                return dgv.ColumnCount;
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

                if (dgv.ColumnCount < value)
                {
                    AddDgvCols(value - dgv.ColumnCount);
                }
                else
                {
                    RemoveDgvCols(dgv.ColumnCount - value);
                }

                dgv.ColumnCount = value;

                serviceAreaInCells = RecalculateServiceArea();
            }
        }

        public int RowsCount
        {
            get
            {
                return dgv.RowCount;
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

                if (dgv.RowCount < value)
                {
                    AddDgvRows(value - dgv.RowCount);
                }
                else
                {
                    RemoveDgvRows(dgv.RowCount - value);
                }

                dgv.RowCount = value;

                serviceAreaInCells = RecalculateServiceArea();
            }
        }

        private void RemoveDgvCols(int colsCount)
        {
            for (int i = 0; i < colsCount; i++)
            {
                DataGridViewColumn dgvCol = dgv.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None);

                if (IsThereAnyTag(dgvCol))
                {
                    throw new CannotRemoveTopologyBuilderCol();
                }

                dgv.Columns.Remove(dgvCol);
            }
        }

        private void RemoveDgvRows(int rowsCount)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                int rowIndex = dgv.Rows.GetLastRow(DataGridViewElementStates.Visible);
                DataGridViewRow row = dgv.Rows[rowIndex];

                if (IsThereAnyTag(row))
                {
                    throw new CannotRemoveTopologyBuilderRow();
                }

                try
                {
                    DataGridViewImageCell[] penultimateRowCells = new DataGridViewImageCell[dgv.ColumnCount];
                    int penultimateRowIndex = rowIndex - 1;
                    DataGridViewImageCell cell;
                    for (int penultimateColIndex = 0; penultimateColIndex < penultimateRowCells.Length; penultimateColIndex++)
                    {
                        cell = (DataGridViewImageCell)dgv.Rows[penultimateRowIndex].Cells[penultimateColIndex];
                        penultimateRowCells[penultimateColIndex].Tag = cell.Tag;
                        penultimateRowCells[penultimateColIndex].Value = cell.Value;
                    }

                    dgv.Rows.Remove(row);

                    rowIndex = dgv.Rows.GetLastRow(DataGridViewElementStates.Visible);
                    for (int colIndex = 0; colIndex < dgv.ColumnCount; colIndex++)
                    {
                        cell = (DataGridViewImageCell)dgv.Rows[rowIndex].Cells[colIndex];
                        cell.Tag = penultimateRowCells[colIndex].Tag;
                        cell.Value = penultimateRowCells[colIndex].Value;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private bool IsThereAnyTag(DataGridViewColumn col)
        {
            int colIndex = col.Index;
            DataGridViewImageCell cell;

            for (int rowIndex = 0; rowIndex < dgv.RowCount; rowIndex++)
            {
                cell = (DataGridViewImageCell)dgv.Rows[rowIndex].Cells[colIndex];

                if (cell.Tag != null)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsThereAnyTag(DataGridViewRow row)
        {
            int rowIndex = row.Index;
            DataGridViewImageCell cell;

            for (int colIndex = 0; colIndex < dgv.ColumnCount; colIndex++)
            {
                cell = (DataGridViewImageCell)dgv.Rows[rowIndex].Cells[colIndex];

                if (cell.Tag != null)
                {
                    return true;
                }
            }

            return false;
        }

        private int RecalculateServiceArea()
        {
            return (int)(RowsCount * ColsCount * Topology.ServiceAreaInShares);
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
