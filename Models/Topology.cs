using GasStationMs.App.TemplateElements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Models
{
    public static class Topology
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

        public static readonly int MinAndMaxNumOfEntries = 1;

        public static readonly int MinAndMaxNumOfExits = 1;

        public static readonly int MinNumOfFuelDispensers = 1;
        public static readonly int MaxNumOfFuelDispensers = 6;

        public static readonly int MinNumOfFuelTanks = 1;
        public static readonly int MaxNumOfFuelTanks =
            (int)(MaxNumOfCellsHorizontally * MaxNumOfCellsVertically * ServiceAreaInShares);

        public static readonly int MinNumOfCashCounters = 1;
        public static readonly int MaxNumOfCashCounters = 1;
        #endregion

        #region поля
        private static int serviceAreaInCells = RecalculateServiceArea();

        private static int numOfCellsHorizontally = MinNumOfCellsHorizontally;
        private static int numOfCellsVertically = MinNumOfCellsHorizontally;

        private static int numOfFuelTanks;
        private static int numOfFuelDispensers;
        private static int numOfCashCounters;
        #endregion

        #region свойства
        public static int NumOfCellsHorizontally
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

        public static int NumOfCellsVertically
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

        public static int NumOfAdjacentRoads
        {
            get
            {
                return MinAndMaxNumOfAdjacentRoads;
            }
        }

        public static int NumOfEntries
        {
            get
            {
                return MinAndMaxNumOfEntries;
            }
        }

        public static int NumOfExits
        {
            get
            {
                return MinAndMaxNumOfExits;
            }
        }

        public static int NumOfFuelDispensers
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

        public static int NumOfFuelTanks
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

                int maxNumb = (int)(numOfCellsHorizontally * numOfCellsVertically * ServiceAreaInShares);
                if (value > maxNumb)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfFuelTanks = value;
            }
        }

        public static int NumOfCashCounters
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

        private static int RecalculateServiceArea()
        {
            return (int)(numOfCellsHorizontally * numOfCellsVertically * ServiceAreaInShares);
        }

        #region ТРК
        public static bool CanAddFuelDispenser()
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

        public static void AddFuelDispenser()
        {
            NumOfFuelDispensers = NumOfFuelDispensers + 1;
        }

        private static void DeleteFuelDispenser()
        {
            if (numOfFuelDispensers < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfFuelDispensers--;
        }
        #endregion /ТРК

        #region ТБ
        public static bool CanAddFuelTank()
        {
            int newNumOfFuelTanks = numOfFuelTanks + 1;

            int temp = serviceAreaInCells;
            if (newNumOfFuelTanks <= serviceAreaInCells)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddFuelTank()
        {
            NumOfFuelTanks = NumOfFuelTanks + 1;
        }

        private static void DeleteFuelTank()
        {
            if (numOfFuelTanks < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfFuelTanks--;
        }
        #endregion /ТБ

        public static void DeleteTemplateElement(DataGridViewCell cell)
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
                else { }

                cell.Tag = null;
                cell.Value = null;
            }
        }
    }
}
