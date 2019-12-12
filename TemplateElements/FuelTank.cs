using System;
using GasStationMs.App.AdditionalModels;
using System.Drawing;

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

        public FuelTank(int volume, Fuel fuel)
        {
            if (volume < MinVolumeInLiters)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (volume > MaxVolumeInLiters)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.volume = volume;

            this.fuel = fuel;

            this.criticalVolume = (int)Math.Ceiling(this.volume * CriticalVolumeForRefuelingInShares);
            this.occupiedVolume = 0;
        }

        public FuelTank(int volume, Fuel fuel, int occupiedVolume)
        {
            if (volume < MinVolumeInLiters)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (volume > MaxVolumeInLiters)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.volume = volume;

            this.criticalVolume = (int)Math.Ceiling(this.volume * CriticalVolumeForRefuelingInShares);

            this.fuel = fuel;

            if (occupiedVolume < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (occupiedVolume > volume)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.occupiedVolume = occupiedVolume;
        }

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
    }
}
