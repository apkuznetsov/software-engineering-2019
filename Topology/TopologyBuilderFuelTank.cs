using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // FuelTank
    {
        private int fuelTanksCount;

        public int FuelTanksCount
        {
            get
            {
                return fuelTanksCount;
            }

            set
            {
                if (value < Topology.MinFuelTanksCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > serviceAreaInCells)
                {
                    throw new ArgumentOutOfRangeException();
                }

                fuelTanksCount = value;
            }
        }

        public bool CanAddFuelTank()
        {
            int newNumOfFuelTanks = fuelTanksCount + 1;

            if (newNumOfFuelTanks <= serviceAreaInCells)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFuelTank()
        {
            FuelTanksCount = FuelTanksCount + 1;
        }

        private void DeleteFuelTank()
        {
            if (fuelTanksCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            fuelTanksCount--;
        }
    }
}
