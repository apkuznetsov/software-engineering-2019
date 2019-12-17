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
            if (CanAddFuelTank())
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = FuelTank.Image;
                cell.Tag = new FuelTank();

                FuelTanksCount++;

                return true;
            }

            return false;
        }

        private bool CanAddFuelTank()
        {
            bool canAdd = fuelTanksCount + 1 <= serviceAreaInCells;

            if (canAdd)
                return true;

            return false;
        }

        public void DeleteFuelTank()
        {
            if (fuelTanksCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            fuelTanksCount--;
        }
    }
}
