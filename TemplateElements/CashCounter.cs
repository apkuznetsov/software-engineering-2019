using System;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class CashCounter : IGasStationElement
    {
        #region статика
        public static Bitmap Image { get; set; }

        public static readonly int MinCashInRubles = 0;
        public static readonly int MaxCashInRubles = 100000;

        public static readonly int MinPricePerLiterOfFuelInRubles = 10;
        public static readonly int MaxPricePerLiterOfFuelInRubles = 100;
        #endregion /статика

        private int cashInRubles;

        public int CashInRubles
        {
            get
            {
                return cashInRubles;
            }

            set
            {
                if (cashInRubles < MinCashInRubles)
                    throw new ArgumentOutOfRangeException();

                if (cashInRubles > MaxCashInRubles)
                    throw new ArgumentOutOfRangeException();

                cashInRubles = value;
            }
        }

        public override string ToString()
        {
            return "Касса";
        }
    }
}
