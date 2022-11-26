using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GasStationMs.Dal.Entities;

namespace GasStationMs.Dal.PresetData
{
    internal class FuelPreset
    {
        internal static IEnumerable<Fuel> GetPresetFuels()
        {
            int id = 1;
            return new List<Fuel>()
            {
                new Fuel() {Id = id++, Name = "АИ-92", Price = 42.30},
                new Fuel() {Id = id++, Name = "АИ-92+", Price = 43.30},
                new Fuel() { Id = id++, Name = "АИ-95", Price = 45.90 },
                new Fuel() { Id = id++, Name = "АИ-95+", Price = 46.90 },
                new Fuel() { Id = id++, Name = "АИ-98", Price = 48.10 },
                new Fuel() { Id = id++, Name = "АИ-100", Price = 51.80 },
                new Fuel() { Id = id++, Name = "ДТ", Price = 46.30},
                new Fuel() { Id = id++, Name = "Пропан", Price = 20.90}
            };
        }
    }
}
