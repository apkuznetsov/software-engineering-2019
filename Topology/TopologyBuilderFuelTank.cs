using System;
using System.Windows.Forms;
using GasStationMs.App.TemplateElements;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // FuelTank
    {
        private int _fuelTanksCount;

        public int FuelTanksCount
        {
            get
            {
                return _fuelTanksCount;
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

                _fuelTanksCount = value;
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

            if (isServiceArea &&
                IsThroughOneRowAfterServiceAreaBorder(x, y))
            {
                bool isNewCountRight = _fuelTanksCount + 1 <= serviceAreaInCells;

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
            if (_fuelTanksCount < 0)
                throw new ArgumentOutOfRangeException();

            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            bool canDelete = cell.Tag is FuelTank;

            if (canDelete)
            {
                cell.Tag = null;
                cell.Tag = new ServiceArea();
                cell.Value = ServiceArea.Image;

                _fuelTanksCount--;
            }
            else
                throw new InvalidCastException();
        }
    }
}
