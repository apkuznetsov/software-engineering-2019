using System;

namespace GasStationMs.App.AdditionalModels
{
    [Serializable()]
    public class Fuel
    {
        public Fuel(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
