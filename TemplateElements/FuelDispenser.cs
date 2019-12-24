using System;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class FuelDispenser : IGasStationElement
    {
        #region статика
        #region изображение
        private static Bitmap _image;

        public static Bitmap Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
                Icon = Icon.FromHandle(_image.GetHicon());
            }
        }

        public static Icon Icon { get; private set; }
        #endregion /изображение

        public static readonly int MinFuelFeedRateInLitersPerMinute = 25;
        public static readonly int MaxFuelFeedRateInLitersPerMinute = 160;
        #endregion /статика

        private int _fuelFeedRateInLitersPerMinute = 25;

        public FuelDispenser()
        {
            _fuelFeedRateInLitersPerMinute = MinFuelFeedRateInLitersPerMinute;
        }

        public int FuelFeedRateInLitersPerMinute
        {
            get
            {
                return _fuelFeedRateInLitersPerMinute;
            }

            set
            {
                if (value < MinFuelFeedRateInLitersPerMinute)
                    throw new ArgumentOutOfRangeException();

                _fuelFeedRateInLitersPerMinute = value;
            }
        }

        public override string ToString()
        {
            return
                 "ТРК: ";
        }
    }
}
