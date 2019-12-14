using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Exit
    {
        private int exitsCount;

        public int ExitsCount
        {
            get
            {
                return exitsCount;
            }

            set
            {
                if (value < Topology.MinExitsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > Topology.MaxExitsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                exitsCount = value;
            }
        }

        public bool AddExit()
        {
            if (CanAddExit())
            {
                exitsCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CanAddExit()
        {
            int newNumOfExits = exitsCount + 1;

            if (newNumOfExits <= Topology.MaxExitsCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteExit()
        {
            if (exitsCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            exitsCount--;
        }
    }
}
