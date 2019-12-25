using GasStationMs.App.DB.Models;
using System.Drawing;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models.Views
{
    public class FuelTankView
    {
        private const int WhenRefillInPercentage = 10;
        public string Name { get; set; }
        public int Volume { get; }
        public double CurrentFullness { get; set; }
        public bool IsEmpty => CurrentFullness < ((double)Volume / 100) * WhenRefillInPercentage;
        public FuelModel Fuel { get; set; }
        public Point PointOfRefilling { get; private set; }

        public FuelTankView(string name, int volume, double currentFullness, FuelModel fuel)
        {
            Name = name;
            Volume = volume;
            CurrentFullness = currentFullness;
            Fuel = fuel;
        }

        public void DefinePointOfRefilling(PictureBox fuelTank)
        {
            var x = fuelTank.Right + DestinationPointsDefiner.FuelingPointDeltaX;
            var y = fuelTank.Top;
            PointOfRefilling = new Point(x, y);
        }
    }
}