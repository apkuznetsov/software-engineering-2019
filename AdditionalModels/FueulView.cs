namespace GasStationMs.Dal
{
    public class FuelView
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public FuelView(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ":  " + Price + "р.";
        }
    }
}
