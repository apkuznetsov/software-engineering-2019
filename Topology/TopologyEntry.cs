using System;

namespace GasStationMs.App.Models
{
    public static partial class Topology // Entry
    {
        public static readonly int MinNumOfEntries = 1;
        public static readonly int MaxNumOfEntries = 1;

        private static int numOfEntries;

        public static int NumOfEntries
        {
            get
            {
                return numOfEntries;
            }

            set
            {
                if (value < MinNumOfEntries)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > MaxNumOfEntries)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfEntries = value;
            }
        }

        public static bool CanAddEntry()
        {
            int newNumOfEntries = numOfEntries + 1;

            if (newNumOfEntries <= MaxNumOfEntries)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddEntry()
        {
            numOfEntries++;
        }

        private static void DeleteEntry()
        {
            if (numOfEntries < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfEntries--;
        }
    }
}
