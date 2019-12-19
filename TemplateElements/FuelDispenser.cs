using System;
using System.Drawing;

namespace GasStationMs.App.Elements
{
    [Serializable()]
    public class FuelDispenser : IGasStationElement
    {
        #region статика
        #region изображение
        private static Bitmap image;

        public static Bitmap Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                Icon = Icon.FromHandle(image.GetHicon());
            }
        }

        public static Icon Icon { get; private set; }
        #endregion /изображение

        public static readonly int MinFuelFeedRateInLitersPerMinute = 25;
        public static readonly int MaxFuelFeedRateInLitersPerMinute = 160;
        #endregion /статика
        
        public override string ToString()
        {
            return
                 "ТРК: ";
        }
    }
}
