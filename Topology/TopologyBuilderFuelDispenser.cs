using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

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

        public bool AddFuelDispenser(int x, int y)
        {
            if (CanAddFuelDispenser())
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = FuelDispenser.Image;
                cell.Tag = new FuelDispenser();

                FuelDispensersCount++;

                return true;
            }

            return false;
        }

        private bool CanAddFuelDispenser()
        {
            bool canAdd = fuelDispensersCount + 1 <= Topology.MaxFuelDispensersCount;

            if (canAdd)
                return true;

            return false;
        }

        //private bool AreCellsAroundFree(int x, int y)
        //{
        //    bool isCellOnEdge = IsCellOnEdgeOrOut(x, y);

        //    return false;
        //}

        private bool IsCellOnEdgeOrOut(int x, int y)
        {
            bool isOnLeftColOrLess = x <= 0;
            bool isOnRightColOrMore = x >= field.ColumnCount;

            bool isOnTopRowOrUpper = y <= 0;
            bool isOnBotRowOrLower = y >= field.RowCount;

            if (isOnLeftColOrLess ||
                isOnRightColOrMore ||
                isOnTopRowOrUpper ||
                isOnBotRowOrLower)
                return true;

            return false;
        }

        private bool AreCellsAroundBlank(int x, int y)
        {
            Point northWest = new Point(x - 1, y - 1);
            if (!IsCellBlank(northWest.X, northWest.Y))
                return false;

            Point west = new Point(x - 1, y);
            if (!IsCellBlank(west.X, west.Y))
                return false;

            Point southWest = new Point(x - 1, y + 1);
            if (!IsCellBlank(southWest.X, southWest.Y))
                return false;

            Point north = new Point(x, y - 1);
            if (!IsCellBlank(north.X, north.Y))
                return false;

            Point south = new Point(x, y + 1);
            if (!IsCellBlank(south.X, south.Y))
                return false;

            Point northEast = new Point(x + 1, y - 1);
            if (!IsCellBlank(northEast.X, northEast.Y))
                return false;

            Point east = new Point(x + 1, y);
            if (!IsCellBlank(east.X, east.Y))
                return false;

            Point southEast = new Point(x + 1, y + 1);
            if (!IsCellBlank(southEast.X, southEast.Y))
                return false;

            return true;
        }

        private bool IsCellBlank(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            if (cell.Tag == null)
                return true;

            return false;
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
