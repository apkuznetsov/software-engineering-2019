using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // FuelDispenser
    {
        private int fuelDispensersCount;

        public int FuelDispensersCount
        {
            get
            {
                return fuelDispensersCount;
            }

            set
            {
                if (value < Topology.MinFuelDispensersCount)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > Topology.MaxFuelDispensersCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                fuelDispensersCount = value;
            }
        }

        public bool AddFuelDispenser()
        {
            if (CanAddFuelDispenser())
            {
                FuelDispensersCount = FuelDispensersCount + 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CanAddFuelDispenser()
        {
            int newNumOfFuelDispensers = fuelDispensersCount + 1;

            if (newNumOfFuelDispensers <= Topology.MaxFuelDispensersCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteFuelDispenser()
        {
            if (fuelDispensersCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            fuelDispensersCount--;
        }
    }
}
