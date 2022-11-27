using GasStationMs.App.DB.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models.Views
{
    public class FuelDispenserView
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int SpeedOfFillingPerMinute { get; set; }
        public double SpeedOfFillingPerSecond { get; set; }
        public double SpeedOfFillingPerTick { get; set; }
        public bool IsBusy { get; set; }
        public int CarsInQueue { get; set; }

        public FuelTankView ChosenFuelTank { get; set; }

        public FuelDispenserView(string name, int speedOfFillingPerMinute)
        {
            Name = name;
            SpeedOfFillingPerMinute = speedOfFillingPerMinute;
            //SpeedOfFillingPerSecond = (double)speedOfFillingPerMinute / 60;
            SpeedOfFillingPerSecond = (double)speedOfFillingPerMinute;
            // Since 20ms is 1 tick, 1second = 1000ms = 50 ticks
            SpeedOfFillingPerTick = (double)SpeedOfFillingPerSecond / 50;
            IsBusy = false;
            CarsInQueue = 0;
        }

        public void ChooseFuelTank(List<PictureBox> fuelTanksList, FuelModel fuel)
        {
            ChosenFuelTank = null;

            double maxCurrentFullness = 0;

            foreach (var fuelTank in fuelTanksList)
            {
                var fuelTankView = (FuelTankView)fuelTank.Tag;

                if (fuelTankView.Fuel.Equals(fuel))
                {
                    if (maxCurrentFullness + 1000 < fuelTankView.CurrentFullness || Math.Abs(maxCurrentFullness) < 0.1)
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