using System;
using System.Collections.Generic;
using System.Text;

namespace GasStationMs.Dal.Entities
{
    public class Fuel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public ICollection<Car> Cars { get; set; }

        public Fuel()
        {
            Cars = new HashSet<Car>();
        }
    }
}
