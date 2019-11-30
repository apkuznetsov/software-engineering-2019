using System;

namespace GasStationMs.App.Models
{
    public class Cashbox
    {
        public static readonly int MinPricePerLiterOfFuelInRubles = 10;
        public static readonly int MaxPricePerLiterOfFuelInRubles = 100;

        public static readonly int CashLimitInRubles = 100000;

        private int _moneyInCashInRubles;

        public int MoneyInCashInRubles
        {
            get
            {
                return _moneyInCashInRubles;
            }

            set
            {
                if (_moneyInCashInRubles < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (_moneyInCashInRubles > CashLimitInRubles)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _moneyInCashInRubles = value;
            }
        }
    }
}
