namespace GasStationMs.App.Modeling.Models
{
    public class FuelDispenserView
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int SpeedOfFilling { get; set; }
        public bool IsBusy { get; set; }

        public FuelDispenserView(string name, int speedOfFilling)
        {
            Name = name;
            SpeedOfFilling = speedOfFilling;
            IsBusy = false;
        }
    }
}
