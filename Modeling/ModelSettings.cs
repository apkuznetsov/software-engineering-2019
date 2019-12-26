using System.Collections.Generic;
using GasStationMs.App.DB.Models;
using GasStationMs.App.DistributionLaws;

namespace GasStationMs.App.Modeling
{
    internal static class ModelSettings
    {
        internal static List<FuelModel> Fuels { get;} = new List<FuelModel>();
        internal static IDistributionLaw TimeBetweenCarsGenerator { get; set; }

        internal static void AddUniqueFuel(FuelModel fuel)
        {
            if (!Fuels.Contains(fuel))
            {
                Fuels.Add(fuel);
            }
        }
    }
}
