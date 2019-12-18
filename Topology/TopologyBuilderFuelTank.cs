using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

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

        public bool AddFuelTank(int x, int y)
        {
            if (CanAddFuelTank(x, y))
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = FuelTank.Image;
                cell.Tag = new FuelTank();

                FuelTanksCount++;

                return true;
            }

            return false;
        }

        private bool CanAddFuelTank(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            bool isServiceArea = cell.Tag is ServiceArea;

            if (isServiceArea)
            {
                bool isNewCountRight = fuelTanksCount + 1 <= serviceAreaInCells;

                if (isNewCountRight)
                    return true;
            }

            return false;
        }

        private bool IsThroughOneRowAfterServiceAreaBorder(int x, int y)
        {
            bool isAfterBorderCol = x > serviceAreaBorderColIndex;

            if (isAfterBorderCol)
            {
                bool isServiceAreaBorderColIndexEven = (serviceAreaBorderColIndex % 2) == 0;
                bool isExEven = (x % 2) == 0;

                if (isServiceAreaBorderColIndexEven)
                {
                    if (!isExEven)
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (isExEven)
                        return true;
                    else
                        return false;
                }
            }
            else
                return false;
        }

        public void DeleteFuelTank(int x, int y)
        {
            if (fuelTanksCount < 0)
                throw new ArgumentOutOfRangeException();

            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            bool canDelete = cell.Tag is FuelTank;

            if (canDelete)
            {
                cell.Tag = null;
                cell.Tag = new ServiceArea();
                cell.Value = ServiceArea.Image;

                fuelTanksCount--;
            }
            else
                throw new InvalidCastException();
        }
    }
}
