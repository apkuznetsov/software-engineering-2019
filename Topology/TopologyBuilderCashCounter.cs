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

        private bool AreCellsAroundBlankOrDontExist(int x, int y)
        {
            Point northWest = new Point(x - 1, y - 1);
            if (DoesCellExist(northWest.X, northWest.Y))
                if (!IsCellBlank(northWest.X, northWest.Y))
                    return false;

            Point west = new Point(x - 1, y);
            if (DoesCellExist(west.X, west.Y))
                if (!IsCellBlank(west.X, west.Y))
                    return false;

            Point southWest = new Point(x - 1, y + 1);
            if (DoesCellExist(southWest.X, southWest.Y))
                if (!IsCellBlank(southWest.X, southWest.Y))
                    return false;

            Point north = new Point(x, y - 1);
            if (DoesCellExist(north.X, north.Y))
                if (!IsCellBlank(north.X, north.Y))
                    return false;

            Point south = new Point(x, y + 1);
            if (DoesCellExist(south.X, south.Y))
                if (!IsCellBlank(south.X, south.Y))
                    return false;

            Point northEast = new Point(x + 1, y - 1);
            if (DoesCellExist(northEast.X, northEast.Y))
                if (!IsCellBlank(northEast.X, northEast.Y))
                    return false;

            Point east = new Point(x + 1, y);
            if (DoesCellExist(east.X, east.Y))
                if (!IsCellBlank(east.X, east.Y))
                    return false;

            Point southEast = new Point(x + 1, y + 1);
            if (DoesCellExist(southEast.X, southEast.Y))
                if (!IsCellBlank(southEast.X, southEast.Y))
                    return false;

            return false;
        }

        private bool DoesCellExist(int x, int y)
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
