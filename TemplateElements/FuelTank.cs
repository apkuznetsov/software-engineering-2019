﻿using System;
using GasStationMs.App.AdditionalModels;
using System.Drawing;

namespace GasStationMs.App.Elements
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

        private int volume;
        private int criticalVolume;
        private Fuel fuel;
        private int occupiedVolume;

        public FuelTank()
        {
            Volume = MinVolumeInLiters;
            fuel = new Fuel("АИ-100");
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

                volume = value;

                criticalVolume = (int)(volume * CriticalVolumeForRefuelingInShares);
            }
        }

        public int CriticalVolume
        {
            get
            {
                return criticalVolume;
            }
        }

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
            return "ТБ";
        }
    }
}
