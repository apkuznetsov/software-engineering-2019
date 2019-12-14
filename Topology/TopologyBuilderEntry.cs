using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Entry
    {
        public static readonly int MinNumOfEntries = 1;
        public static readonly int MaxNumOfEntries = 1;

        private int numOfEntries;

        public int NumOfEntries
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

        public bool CanAddEntry()
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

        public void AddEntry()
        {
            numOfEntries++;
        }

        private void DeleteEntry()
        {
            if (numOfEntries < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfEntries--;
        }
    }
}
