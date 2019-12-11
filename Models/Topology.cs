using System;

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

        public static readonly int MinAndMaxNumOfCashboxes = 1;

        public static readonly int MinNumOfFuelTanks = 1;
        public static readonly int MaxNumOfFuelTanks =
            (int)(MaxNumOfCellsHorizontally * MaxNumOfCellsVertically * ServiceAreaInShares);

        public static readonly int MinNumOfFuelDispensers = 1;
        public static readonly int MaxNumOfFuelDispensers = 6;
        #endregion

        #region поля
        private static int numOfCellsHorizontally;
        private static int numOfCellsVertically;
        private static int numOfFuelTanks;
        private static int numOfFuelDispensers;
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

        public static int NumOfCashboxes
        {
            get
            {
                return MinAndMaxNumOfCashboxes;
            }
        }
        #endregion
    }
}
