using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Exit
    {
        public static readonly int MinExitsCount = 1;
        public static readonly int MaxExitsCount = 1;

        private int exitsCount;

        public int ExitsCount
        {
            get
            {
                return exitsCount;
            }

            set
            {
                if (value < MinExitsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > MaxExitsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                exitsCount = value;
            }
        }

        public bool CanAddExit()
        {
            int newNumOfExits = exitsCount + 1;

            if (newNumOfExits <= MaxExitsCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddExit()
        {
            exitsCount++;
        }

        private void DeleteExit()
        {
            if (exitsCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            exitsCount--;
        }
    }
}
