using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder
    {
        public static readonly double ServiceAreaInShares = 0.25;

        #region константы размера
        public static readonly int MinNumOfCellsHorizontally = 10;
        public static readonly int MaxNumOfCellsHorizontally = 35;

        public static readonly int MinNumOfCellsVertically = 7;
        public static readonly int MaxNumOfCellsVertically = 25;
        #endregion

        #region константы кол-ва ШЭ
        public static readonly int MinAndMaxNumOfAdjacentRoads = 1;

        public static readonly int MinNumOfFuelDispensers = 1;
        public static readonly int MaxNumOfFuelDispensers = 6;

        public static readonly int MinNumOfFuelTanks = 1;
        public static readonly int MaxNumOfFuelTanks =
            (int)(MaxNumOfCellsHorizontally * MaxNumOfCellsVertically * ServiceAreaInShares);

        public static readonly int MinNumOfCashCounters = 1;
        public static readonly int MaxNumOfCashCounters = 1;
        #endregion

        #region поля
        private int numOfCellsHorizontally;
        private int numOfCellsVertically;

        private int serviceAreaInCells;

        private int numOfFuelTanks;
        private int numOfFuelDispensers;
        private int numOfCashCounters;
        #endregion

        public TopologyBuilder()
        {
            numOfCellsHorizontally = MinNumOfCellsHorizontally;
            numOfCellsVertically = MinNumOfCellsHorizontally;

            serviceAreaInCells = RecalculateServiceArea();
        }

        #region свойства
        public int NumOfCellsHorizontally
        {
            get
            {
                return numOfCellsHorizontally;
            }

            set
            {
                if (value < MinNumOfCellsHorizontally)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > MaxNumOfCellsHorizontally)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfCellsHorizontally = value;
                serviceAreaInCells = RecalculateServiceArea();
            }
        }

        public int NumOfCellsVertically
        {
            get
            {
                return numOfCellsVertically;
            }

            set
            {
                if (value < MinNumOfCellsVertically)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > MaxNumOfCellsVertically)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfCellsVertically = value;
                serviceAreaInCells = RecalculateServiceArea();
            }
        }

        public int NumOfAdjacentRoads
        {
            get
            {
                return MinAndMaxNumOfAdjacentRoads;
            }
        }

        public int NumOfFuelDispensers
        {
            get
            {
                return numOfFuelDispensers;
            }

            set
            {
                if (value < MinNumOfFuelDispensers)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > MaxNumOfFuelDispensers)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfFuelDispensers = value;
            }
        }

        public int NumOfFuelTanks
        {
            get
            {
                return numOfFuelTanks;
            }

            set
            {
                if (value < MinNumOfFuelTanks)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > serviceAreaInCells)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfFuelTanks = value;
            }
        }

        public int NumOfCashCounters
        {
            get
            {
                return numOfCashCounters;
            }

            set
            {
                if (value < MinNumOfCashCounters)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > MaxNumOfCashCounters)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfCashCounters = value;
            }
        }
        #endregion

        private int RecalculateServiceArea()
        {
            return (int)(numOfCellsHorizontally * numOfCellsVertically * ServiceAreaInShares);
        }

        #region ТРК
        public bool CanAddFuelDispenser()
        {
            int newNumOfFuelDispensers = numOfFuelDispensers + 1;

            if (newNumOfFuelDispensers <= MaxNumOfFuelDispensers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFuelDispenser()
        {
            NumOfFuelDispensers = NumOfFuelDispensers + 1;
        }

        private void DeleteFuelDispenser()
        {
            if (numOfFuelDispensers < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfFuelDispensers--;
        }
        #endregion /ТРК

        #region ТБ
        public bool CanAddFuelTank()
        {
            int newNumOfFuelTanks = numOfFuelTanks + 1;

            if (newNumOfFuelTanks <= serviceAreaInCells)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFuelTank()
        {
            NumOfFuelTanks = NumOfFuelTanks + 1;
        }

        private void DeleteFuelTank()
        {
            if (numOfFuelTanks < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfFuelTanks--;
        }
        #endregion /ТБ

        #region касса
        public bool CanAddCashCounter()
        {
            int newNumOfCashCounters = numOfCashCounters + 1;

            if (newNumOfCashCounters <= MaxNumOfCashCounters)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddCashCounter()
        {
            numOfCashCounters++;
        }

        private void DeleteCashCounter()
        {
            if (numOfCashCounters < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfCashCounters--;
        }
        #endregion /касса

        public void DeleteTemplateElement(DataGridViewCell cell)
        {
            bool canDelete = (cell.Tag != null);

            if (canDelete)
            {
                if (cell.Tag is FuelDispenser)
                {
                    DeleteFuelDispenser();
                }
                else if (cell.Tag is FuelTank)
                {
                    DeleteFuelTank();
                }
                else if (cell.Tag is CashCounter)
                {
                    DeleteCashCounter();
                }
                else if (cell.Tag is Entry)
                {
                    DeleteEntry();
                }
                else if (cell.Tag is Exit)
                {
                    DeleteExit();
                }
                else { }

                cell.Tag = null;
                cell.Value = null;
            }
        }

        public IGasStationElement[,] GetGasStationElementsArray(DataGridView dgv)
        {
            IGasStationElement[,] gseArr;
            gseArr = new IGasStationElement[dgv.RowCount, dgv.ColumnCount];

            DataGridViewImageCell cell;
            for (int currRow = 0; currRow < gseArr.GetLength(0); currRow++)
            {
                for (int currCol = 0; currCol < gseArr.GetLength(1); currCol++)
                {
                    cell = (DataGridViewImageCell)dgv.Rows[currRow].Cells[currCol];
                    gseArr[currRow, currCol] = (IGasStationElement)cell.Tag;
                }
            }

            return gseArr;
        }
    }
}
