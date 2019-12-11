namespace GasStationMs.App.Models
{
    public static class Topology
    {
        public static readonly double ServiceAreaInShare = 0.25;

        #region константы размера
        public static readonly int MinNumOfCellsHorizontally = 10;
        public static readonly int MaxNumOfCellsHorizontally = 35;

        public static readonly int MinNumOfCellsVertically = 7;
        public static readonly int MaxNumOfCellsVertically = 25;
        #endregion

        #region константы кол-ва ШЭ
        public static readonly int MinAndMaxNumOfAdjacentRoads = 1;

        public static readonly int MinAndMaxNumOfEntries = 1;

        public static readonly int MinAndMaxNumOfExits = 1;

        public static readonly int MinAndMaxNumOfCashboxes = 1;

        public static readonly int MinNumberOfFuelTanks = 1;
        public static int MaxNumberOfFuelTanks
        {
            get
            {
                return (int)(MaxNumOfCellsHorizontally * MaxNumOfCellsVertically * ServiceAreaInShare);
            }
        }
        #endregion
    }
}
