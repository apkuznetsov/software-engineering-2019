using GasStationMs.App.TemplateElements;
using GasStationMs.App.Topology.TopologyBuilderHelpers;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder
    {
        private DataGridView field;
        private int serviceAreaInCells;
        private int serviceAreaBorderColIndex;

        public TopologyBuilder(DataGridView dgv)
        {
            field = dgv ?? throw new NullReferenceException();

            AddDgvCols(Topology.MinColsCount);
            field.RowCount = Topology.MinRowsCount;

            SetupDgv();

            serviceAreaInCells = RecalculateServiceArea();

            SetupServiceArea();
            SetupRoad();
        }

        public TopologyBuilder(DataGridView field, int cols, int rows)
        {
            this.field = field ?? throw new NullReferenceException();

            if (cols < Topology.MinColsCount ||
                cols > Topology.MaxColsCount)
                throw new ArgumentOutOfRangeException();

            if (rows < Topology.MinRowsCount ||
                rows > Topology.MaxRowsCount)
                throw new ArgumentOutOfRangeException();


            AddDgvCols(Topology.MinColsCount);
            this.field.RowCount = Topology.MinRowsCount;

            SetupDgv();

            serviceAreaInCells = RecalculateServiceArea();

            SetupServiceArea();
            SetupRoad();
        }

        public void SetTopologyBuilder(Topology topology)
        {
            ToDgv(topology);
        }

        private void SetupDgv()
        {
            field.RowHeadersVisible = false;
            field.ColumnHeadersVisible = false;

            field.AllowUserToResizeColumns = false;
            field.AllowUserToResizeRows = false;

            field.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            field.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void SetupField(int colsCount, int rowsCount)
        {
            for (int i = 0; i < field.ColumnCount; i++)
                field.Columns.Remove(field.Columns[i]);
            for (int j = 0; j < field.RowCount; j++)
                field.Rows.Remove(field.Rows[j]);
            DataGridViewImageCell cell30 = (DataGridViewImageCell)field.Rows[0].Cells[3];
            DataGridViewImageCell cell31 = (DataGridViewImageCell)field.Rows[1].Cells[3];
            DataGridViewImageCell cell32 = (DataGridViewImageCell)field.Rows[2].Cells[3];
            DataGridViewImageCell cell40 = (DataGridViewImageCell)field.Rows[0].Cells[4];
            DataGridViewImageCell cell41 = (DataGridViewImageCell)field.Rows[1].Cells[4];
            DataGridViewImageCell cell42 = (DataGridViewImageCell)field.Rows[2].Cells[4];
            cell30.Tag = null; cell30.Value = null;
            cell31.Tag = null; cell31.Value = null;
            cell32.Tag = null; cell32.Value = null;
            cell40.Tag = null; cell40.Value = null;
            cell41.Tag = null; cell41.Value = null;
            cell42.Tag = null; cell42.Value = null;

            AddDgvCols(colsCount);
            AddDgvRows(rowsCount);
            serviceAreaInCells = RecalculateServiceArea();
            SetupServiceArea();
            SetupRoad();
        }

        private void AddDgvCols(int colsCount)
        {
            for (int i = 0; i < colsCount; i++)
            {
                field.Columns.Add(new BlankTopologyBuilderCol());
            }
        }

        private void AddDgvRows(int rowsCount)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                field.Rows.Add();
            }
        }

        private void SetupServiceArea()
        {
            int lastRowIndex = field.RowCount - 1;

            int сellsLeftToAdd = serviceAreaInCells;
            int cellsAdded = 0;

            DataGridViewImageCell cell;

            for (int currCol = field.ColumnCount - 1; currCol >= 0; currCol--)
            {
                for (int currRow = 0; currRow < lastRowIndex; currRow++)
                {
                    cell = (DataGridViewImageCell)field.Rows[currRow].Cells[currCol];
                    cell.Tag = new ServiceArea();
                    cell.Value = ServiceArea.Image;

                    cellsAdded++;
                    сellsLeftToAdd--;
                }

                if (сellsLeftToAdd <= 0)
                {
                    serviceAreaInCells = cellsAdded;
                    serviceAreaBorderColIndex = currCol;
                    break;
                }
            }
        }

        private void SetupRoad()
        {
            DataGridViewImageCell cell;
            for (int currCol = 0, lastRow = RoadRowIndex; currCol < field.ColumnCount; currCol++)
            {
                cell = (DataGridViewImageCell)field.Rows[lastRow].Cells[currCol];
                cell.Tag = new Road();
                cell.Value = Road.Image;
            }
        }

        private void ToDgv(Topology topology)
        {
            field.ColumnCount = topology.ColsCount;
            field.RowCount = topology.RowsCount;

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
            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

            cell.Value = null;
            cell.Tag = null;
        }

        private void AddRoad(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

            cell.Value = Road.Image;
            cell.Tag = new Road();
        }

        private void AddServiceArea(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

            cell.Value = ServiceArea.Image;
            cell.Tag = new ServiceArea();
        }

        public int ColsCount
        {
            get
            {
                return field.ColumnCount;
            }
        }

        public int RowsCount
        {
            get
            {
                return field.RowCount;
            }
        }

        public int RoadRowIndex
        {
            get
            {
                return field.Rows.GetLastRow(DataGridViewElementStates.Visible);
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
                    cell = (DataGridViewImageCell)field.Rows[currRow].Cells[currCol];
                    gseArr[currRow, currCol] = (IGasStationElement)cell.Tag;
                }
            }

            return new Topology(gseArr, serviceAreaBorderColIndex);
        }

        private void CheckTopologyCorrectness()
        {
            CheckMinNumOfTemplatesElements();
            CheckMaxNumOfTemplatesElements();
            CheckEntryAndExitOrder();
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

        private void CheckEntryAndExitOrder()
        {
            int roadRowIndex = RoadRowIndex;
            int entryColIndex = -1;
            int exitColIndex = -1;

            DataGridViewImageCell cell;
            for (int currCol = 0; currCol < serviceAreaBorderColIndex; currCol++)
            {
                cell = (DataGridViewImageCell)field.Rows[roadRowIndex].Cells[currCol];

                if (cell.Tag is Entry)
                {
                    entryColIndex = currCol;
                    continue;
                }
                else if (cell.Tag is Exit)
                {
                    exitColIndex = currCol;
                    continue;
                }
            }

            if (entryColIndex == -1)
                throw new NullReferenceException("ОШИБКА: нет въезда");

            if (exitColIndex == -1)
                throw new NullReferenceException("ОШИБКА: нет выезда");

            if (entryColIndex < exitColIndex)
                throw new InvalidOperationException("ОШИБКА: въезд должен располагаеться правее выезда");
        }
    }
}
