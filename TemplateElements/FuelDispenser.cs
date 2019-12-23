using System;
using System.Drawing;

namespace GasStationMs.App.Elements
{
    [Serializable()]
    public class FuelDispenser : IGasStationElement
    {
        #region статика
        public static Bitmap Image { get; set; }

        public static readonly int MinFuelFeedRateInLitersPerMinute = 25;
        public static readonly int MaxFuelFeedRateInLitersPerMinute = 160;
        #endregion /статика

        private int fuelFeedRateInLitersPerMinute = 25;

        public FuelDispenser()
        {
            fuelFeedRateInLitersPerMinute = MinFuelFeedRateInLitersPerMinute;
        }

        public int FuelFeedRateInLitersPerMinute
        {
            get
            {
                return fuelFeedRateInLitersPerMinute;
            }

            set
            {
                if (value < MinFuelFeedRateInLitersPerMinute)
                    throw new ArgumentOutOfRangeException();

                fuelFeedRateInLitersPerMinute = value;
            }
        }

        public override string ToString()
        {
            return "ТРК";
        }
    }
}
