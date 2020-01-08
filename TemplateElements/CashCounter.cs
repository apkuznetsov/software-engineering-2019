using System;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class CashCounter : IGasStationElement
    {
        #region статика
        public static Bitmap Image { get; set; }

        public static readonly int MinPricePerLiterOfFuelInRubles = 10;
        public static readonly int MaxPricePerLiterOfFuelInRubles = 100;

        public static readonly int CashLimitInRubles = 100000;
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
                    throw new ArgumentOutOfRangeException();

                if (moneyInRubles > CashLimitInRubles)
                    throw new ArgumentOutOfRangeException();

                moneyInRubles = value;
            }
        }

        public override string ToString()
        {
            return "Касса";
        }
    }
}
