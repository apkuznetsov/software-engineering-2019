using System;
using System.Collections.Generic;
using System.Text;

namespace GasStationMs.CommonLayer.Dto
{
    class CarDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int TankVolume { get; set; }
        public bool IsTruck { get; set; }
        public string FuelTypeName { get; set; }
    }
}
