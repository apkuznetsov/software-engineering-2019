namespace GasStationMs.App.Models
{
    public static class Topology
    {
        public static readonly int MinNumOfCellsHorizontally = 10;
        public static readonly int MaxNumOfCellsHorizontally = 35;

        public static readonly int MinNumOfCellsVertically = 7;
        public static readonly int MaxNumOfCellsVertically = 25;

        public static readonly int ServiceAreaInPercent = 25;

        public static readonly int MinNumberOfFuelTanks = 1;
        // В РАЗРАБОТКЕ, НЕ УДАЛЯТЬ: public static readonly int MaxNumberOfFuelTanks = не более размера служебной области

        public static readonly int NumberOfEntries = 1;
        public static readonly int NumberOfExits = 1;
        public static readonly int NumberOfAdjacentRoads = 1;
        public static readonly int NumberOfCashboxes = 1;
    }
}
