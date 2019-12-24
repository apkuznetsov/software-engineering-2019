using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GasStationMs.App.DB.Models;

namespace GasStationMs.App.Modeling.Models
{
    public class FuelDispenserView
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int SpeedOfFillingPerSecond { get; set; }
        public double SpeedOfFillingPerTick { get; set; }
        public bool IsBusy { get; set; }
        public int CarsInQueue { get; set; }

        public FuelTankView ChosenFuelTank { get; set; }

        public FuelDispenserView(string name, int speedOfFillingPerSecond)
        {
            Name = name;
            SpeedOfFillingPerSecond = speedOfFillingPerSecond;
            // Since 20ms is 1 tick, 1second = 1000ms = 50 ticks
            SpeedOfFillingPerTick = (double) speedOfFillingPerSecond / 50;
            IsBusy = false;
            CarsInQueue = 0;
        }

        public void ChoseFuelTank(List<PictureBox> fuelTanksList, FuelModel fuel)
        {
            ChosenFuelTank = null;

            double maxCurrentFullness = 0;

            foreach (var fuelTank in fuelTanksList)
            {
                var fuelTankView = (FuelTankView) fuelTank.Tag;

                if (fuelTankView.Fuel.Equals(fuel))
                {
                    if (maxCurrentFullness + 1000 < fuelTankView.CurrentFullness || maxCurrentFullness == 0)
                    {
                        maxCurrentFullness = fuelTankView.CurrentFullness;
                        ChosenFuelTank = fuelTankView;
                    }
                }
            }

            if (ChosenFuelTank == null)
            {
                throw new Exception("No fuel tank with fuel in the list");
            }
        }

        public double GetFuelFromTank()
        {
            ChosenFuelTank.CurrentFullness -= this.SpeedOfFillingPerTick;

            return SpeedOfFillingPerTick;
        }

        public void ReturnFuelToTank(double fuelSurplus)
        {
            ChosenFuelTank.CurrentFullness += fuelSurplus;
        }
    }
}