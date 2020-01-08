using System;
using System.Drawing;
using GasStationMs.App.DB.Models;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class FuelTank : IGasStationElement
    {
        #region статика
        public static Bitmap Image { get; set; }

        public static readonly int MinVolumeInLiters = 10000;
        public static readonly int MaxVolumeInLiters = 75000;

        public static readonly int MinOccupiedVolumeInLiters = 0;

        public static readonly double CriticalVolumeForRefuelingInShares = 0.15;
        #endregion /статика

        private int volume;
        private int occupiedVolume;

        public FuelModel Fuel { get; set; }

        public int CriticalVolume { get; private set; }

        public FuelTank()
        {
            Volume = MinVolumeInLiters;
            occupiedVolume = volume;
            Fuel = new FuelModel(-1, "АИ-92               ", 42.3);
        }

        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if (value < MinVolumeInLiters)
                    throw new ArgumentOutOfRangeException();

                if (value > MaxVolumeInLiters)
                    throw new ArgumentOutOfRangeException();

                volume = value;

                CriticalVolume = (int)(volume * CriticalVolumeForRefuelingInShares);
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
                if (value < MinOccupiedVolumeInLiters)
                    throw new ArgumentOutOfRangeException();

                if (value > volume)
                    throw new ArgumentOutOfRangeException();

                occupiedVolume = value;
            }
        }

        public override string ToString()
        {
            return "ТБ";
        }
    }
}
