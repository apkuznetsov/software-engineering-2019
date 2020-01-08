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
                if (moneyInRubles < MinCashInRubles)
                    throw new ArgumentOutOfRangeException();

                if (moneyInRubles > MaxCashInRubles)
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
