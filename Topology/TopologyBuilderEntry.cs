using GasStationMs.App.TemplateElements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Entry
    {
        private int _entriesCount;

        public int EntriesCount
        {
            get
            {
                return _entriesCount;
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

                _entriesCount = value;
            }
        }

        public bool AddEntry(int x, int y)
        {
            if (CanAddEntry(x, y))
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];

                cell.Value = Entry.Image;
                cell.Tag = new Entry();

                EntriesCount++;

                return true;
            }

            return false;
        }

        private bool CanAddEntry(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];
            bool isRoad = cell.Tag is Road;
            bool isZerothCol = x == 0;

            if (isRoad &&
                !IsRoadUnderServiceArea(x, y) &&
                !isZerothCol)
            {
                bool isNewCountOk = _entriesCount + 1 <= Topology.MaxEntriesCount;

                if (isNewCountOk)
                    return true;
            }

            return false;
        }

        private bool IsRoadUnderServiceArea(int x, int y)
        {
            if (x >= _serviceAreaBorderColIndex)
                return true;

            return false;
        }

        public void DeleteEntry(int x, int y)
        {
            if (_entriesCount < 0)
                throw new ArgumentOutOfRangeException();

            DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];
            bool canDelete = cell.Tag is Entry;

            if (canDelete)
            {
                cell.Tag = null;
                cell.Tag = new Road();
                cell.Value = Road.Image;

                _entriesCount--;
            }
            else
                throw new InvalidCastException();
        }
    }
}
