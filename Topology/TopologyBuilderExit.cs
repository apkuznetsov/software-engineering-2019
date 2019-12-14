using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Exit
    {
        public static readonly int MinNumOfExits = 1;
        public static readonly int MaxNumOfExits = 1;

        private int numOfExits;

        public int NumOfExits
        {
            get
            {
                return numOfExits;
            }

            set
            {
                if (value < MinNumOfExits)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > MaxNumOfExits)
                {
                    throw new ArgumentOutOfRangeException();
                }

                numOfExits = value;
            }
        }

        public bool CanAddExit()
        {
            int newNumOfExits = numOfExits + 1;

            if (newNumOfExits <= MaxNumOfExits)
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
            numOfExits++;
        }

        private void DeleteExit()
        {
            if (numOfExits < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfExits--;
        }
    }
}
