using GasStationMs.App.DB.Models;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models.Views
{
    internal class CarView
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

        public bool IsFuelDispenserChosen { get; set; }
        public PictureBox ChosenFuelDispenser { get; set; }


        public CarView(int id, string name, int tankVolume, double fuelRemained,
            FuelModel fuelView, bool isTruck)
        {
            Id = id;
            Name = name;
            TankVolume = tankVolume;
            FuelRemained = fuelRemained;
            DesiredFilling = GenerateDesiredFilling();
            OrderedAmountOfFuel = DesiredFilling - fuelRemained;
            Fuel = fuelView;
            IsTruck = isTruck;
        }


        public void PayForOrderedFuel(CashCounterView cashCounterView)
        {
            cashCounterView.CurrentCashVolume += OrderedAmountOfFuel * Fuel.Price;
        }

        private double GenerateDesiredFilling()
        {
            // With step equal to 5% of Tank volume
            var rnd = new Random();

            var onePercentOfTankVolume = (double)TankVolume / 100;
            var fivePercentOfTankVolume = onePercentOfTankVolume * 5;

            // Percentage of the remained fuel of the total tank volume
            var percentageOfRemainedFuel = Convert.ToInt32((double)FuelRemained / (onePercentOfTankVolume));

            var countOfFivePercentPartInRemainedFuel = Convert.ToInt32(percentageOfRemainedFuel / 5);

            // 21 because it's 20 parts of 5% in 100%
            return rnd.Next(countOfFivePercentPartInRemainedFuel + 1, 21) * fivePercentOfTankVolume;
        }
    }
}