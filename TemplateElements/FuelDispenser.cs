using System.Drawing;

namespace GasStationMs.App.Models
{ 
    public class FuelDispenser
    {
        public static readonly int MinNumb = 1;
        public static readonly int MaxNumb = 6;

        public static readonly int MinFuelFeedRateInLitersPerMinute = 25;
        public static readonly int MaxFuelFeedRateInLitersPerMinute = 160;
        
        static Bitmap bm = new Bitmap(Properties.Resources.fuel, Settings.CellSizeInPx, Settings.CellSizeInPx);
        public static Icon icon = Icon.FromHandle(bm.GetHicon());
    }
}
