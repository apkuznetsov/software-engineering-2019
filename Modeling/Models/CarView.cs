using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models
{
    public class CarView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TankVolume { get; set; }
        public int FuelRemained { get; set; }

        public FuelView Fuel { get; set; }
        //public int? FuelTypeId { get; set; }
        //public string FuelTypeName { get; set; }

        public bool IsTruck { get; set; }
        public bool IsGoesFilling { get; set; }

        private List<Point> _destinationPoints;
        public PictureBox DestinationSpot;

        public CarView(int id, string name, int tankVolume, int fuelRemained,
            FuelView fuelView, bool isTruck, bool isGoesFilling)
        {
            Id = id;
            Name = name;
            TankVolume = tankVolume;
            FuelRemained = fuelRemained;
            Fuel = fuelView;
            IsTruck = isTruck;
            IsGoesFilling = isGoesFilling;

            _destinationPoints = new List<Point>();
        }

        public void AddDestinationPoint(int x, int y)
        {
            var destPoint = new Point(x, y);
            _destinationPoints.Add(destPoint);
        }

        public Point GetDestinationPoint()
        {
            return _destinationPoints.Count == 0 ? new Point(-1, -1) : _destinationPoints.Last();
        }

        public void RemoveDestinationPoint()
        {
            if (_destinationPoints.Count == 0)
            {
                return;
            }

            var lastAssignedPoint = _destinationPoints.Last();
            _destinationPoints.Remove(lastAssignedPoint);
        }
    }
}
