namespace GasStationMs.App.Modeling.Models.Views
{
    public class CashCounterView
    {
        private const int WhenDrawMoneyInPercentage = 90;
        public string Name { get; set; }
        public int MaxCashVolume { get; }
        public double CurrentCashVolume { get; set; }
        public bool IsFull => CurrentCashVolume > ((double)MaxCashVolume / 100) * WhenDrawMoneyInPercentage;

        public CashCounterView(string name, int maxCashVolume)
        {
            Name = name;
            MaxCashVolume = maxCashVolume;
            CurrentCashVolume = 0;
        }
    }
}