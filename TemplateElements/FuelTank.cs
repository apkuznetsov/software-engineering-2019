using System;
using System.Drawing;
using GasStationMs.App.AdditionalModels;

namespace GasStationMs.App.TemplateElements
{
    [Serializable()]
    public class FuelTank : IGasStationElement
    {
        #region статика
        public static Bitmap Image { get; set; }

        public static readonly int MinVolumeInLiters = 10000;
        public static readonly int MaxVolumeInLiters = 75000;
        public static readonly double CriticalVolumeForRefuelingInShares = 0.15;
        #endregion /статика

        private int _volume;
        private int _criticalVolume;
        private Fuel _fuel;
        private int _occupiedVolume;

        public FuelTank()
        {
            Volume = MinVolumeInLiters;
            _fuel = new Fuel("АИ-100");
        }

        public int Volume
        {
            get
            {
                return _volume;
            }

            set
            {
                if (value < MinVolumeInLiters)
                    throw new ArgumentOutOfRangeException();

                _volume = value;

                _criticalVolume = (int)(_volume * CriticalVolumeForRefuelingInShares);
            }
        }

        public int CriticalVolume
        {
            get
            {
                return _criticalVolume;
            }
        }

        public string Fuel
        {
            get
            {
                return _fuel.Name;
            }
            set
            {
                this._fuel = new Fuel(value);
            }
        }

        public int OccupiedVolume
        {
            get
            {
                return _occupiedVolume;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value > _volume)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _occupiedVolume = value;
            }
        }

        public override string ToString()
        {
            return "ТБ";
        }
    }
}
