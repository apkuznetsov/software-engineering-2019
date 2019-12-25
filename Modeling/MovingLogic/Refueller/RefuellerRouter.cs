using GasStationMs.App.Modeling.Models.PictureBoxes;
using GasStationMs.App.Modeling.Models.Views;
using System.Drawing;
using static GasStationMs.App.Modeling.MovingLogic.DestinationPointsDefiner;
using static GasStationMs.App.Modeling.ElementSizeDefiner;

namespace GasStationMs.App.Modeling.MovingLogic.Refueller
{
    internal static class RefuellerRouter
    {
        internal static void RouteRefueller(RefuellerPictureBox refueller)
        {
            var isFilled = refueller.IsFilled;

            if (refueller.IsFilling || refueller.HasDestPoints())
            {
                return;
            }

            if (!isFilled)
            {
                GoToFuelTank(refueller);
            }
            else
            {
                LeaveServiceArea(refueller);
            }
        }

        private static void GoToFuelTank(RefuellerPictureBox refueller)
        {
            var fuelTank = ((RefuellerView)refueller.Tag).FuelTank;
            var pointOfFilling = fuelTank.PointOfRefilling;

            var destPointX = pointOfFilling.X;
            var destPointY = pointOfFilling.Y;
            var destPoint = new Point(destPointX, destPointY);

            // The main point of fueling
            refueller.AddDestinationPoint(destPoint);

            // Service area enter point
            destPoint = new Point(destPointX, RefuellerSpawnPoint.Y);
            refueller.AddDestinationPoint(destPoint);
        }

        private static void LeaveServiceArea(RefuellerPictureBox refueller)
        {
            var destPointY = -(2 * RefuellerHeight);
            var destPoint = new Point(refueller.Left + FuelingPointDeltaX, destPointY);

            refueller.AddDestinationPoint(destPoint);
        }
    }
}
