using GasStationMs.App.Elements;
using GasStationMs.App.TemplateElements;
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
            if (CanAddEntry(x, y))
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = Entry.Image;
                cell.Tag = new Entry();

                EntriesCount++;

                return true;
            }

            return false;
        }

        private bool CanAddEntry(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            bool isRoad = cell.Tag is Road;

            if (isRoad)
            {
                bool isNewCountOk = entriesCount + 1 <= Topology.MaxEntriesCount;

                if (isNewCountOk)
                    return true;
            }

            return false;
        }

        public void DeleteEntry(int x, int y)
        {
            if (entriesCount < 0)
                throw new ArgumentOutOfRangeException();

            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            bool canDelete = cell.Tag is Entry;

            if (canDelete)
            {
                cell.Tag = null;
                cell.Tag = new Road();
                cell.Value = Road.Image;

                entriesCount--;
            }
            else
                throw new InvalidCastException();
        }
    }
}
