namespace GasStationMs.App
{
    public class FuelView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public FuelView(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public FuelView(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ":  " + Price + "р.";
        }
    }
}
