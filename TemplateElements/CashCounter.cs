using System;
using System.Drawing;

namespace GasStationMs.App.TemplateElements
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


        private int _moneyInRubles;

        public int MoneyInCashInRubles
        {
            get
            {
                return _moneyInRubles;
            }

            set
            {
                if (_moneyInRubles < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (_moneyInRubles > CashLimitInRubles)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _moneyInRubles = value;
            }
        }

        public override string ToString()
        {
            return "Касса";
        }
    }
}
