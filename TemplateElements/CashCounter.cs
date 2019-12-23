using System;
using System.Drawing;

namespace GasStationMs.App.Elements
{
    [Serializable()]
    public class CashCounter : IGasStationElement
    {
        #region
        public static Bitmap Image { get; set; }

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
