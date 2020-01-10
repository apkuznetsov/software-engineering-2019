using GasStationMs.App.TemplateElements;
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
            if (CanAddExit(x, y))
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = Exit.Image;
                cell.Tag = new Exit();

                ExitsCount++;

                return true;
            }

            return false;
        }

        public bool AddExit(int x, int y, Exit exit)
        {
            if (CanAddExit(x, y))
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];

                cell.Value = Exit.Image;
                cell.Tag = exit;

                ExitsCount++;

                return true;
            }

            return false;
        }

        private bool CanAddExit(int x, int y)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            bool isRoad = cell.Tag is Road;

            if (isRoad &&
                !IsRoadUnderServiceArea(x, y) &&
                !IsRightBeforeServiceAreaBorder(x, y))
            {
                bool isNewCountOk = exitsCount + 1 <= Topology.MaxExitsCount;

                if (isNewCountOk)
                    return true;
            }

            return false;
        }

        private bool IsRightBeforeServiceAreaBorder(int x, int y)
        {
            int colIndexRightBeforeServiceAreaBorder = serviceAreaBorderColIndex - 1;

            if (x == colIndexRightBeforeServiceAreaBorder)
                return true;
            else
                return false;
        }

        public void DeleteExit(int x, int y)
        {
            if (exitsCount < 0)
                throw new ArgumentOutOfRangeException();

            DataGridViewImageCell cell = (DataGridViewImageCell)field.Rows[y].Cells[x];
            bool canDelete = cell.Tag is Exit;

            if (canDelete)
            {
                cell.Tag = null;
                cell.Tag = new Road();
                cell.Value = Road.Image;

                exitsCount--;
            }
            else
                throw new InvalidCastException();
        }
    }
}
