using GasStationMs.App.TemplateElements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Topology
{
    public partial class TopologyBuilder // Exit
    {
        private int _exitsCount;

        public int ExitsCount
        {
            get
            {
                return _exitsCount;
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

                _exitsCount = value;
            }
        }

        public bool AddExit(int x, int y)
        {
            if (CanAddExit(x, y))
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];

                cell.Value = Exit.Image;
                cell.Tag = new Exit();

                ExitsCount++;

                return true;
            }

            return false;
        }

        private bool CanAddExit(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];
            bool isRoad = cell.Tag is Road;

            if (isRoad &&
                !IsRoadUnderServiceArea(x, y) &&
                !IsRightBeforeServiceAreaBorder(x, y))
            {
                bool isNewCountOk = _exitsCount + 1 <= Topology.MaxExitsCount;

                if (isNewCountOk)
                    return true;
            }

            return false;
        }

        private bool IsRightBeforeServiceAreaBorder(int x, int y)
        {
            int colIndexRightBeforeServiceAreaBorder = _serviceAreaBorderColIndex - 1;

            if (x == colIndexRightBeforeServiceAreaBorder)
                return true;
            else
                return false;
        }

        public void DeleteExit(int x, int y)
        {
            if (_exitsCount < 0)
                throw new ArgumentOutOfRangeException();

            DataGridViewImageCell cell = (DataGridViewImageCell)_field.Rows[y].Cells[x];
            bool canDelete = cell.Tag is Exit;

            if (canDelete)
            {
                cell.Tag = null;
                cell.Tag = new Road();
                cell.Value = Road.Image;

                _exitsCount--;
            }
            else
                throw new InvalidCastException();
        }
    }
}
