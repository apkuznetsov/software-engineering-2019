using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Exit
    {
        private int exitsCount;

        public int ExitsCount
        {
            get
            {
                return exitsCount;
            }

            set
            {
                if (value < Topology.MinExitsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > Topology.MaxExitsCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                exitsCount = value;
            }
        }

        public bool AddExit(int x, int y)
        {
            if (CanAddExit())
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = Exit.Image;
                cell.Tag = new Exit();

                ExitsCount++;

                return true;
            }

            return false;
        }

        private bool CanAddExit()
        {
            bool canAdd = exitsCount + 1 <= Topology.MaxExitsCount;

            if (canAdd)
                return true;

            return false;
        }

        public void DeleteExit()
        {
            if (exitsCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            exitsCount--;
        }
    }
}
