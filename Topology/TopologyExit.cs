using System;

namespace GasStationMs.App.Models
{
    public static partial class Topology // Exit
    {
        public static readonly int MinNumOfExits = 1;
        public static readonly int MaxNumOfExits = 1;

        private static int numOfExits;

        public static int NumOfExits
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

        public static bool CanAddExit()
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

        public static void AddExit()
        {
            numOfExits++;
        }

        private static void DeleteExit()
        {
            if (numOfExits < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            numOfExits--;
        }
    }
}
