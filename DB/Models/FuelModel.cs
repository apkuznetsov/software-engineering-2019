namespace GasStationMs.App
{
    public class FuelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public FuelModel(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public FuelModel(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ":  " + Price + "р.";
        }

        public override bool Equals(object obj)
        {
            return obj is FuelModel fuelModel && (Name.Equals(fuelModel.Name) && Price.Equals(fuelModel.Price));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
