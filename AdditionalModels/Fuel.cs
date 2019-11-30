namespace GasStationMs.App.AdditionalModels
{
    public class Fuel
    {
        private string name;

        public Fuel(string name)
        {
            this.name = name;
        }

        public string Type
        {
            get
            {
                return name;
            }
        }
    }
}
