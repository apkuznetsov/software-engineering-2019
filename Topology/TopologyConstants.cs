namespace GasStationMs.App.Topology
{
    public partial class Topology
    {
        #region константы размера
        public static readonly int MinColsCount = 10;
        public static readonly int MaxColsCount = 20;

        public static readonly int MinRowsCount = 7;
        public static readonly int MaxRowsCount = 13;

        public static readonly double ServiceAreaInShares = 0.25;
        #endregion

        #region константы кол-ва ШЭ
        public static readonly int MinFuelDispensersCount = 1;
        public static readonly int MaxFuelDispensersCount = 6;

        public static readonly int MinFuelTanksCount = 1;
        public static readonly int MaxFuelTanksCount =
            (int)(MaxColsCount * MaxRowsCount * ServiceAreaInShares);

        public static readonly int MinCashCountersCount = 1;
        public static readonly int MaxCashCountersCount = 1;

        public static readonly int MinEntriesCount = 1;
        public static readonly int MaxEntriesCount = 1;

        public static readonly int MinExitsCount = 1;
        public static readonly int MaxExitsCount = 1;
        #endregion
    }
}
