using GasStationMs.App.Elements;
using System;
using System.Drawing;
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


        private bool DoesPointExist(int x, int y)
        {
            bool isExLess = x < 0;
            if (isExLess)
                return false;

            bool isExMore = x > field.ColumnCount - 1;
            if (isExMore)
                return false;
            bool isEyUpper = y < 0;

            if (isEyUpper)

                return false;
            bool isEyLower = y > field.RowCount - 1;
            if (isEyLower)

                return false;
            return true;
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
