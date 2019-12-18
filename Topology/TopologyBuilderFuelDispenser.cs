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
