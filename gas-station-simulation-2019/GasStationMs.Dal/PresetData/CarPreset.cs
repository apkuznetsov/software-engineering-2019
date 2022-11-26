using System;
using System.Collections.Generic;
using System.Text;
using GasStationMs.Dal.Entities;

namespace GasStationMs.Dal.PresetData
{
    class CarPreset
    {
        public static IEnumerable<Car> GetPresetCars()
        {
            int id = 1;
            Random r = new Random();

            return new List<Car>()
            {
                new Car {Id = id++, Name = "Ford Focus", TankVolume = 90, FuelTypeId = r.Next(1, 9), IsTruck = false}
            };
        }
    }
}
