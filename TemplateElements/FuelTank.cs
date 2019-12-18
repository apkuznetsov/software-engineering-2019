using System;
using GasStationMs.App.AdditionalModels;
using System.Drawing;

namespace GasStationMs.App.Elements
{
    [Serializable()]
    public class FuelTank : IGasStationElement
    {

        #region изображение
        private static Bitmap image;

        public static Bitmap Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                Icon = Icon.FromHandle(image.GetHicon());
            }
        }

        public static Icon Icon { get; private set; }
        #endregion /изображение


        public static readonly int MinVolumeInLiters = 10000;
        public static readonly int MaxVolumeInLiters = 75000;
        public static readonly double CriticalVolumeForRefuelingInShares = 0.15;

        private int volume;
        private int criticalVolume;
        private Fuel fuel;
        private int occupiedVolume;

        public FuelTank()
        {
            Volume = MinVolumeInLiters;
            fuel = new Fuel("АИ-100");
        }

        public int Volume { get; set; }

        public int CriticalVolume { get; }

        public string Fuel
        {
            get
            {
                return fuel.Name;
            }
            set
            {
                this.fuel = new Fuel(value);
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

            return "Топливный бак: ";
            // "Объём: " + volume + nl +
            //  "Текущий объём: " + occupiedVolume + nl +
            //   "Топливо: " + fuel;
        }
    }
}
