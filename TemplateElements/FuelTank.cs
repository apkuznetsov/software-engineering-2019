using System;
using GasStationMs.App.AdditionalModels;
using System.Drawing;
using System.Text;

namespace GasStationMs.App.Models
{
    public class FuelTank
    {
        public static readonly int MinVolumeInLiters = 10000;
        public static readonly int MaxVolumeInLiters = 75000;
        public static readonly double CriticalVolumeForRefuelingInShares = 0.15;

        static Bitmap bm = new Bitmap(Properties.Resources.FuelTank, Settings.CellSizeInPx, Settings.CellSizeInPx);
        public static Icon icon = Icon.FromHandle(bm.GetHicon());

        private int volume;
        private int criticalVolume;
        private Fuel fuel;
        private int occupiedVolume;

        public int Volume { get; }

        public int CriticalVolume { get; }

        public string Fuel
        {
            get
            {
                return fuel.Type;
            }
        }

        public int OccupiedVolume
        {
            get
            {
                return occupiedVolume;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > volume)
                {
                    throw new ArgumentOutOfRangeException();
                }
                occupiedVolume = value;
            }
        }

        public override string ToString()
        {
            string nl = Environment.NewLine;

            return
                 "Объём: " + volume + nl +
                 "Текущий объём: " + occupiedVolume + nl +
                 "Топливо: " + fuel;
        }
    }
}
