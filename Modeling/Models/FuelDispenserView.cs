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

        public FuelTankView ChosenFuelTank{ get; set; }

        public FuelDispenserView(string name, int speedOfFillingPerSecond)
        {
            Name = name;
            SpeedOfFillingPerSecond = speedOfFillingPerSecond;
            // Since 20ms is 1 tick, 1second = 1000ms = 50 ticks
            SpeedOfFillingPerTick = (double) speedOfFillingPerSecond / 50; 
            IsBusy = false;
            CarsInQueue = 0;
        }
    }
}
