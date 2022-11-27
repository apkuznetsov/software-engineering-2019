using System.Windows.Forms;

namespace GasStationMs.App.Modeling.Models.Views
{
    internal class CollectorView
    {
        public double TakenCashVolume { get; private set; }
        public int SpeedOfCashCollectingPerSecond { get; }
        public double SpeedOfCashCollectingPerTick { get; }
        public bool IsGoesToCashCounter { get; set; }
        public PictureBox CashCounter { get; set; }

        public CollectorView(int speedOfCashCollectingPerSecond)
        {
            SpeedOfCashCollectingPerSecond = speedOfCashCollectingPerSecond;
            // Since 20ms is 1 tick, 1second = 1000ms = 50 ticks
            SpeedOfCashCollectingPerTick = (double)speedOfCashCollectingPerSecond / 50;
        }

        public double GetCashFromCashCounter()
        {
            var cashCounterView = CashCounter.Tag as CashCounterView;
            cashCounterView.CurrentCashVolume -= SpeedOfCashCollectingPerTick;
            TakenCashVolume += SpeedOfCashCollectingPerTick;

            return SpeedOfCashCollectingPerTick;
        }

        public void ReturnCashToCashCounter(double cashSurplus)
        {
            var cashCounterView = CashCounter.Tag as CashCounterView;
            cashCounterView.CurrentCashVolume += cashSurplus;
            TakenCashVolume -= cashSurplus;
        }
    }
}
