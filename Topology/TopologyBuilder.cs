using GasStationMs.App.TemplateElements;
using GasStationMs.App.Topology.TopologyBuilderHelpers;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder
    {
        private DataGridView _field;
        private int _serviceAreaInCells;
        private int _serviceAreaBorderColIndex;

        public TopologyBuilder(DataGridView dgv)
        {
            _field = dgv ?? throw new NullReferenceException();

            AddDgvCols(Topology.MinColsCount);
            _field.RowCount = Topology.MinRowsCount;

            SetupDgv();

            _serviceAreaInCells = RecalculateServiceArea();

            SetupServiceArea();
            SetupRoad();
        }

        public void SetTopologyBuilder(Topology topology)
        {
            ToDgv(topology);
        }

        private void SetupDgv()
        {
            _field.RowHeadersVisible = false;
            _field.ColumnHeadersVisible = false;

            _field.AllowUserToResizeColumns = false;
            _field.AllowUserToResizeRows = false;

            _field.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _field.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void AddDgvCols(int colsCount)
        {
            for (int i = 0; i < colsCount; i++)
            {
                _field.Columns.Add(new BlankTopologyBuilderCol());
            }
        }

        private void AddDgvRows(int rowsCount)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                _field.Rows.Add();
            }
        }

        private void SetupServiceArea()
        {
            int lastRowIndex = _field.RowCount - 1;

            int сellsLeftToAdd = _serviceAreaInCells;
            int cellsAdded = 0;

            DataGridViewImageCell cell;

            for (int currCol = _field.ColumnCount - 1; currCol >= 0; currCol--)
            {
                for (int currRow = 0; currRow < lastRowIndex; currRow++)
                {
                    cell = (DataGridViewImageCell)_field.Rows[currRow].Cells[currCol];
                    cell.Tag = new ServiceArea();
                    cell.Value = ServiceArea.Image;

                    cellsAdded++;
                    сellsLeftToAdd--;
                }

                if (сellsLeftToAdd <= 0)
                {
                    _serviceAreaInCells = cellsAdded;
                    _serviceAreaBorderColIndex = currCol;
                    break;
                }
            }
        }

        private void SetupRoad()
        {
            DataGridViewImageCell cell;
            for (int currCol = 0, lastRow = _field.Rows.GetLastRow(DataGridViewElementStates.Visible); currCol < _field.ColumnCount; currCol++)
            {
                cell = (DataGridViewImageCell)_field.Rows[lastRow].Cells[currCol];
                cell.Tag = new Road();
                cell.Value = Road.Image;
            }
        }

        private void ToDgv(Topology topology)
        {
            _field.ColumnCount = topology.ColsCount;
            _field.RowCount = topology.RowsCount;

            SetupServiceArea();           
            SetupRoad();

            IGasStationElement gse;
            for (int y = 0; y <= topology.LastY; y++)
                for (int x = 0; x <= topology.LastX; x++)
                {
                    gse = topology[x, y];

                    if (gse == null)
                        AddBlank(x, y);
                    else if (gse is CashCounter)
                        AddCashCounter(x, y);
                    else if (gse is Entry)
                        AddEntry(x, y);
                    else if (gse is Exit)
                        AddExit(x, y);
                    else if (gse is FuelDispenser)
                        AddFuelDispenser(x, y);
                    else if (gse is FuelTank)
                        AddFuelTank(x, y);
                    else if (gse is Road)
                        AddRoad(x, y);
                    else if (gse is ServiceArea)
                        AddServiceArea(x, y);
                    else
                        throw new InvalidCastException();
                }
        }

        private void AddBlank(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];

            cell.Value = null;
            cell.Tag = null;
        }

        private void AddRoad(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];

            cell.Value = Road.Image;
            cell.Tag = new Road();
        }

        private void AddServiceArea(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];

            cell.Value = ServiceArea.Image;
            cell.Tag = new ServiceArea();
        }

        public int ColsCount
        {
            get
            {
                return _field.ColumnCount;
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

                if (_field.ColumnCount < value)
                {
                    AddDgvCols(value - _field.ColumnCount);
                }
                else
                {
                    RemoveDgvCols(_field.ColumnCount - value);
                }

                _field.ColumnCount = value;

                //serviceAreaInCells = RecalculateServiceArea();
            }
        }

        public int RowsCount
        {
            get
            {
                return _field.RowCount;
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

                if (_field.RowCount < value)
                {
                    AddDgvRows(value - _field.RowCount);
                }
                else
                {
                    RemoveDgvRows(_field.RowCount - value);
                }

                _field.RowCount = value;

                //serviceAreaInCells = RecalculateServiceArea();
            }
        }

        private void RemoveDgvCols(int colsCount)
        {
            for (int i = 0; i < colsCount; i++)
            {
                DataGridViewColumn dgvCol = _field.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None);

                if (IsThereAnyTag(dgvCol))
                {
                    throw new CannotRemoveTopologyBuilderCol();
                }

                _field.Columns.Remove(dgvCol);
            }
        }

        private void RemoveDgvRows(int rowsCount)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                int rowIndex = _field.Rows.GetLastRow(DataGridViewElementStates.Visible);
                DataGridViewRow row = _field.Rows[rowIndex];

                if (IsThereAnyTag(row))
                {
                    throw new CannotRemoveTopologyBuilderRow();
                }

                try
                {
                    DataGridViewImageCell[] penultimateRowCells = new DataGridViewImageCell[_field.ColumnCount];
                    int penultimateRowIndex = rowIndex - 1;
                    DataGridViewImageCell cell;
                    for (int penultimateColIndex = 0; penultimateColIndex < penultimateRowCells.Length; penultimateColIndex++)
                    {
                        cell = (DataGridViewImageCell)_field.Rows[penultimateRowIndex].Cells[penultimateColIndex];
                        penultimateRowCells[penultimateColIndex].Tag = cell.Tag;
                        penultimateRowCells[penultimateColIndex].Value = cell.Value;
                    }

                    _field.Rows.Remove(row);

                    rowIndex = _field.Rows.GetLastRow(DataGridViewElementStates.Visible);
                    for (int colIndex = 0; colIndex < _field.ColumnCount; colIndex++)
                    {
                        cell = (DataGridViewImageCell)_field.Rows[rowIndex].Cells[colIndex];
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

            for (int rowIndex = 0; rowIndex < _field.RowCount; rowIndex++)
            {
                cell = (DataGridViewImageCell)_field.Rows[rowIndex].Cells[colIndex];

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

            for (int colIndex = 0; colIndex < _field.ColumnCount; colIndex++)
            {
                cell = (DataGridViewImageCell)_field.Rows[rowIndex].Cells[colIndex];

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

        public Topology ToTopology()
        {
            IGasStationElement[,] gseArr = new IGasStationElement[_field.RowCount, _field.ColumnCount];

            DataGridViewImageCell cell;
            for (int currRow = 0; currRow < gseArr.GetLength(0); currRow++)
            {
                for (int currCol = 0; currCol < gseArr.GetLength(1); currCol++)
                {
                    cell = (DataGridViewImageCell)_field.Rows[currRow].Cells[currCol];
                    //if (cell.Tag != null)
                    //{
                    gseArr[currRow, currCol] = (IGasStationElement)cell.Tag;
                    //}
                    //else
                    //{
                    //    gseArr[currRow, currCol] = null;
                    //}
                }
            }

            return new Topology(gseArr, _serviceAreaBorderColIndex);
        }
    }
}
