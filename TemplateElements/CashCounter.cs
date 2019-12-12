using System;
using System.Drawing;

namespace GasStationMs.App.Models
{
    public class CashCounter
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

        public static readonly int CashLimitInRubles = 100000;

        public static readonly int MinPricePerLiterOfFuelInRubles = 10;
        public static readonly int MaxPricePerLiterOfFuelInRubles = 100;
        #endregion /статика


        private int moneyInRubles;

        public int MoneyInCashInRubles
        {
            get
            {
                return moneyInRubles;
            }

            set
            {
                if (moneyInRubles < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (moneyInRubles > CashLimitInRubles)
                {
                    throw new ArgumentOutOfRangeException();
                }

                moneyInRubles = value;
            }
        }
    }
}
