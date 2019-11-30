using System;
using System.Collections.Generic;
using System.Text;

namespace GasStationMs.Dal.Entities
{
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TankVolume { get; set; }
        public bool IsTruck { get; set; }

        public int? FuelTypeId { get; set; }
        public Fuel FuelType { get; set; }
    }
}
