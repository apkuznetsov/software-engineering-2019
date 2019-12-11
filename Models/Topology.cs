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

        public static readonly int MinNumberOfFuelTanks = 1;
        public static readonly int MaxNumberOfFuelTanks =
            (int)(MaxNumOfCellsHorizontally * MaxNumOfCellsVertically * ServiceAreaInShares);
        #endregion

        private static int numOfCellsHorizontally;
        private static int numOfCellsVertically;

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
    }
}
