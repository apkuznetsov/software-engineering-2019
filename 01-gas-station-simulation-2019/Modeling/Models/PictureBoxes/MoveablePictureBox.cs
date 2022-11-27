using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models.PictureBoxes
{
    internal class MoveablePictureBox : PictureBox
    {
        internal bool IsGoesFilling { get; set; }
        internal bool IsOnStation { get; set; }
        internal bool IsFilled { get; set; }
        internal bool IsFilling { get; set; }
        internal bool IsBypassingObject { get; set; }
        internal bool IsGoesHorizontal { get; set; }
        internal Point FromLeftBypassingPoint { get; set; }


        private readonly List<Point> _destinationPoints;
        public PictureBox DestinationSpot;

        public MoveablePictureBox()
        {
            _destinationPoints = new List<Point>();
        }

        public PictureBox CreateDestinationSpot(Point destPoint)
        {
            var spotSize = 5;

            DestinationSpot = new PictureBox()
            {
                Size = new Size(spotSize, spotSize),
                Location = destPoint,
                Visible = true,
                //BackColor = Color.DarkRed
            };

            DestinationSpot.BringToFront();

            return DestinationSpot;
        }

        public void AddDestinationPoint(Point destPoint)
        {
            _destinationPoints.Add(destPoint);
        }

        public Point GetDestinationPoint()
        {
            return _destinationPoints.Count == 0 ? new Point(-1, -1) : _destinationPoints.Last();
        }

        public void RemoveDestinationPoint(Form form)
        {
            if (_destinationPoints.Count == 0)
            {
                return;
            }

            var lastAssignedPoint = _destinationPoints.Last();
            _destinationPoints.Remove(lastAssignedPoint);

            if (DestinationSpot != null)
            {
                DeleteDestinationSpot(form);
            }
        }

        public void DeleteDestinationSpot(Form form)
        {
            if (DestinationSpot != null)
            {
                form.Controls.Remove(DestinationSpot);
                DestinationSpot.Dispose();
                DestinationSpot = null;
            }
        }

        public bool HasDestPoints()
        {
            return _destinationPoints.Count > 0;
        }
    }
}
