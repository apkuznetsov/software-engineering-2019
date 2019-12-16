using System;
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
        public double FuelRemained { get; set; }
        public double DesiredFilling { get; }
        public double OrderedAmountOfFuel { get; }

        public FuelModel Fuel { get; set; }
        //public int? FuelTypeId { get; set; }
        //public string FuelTypeName { get; set; }

        public bool IsTruck { get; set; }
        public bool IsGoesFilling { get; set; }
        public bool IsOnStation { get; set; }
        public bool IsFilled { get; set; }
        public bool IsFilling { get; set; }
        public bool IsFuelDispenserChosen { get; set; }
        public bool IsBypassingObject { get; set; }
        public PictureBox ChosenFuelDispenser { get; set; }

        private List<Point> _destinationPoints;
        public PictureBox DestinationSpot;

        public CarView(int id, string name, int tankVolume, double fuelRemained,
            FuelModel fuelView, bool isTruck, bool isGoesFilling)
        {
            Id = id;
            Name = name;
            TankVolume = tankVolume;
            FuelRemained = fuelRemained;
            DesiredFilling = GenerateDesiredFilling();
            OrderedAmountOfFuel = DesiredFilling - fuelRemained;
            Fuel = fuelView;
            IsTruck = isTruck;
            IsGoesFilling = isGoesFilling;

            _destinationPoints = new List<Point>();
        }

        public PictureBox CreateDestinationSpot(Point destPoint)
        {
            var spotSize = 5;
            this.DestinationSpot = new PictureBox()
            {
                Size = new Size(spotSize, spotSize),
                Location = destPoint,
                Visible = true,
                BackColor = Color.DarkRed
            };

            this.DestinationSpot.BringToFront();

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

            DeleteDestinationSpot(form);
        }

        public void DeleteDestinationSpot(Form form)
        {
            form.Controls.Remove(DestinationSpot);
            DestinationSpot.Dispose();
            DestinationSpot = null;
        }

        public bool HasDestPoints()
        {
            return _destinationPoints.Count > 0;
        }

        public void PayForOrderedFuel(CashCounterView cashCounterView)
        {
            cashCounterView.CurrentCashVolume += OrderedAmountOfFuel * Fuel.Price;
        }

        private double GenerateDesiredFilling()
        {
            // With step equal to 5% of Tank volume
            var rnd = new Random();

            var onePercentOfTankVolume = (double) TankVolume / 100;
            var fivePercentOfTankVolume = onePercentOfTankVolume * 5;

            // Percentage of the remained fuel of the total tank volume
            var percentageOfRemainedFuel = Convert.ToInt32((double) FuelRemained / (onePercentOfTankVolume));

            var countOfFivePercentPartInRemainedFuel = Convert.ToInt32(percentageOfRemainedFuel / 5);

            // 21 because it's 20 parts of 5% in 100%
            return rnd.Next(countOfFivePercentPartInRemainedFuel + 1, 21) * fivePercentOfTankVolume;
        }
    }
}