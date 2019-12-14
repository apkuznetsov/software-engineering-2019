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

        public bool CanAddExit()
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
