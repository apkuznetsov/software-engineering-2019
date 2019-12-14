using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Entry
    {
        public static readonly int MinEntriesCount = 1;
        public static readonly int MaxEntriesCount = 1;

        private int entriesCount;

        public int EntriesCount
        {
            get
            {
                return entriesCount;
            }

            set
            {
                if (value < MinEntriesCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > MaxEntriesCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                entriesCount = value;
            }
        }

        public bool CanAddEntry()
        {
            int newNumOfEntries = entriesCount + 1;

            if (newNumOfEntries <= MaxEntriesCount)
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
            entriesCount++;
        }

        private void DeleteEntry()
        {
            if (entriesCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            entriesCount--;
        }
    }
}
