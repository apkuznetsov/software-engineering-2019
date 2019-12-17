using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

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

        public bool AddCashCounter(int x, int y)
        {
            if (CanAddCashCounter())
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = CashCounter.Image;
                cell.Tag = new CashCounter();

                CashCountersCount++;

                return true;
            }

            return false;
        }

        private bool CanAddCashCounter()
        {
            bool canAdd = cashCountersCount + 1 <= Topology.MaxCashCountersCount;

            if (canAdd)
                return true;

            return false;
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
