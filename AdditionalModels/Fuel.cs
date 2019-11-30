namespace software_engineering_2019.AdditionalModels
{
    public class Fuel
    {
        private string name;

        public Fuel(string name)
        {
            this.name = name;
        }

        public string FuelType
        {
            get
            {
                return name;
            }
        }
    }
}
