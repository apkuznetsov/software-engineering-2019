using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models.PictureBoxes;
using GasStationMs.App.Modeling.Models.Views;
using System.Drawing;
using System.Windows.Forms;

namespace GasStationMs.App.Modeling.MovingLogic.Refueller
{
    internal static class RefuellerMover
    {
        private static ModelingForm _modelingForm;

        private static int _refuellerSpeed = 2;

        internal static void SetUpRefuellerMover(ModelingForm modelingForm)
        {
            _modelingForm = modelingForm;
        }

        internal static void MoveRefuellerToDestination(RefuellerPictureBox refueller)
        {
            var refuellerView = refueller.Tag as RefuellerView;

            if (refueller.IsFilling)
            {
                var fillingFuelTank = refuellerView.FuelTank;

                ModelingProcessor.RefillFuelTank(refueller, fillingFuelTank);

                return;
            }

            var destPoint = refueller.GetDestinationPoint();
            PictureBox destSpot = refueller.DestinationSpot;

            var refuellerSpeed = _refuellerSpeed;

            #region MotionLogic

            destPoint = MoveRefueller(refueller, destPoint, refuellerSpeed);

            #endregion /MotionLogic


            if (refueller.DestinationSpot == null)
            {
                destSpot = refueller.CreateDestinationSpot(destPoint);
                _modelingForm.PlaygroundPanel.Controls.Add(destSpot);
            }

            if (refueller.Bounds.IntersectsWith(destSpot.Bounds))
            {
                refueller.RemoveDestinationPoint(_modelingForm);

                var fuelTank = ((RefuellerView)refueller.Tag).FuelTank;
                var pointOfFilling = fuelTank.PointOfRefilling;

                if (destPoint.Equals(pointOfFilling))
                {
                    ModelingProcessor.StartRefilling(refueller, fuelTank);
                    //test
                    //carView.IsFilled = true;
                }


                if (refueller.Bottom < -(2 * ElementSizeDefiner.RefuellerHeight))
                {
                    _modelingForm.PlaygroundPanel.Controls.Remove(refueller);
                    refueller.Dispose();
                }
            }
        }

        internal static Point MoveRefueller(RefuellerPictureBox refueller, Point destPoint, int refuellerSpeed)
        {
            // Go left
            if (refueller.Left >= destPoint.X)
            {
                refueller.Left -= refuellerSpeed;
            }

            // Go Right
            if (refueller.Right <= destPoint.X)
            {
                refueller.Left += refuellerSpeed;
            }

            // Go Up
            if (refueller.Top >= destPoint.Y)
            {
                refueller.Top -= refuellerSpeed;
            }

            // Go Down
            if (refueller.Bottom <= destPoint.Y)
            {
                refueller.Top += refuellerSpeed;

            }

            return destPoint;
        }

        internal static void SetRefuellerSpeed(int refuellerSpeed)
        {
            _refuellerSpeed = refuellerSpeed;
        }
    }
}
