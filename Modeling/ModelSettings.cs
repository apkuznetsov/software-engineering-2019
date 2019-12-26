using System.Collections.Generic;
using GasStationMs.App.DB.Models;
using GasStationMs.App.Models;

namespace GasStationMs.App.Modeling
{
    internal static class ModelSettings
    {
        internal static List<FuelModel> Fuels { get; private set; } 

        internal static void SetUpModelSettings(TrafficFlow trafficFlow)
        {
            TrafficFlow = trafficFlow;
            Fuels = new List<FuelModel>();

            // test
            //Fuels.Add(new FuelModel(1, "АИ-92", 42.9));
            // /test
        }

        internal static TrafficFlow TrafficFlow { get; set; }

        internal static void AddUniqueFuel(FuelModel fuel)
        {
            if (!Fuels.Contains(fuel))
            {
                Fuels.Add(fuel);
            }
        }
    }
}
