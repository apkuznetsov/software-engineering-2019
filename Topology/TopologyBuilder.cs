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
        }

        public int RowsCount
        {
            get
            {
                return _field.RowCount;
            }
        }

        private int RecalculateServiceArea()
        {
            return (int)(RowsCount * ColsCount * Topology.ServiceAreaInShares);
        }

        public Topology ToTopology()
        {
            CheckTopologyCorrectness();

            IGasStationElement[,] gseArr = new IGasStationElement[RowsCount, ColsCount];

            DataGridViewImageCell cell;
            for (int currRow = 0; currRow < gseArr.GetLength(0); currRow++)
            {
                for (int currCol = 0; currCol < gseArr.GetLength(1); currCol++)
                {
                    cell = (DataGridViewImageCell)_field.Rows[currRow].Cells[currCol];
                    gseArr[currRow, currCol] = (IGasStationElement)cell.Tag;
                }
            }

            return new Topology(gseArr, _serviceAreaBorderColIndex);
        }

        private void CheckTopologyCorrectness()
        {
            CheckMinNumOfTemplatesElements();
            CheckMaxNumOfTemplatesElements();
        }

        private void CheckMinNumOfTemplatesElements()
        {
            if (cashCountersCount < Topology.MinCashCountersCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть минимум " + Topology.MinCashCountersCount + " касс");

            if (EntriesCount < Topology.MinEntriesCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть минимум " + Topology.MinEntriesCount + " въездов");

            if (ExitsCount < Topology.MinExitsCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть минимум " + Topology.MinExitsCount + " выездов");

            if (FuelDispensersCount < Topology.MinFuelDispensersCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть минимум " + Topology.MinFuelDispensersCount + " ТРК");

            if (FuelTanksCount < Topology.MinFuelTanksCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть минимум " + Topology.MinFuelTanksCount + " ТБ");
        }

        private void CheckMaxNumOfTemplatesElements()
        {
            if (cashCountersCount > Topology.MaxCashCountersCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть максимум " + Topology.MaxCashCountersCount + " касс");

            if (EntriesCount > Topology.MaxEntriesCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть максимум " + Topology.MaxEntriesCount + " въездов");

            if (ExitsCount > Topology.MaxExitsCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть максимум " + Topology.MaxExitsCount + " выездов");

            if (FuelDispensersCount > Topology.MaxFuelDispensersCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть максимум " + Topology.MaxFuelDispensersCount + " ТРК");

            if (FuelTanksCount > Topology.MaxFuelTanksCount)
                throw new InvalidOperationException(
                    "ОШИБКА, некорректная топология: должно быть максимум " + Topology.MaxFuelTanksCount + " ТБ");
        }
    }
}
