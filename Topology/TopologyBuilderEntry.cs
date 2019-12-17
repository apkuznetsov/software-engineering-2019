using GasStationMs.App.Elements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Entry
    {
        private int entriesCount;

        public int EntriesCount
        {
            get
            {
                return entriesCount;
            }

            set
            {
                if (value < Topology.MinEntriesCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > Topology.MaxEntriesCount)
                {
                    throw new ArgumentOutOfRangeException();
                }

                entriesCount = value;
            }
        }

        public bool AddEntry(int x, int y)
        {
            if (CanAddEntry())
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = Entry.Image;
                cell.Tag = new Entry();

                EntriesCount++;

                return true;
            }

            return false;
        }

        private bool CanAddEntry()
        {
            bool canAdd = entriesCount + 1 <= Topology.MaxEntriesCount;

            if (canAdd)
                return true;

            return false;
        }

        public void DeleteEntry()
        {
            if (entriesCount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            entriesCount--;
        }
    }
}
