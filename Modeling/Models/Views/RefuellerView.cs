using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models.Views
{
    public class RefuellerView
    {
        public int SpeedOfRefillingPerSecond { get; private set; }
        public double SpeedOfRefillingPerTick { get; private set; }
        public double FuelRemaining { get; private set; }
        public FuelTankView FuelTank { get; set; }

        public RefuellerView(int speedOfRefillingPerSecond)
        {
            SpeedOfRefillingPerSecond = speedOfRefillingPerSecond;
            // Since 20ms is 1 tick, 1second = 1000ms = 50 ticks
            SpeedOfRefillingPerTick = (double)speedOfRefillingPerSecond / 50;

            FuelRemaining = 30000;
        }

        public void RefillFuelTank()
        {
            FuelTank.CurrentFullness += SpeedOfRefillingPerTick;
            FuelRemaining -= SpeedOfRefillingPerTick;
        }

        public void ReturnFuelFromFuelTank(double fuelSurplus)
        {
            FuelTank.CurrentFullness = FuelTank.Volume;
            FuelRemaining += fuelSurplus;
        }
    }
}
