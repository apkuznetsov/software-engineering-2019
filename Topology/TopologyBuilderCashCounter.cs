using System;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // CashCounter
    {
        private int cashCountersCount;

        public int CashCountersCount
        {
            get
            {
                return cashCountersCount;
            }

            set
            {
                if (value < Topology.MinCashCountersCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > Topology.MaxCashCountersCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                cashCountersCount = value;
            }
        }

        public bool AddCashCounter()
        {
            if (CanAddCashCounter())
            {
                cashCountersCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CanAddCashCounter()
        {
            int newNumOfCashCounters = cashCountersCount + 1;

            if (newNumOfCashCounters <= Topology.MaxCashCountersCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteCashCounter()
        {
            if (cashCountersCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            cashCountersCount--;
        }
    }
}
