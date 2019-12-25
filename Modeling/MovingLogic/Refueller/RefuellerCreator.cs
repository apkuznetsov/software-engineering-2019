using GasStationMs.App.Modeling.Models.Views;
using GasStationMs.App.TemplateElements;

namespace GasStationMs.App.Modeling.MovingLogic.Refueller
{
    internal static class RefuellerCreator
    {
        internal static void SpawnRefueller(FuelTankView fuelTank)
        {
            var refuellerView = ElementViewProducer.CreateRefuellerView(fuelTank);
            var refueller = ElementPictureBoxProducer.CreateRefuellerPictureBox(refuellerView);
        }
    }
}

