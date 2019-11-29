namespace software_engineering_2019.Models
{
    public class FuelTank
    {
        public static readonly int MinVolumeInLiters = 10000;
        public static readonly int MaxVolumeInLiters = 75000;

        public static readonly int CriticalVolumeForRefuelingInPercent = 15;
    }
}
