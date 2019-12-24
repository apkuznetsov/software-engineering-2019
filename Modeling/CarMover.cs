using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Modeling.Models;
using static GasStationMs.App.Modeling.CarRouter;
using static GasStationMs.App.Modeling.DestinationPointsDefiner;

namespace GasStationMs.App.Modeling
{
    internal static class CarMover
    {
        private static ModelingForm _modelingForm;
        private static ModelingProcessor _modelingProcessor;

        private static int _carSpeedFilling = 3;
        private static int _carSpeedNoFilling = 4;

        internal static void  SetUpCarMover(ModelingForm modelingForm, ModelingProcessor modelingProcessor)
        {
            _modelingForm = modelingForm;
            _modelingProcessor = modelingProcessor;
        }

        internal static void MoveCarToDestination(PictureBox car)
        {
            var carView = (CarView)car.Tag;

            if (carView.IsFilling)
            {
                var chosenFuelDispenser = (FuelDispenserView)carView.ChosenFuelDispenser.Tag;

                _modelingProcessor.FillCar(carView, chosenFuelDispenser);

                return;
            }

            var destPoint = carView.GetDestinationPoint();
            PictureBox destSpot = carView.DestinationSpot;

            var carSpeed = carView.IsGoesFilling ? _carSpeedFilling : _carSpeedNoFilling;

            #region MotionLogic

            destPoint = MoveCar(car, destPoint, carSpeed);

            #endregion /MotionLogic


            if (carView.DestinationSpot == null)
            {
                destSpot = carView.CreateDestinationSpot(destPoint);
                _modelingForm.PlaygroundPanel.Controls.Add(destSpot);
            }

            if (car.Bounds.IntersectsWith(destSpot.Bounds))
            {
                carView.RemoveDestinationPoint(_modelingForm);

                carView.IsBypassingObject = false;
                //_isGoHorizontal = false;
                //_isGoVertical = false;

                if (destPoint.Equals(EnterPoint3))
                {
                    carView.IsOnStation = true;
                }


                foreach (var fuelDispensersDestPoint in FuelDispensersDestPoints.Values)
                {
                    if (destPoint.Equals(fuelDispensersDestPoint))
                    {
                        _modelingProcessor.StartFilling(car, carView.ChosenFuelDispenser);
                        //test
                        //carView.IsFilled = true;
                    }
                }

                if (destPoint.Equals(ExitPoint1))
                {
                    carView.IsOnStation = false;
                }

                if (destPoint.Equals(LeavePointNoFilling) || destPoint.Equals(LeavePointFilled))
                {
                    _modelingForm.PlaygroundPanel.Controls.Remove(car);
                    car.Dispose();
                }
            }
        }

        internal static Point MoveCar(PictureBox car, Point destPoint, int carSpeed)
        {
            var isHorizontalMoving = false;
            var isVerticalMoving = false;
            var carView = (CarView)car.Tag;
            if (!carView.IsBypassingObject)
            {
                if (!carView.IsFilled)
                {
                    // Go Up
                    if (car.Top >= destPoint.Y && !isHorizontalMoving)
                    {
                        car.Top -= carSpeed;
                        //car.Image = Properties.Resources.car_32x17__up;
                        isVerticalMoving = true;
                        destPoint = PreventIntersection(car, DirectionEnum.Direction.Up);
                    }

                    // Go Down
                    if (car.Bottom <= destPoint.Y && !isHorizontalMoving)
                    {
                        car.Top += carSpeed;
                        //car.Image = Properties.Resources.car_64x34__down;
                        isVerticalMoving = true;
                        destPoint = PreventIntersection(car, DirectionEnum.Direction.Down);
                    }

                    // Go left
                    if (car.Left >= destPoint.X && !isVerticalMoving)
                    {
                        car.Left -= carSpeed;
                        //car.Image = Properties.Resources.car_32x17__left;
                        destPoint = PreventIntersection(car, DirectionEnum.Direction.Left);
                    }

                    // Go Right
                    if (car.Right <= destPoint.X && !isVerticalMoving)
                    {
                        car.Left += carSpeed;
                        //car.Image = Properties.Resources.car_32x17__right;
                    }
                }
                else
                {
                    // Go left
                    if (car.Left >= destPoint.X)
                    {
                        car.Left -= carSpeed;
                        //car.Image = Properties.Resources.car_32x17__left;
                        isHorizontalMoving = true;
                        destPoint = PreventIntersection(car, DirectionEnum.Direction.Left);
                    }

                    // Go Right
                    if (car.Right <= destPoint.X)
                    {
                        car.Left += carSpeed;
                        //car.Image = Properties.Resources.car_32x17__right;
                        isHorizontalMoving = true;
                    }

                    // Go Up
                    if (car.Top >= destPoint.Y && !isHorizontalMoving)
                    {
                        car.Top -= carSpeed;
                        //car.Image = Properties.Resources.car_32x17__up;
                        destPoint = PreventIntersection(car, DirectionEnum.Direction.Up);
                    }

                    // Go Down
                    if (car.Bottom <= destPoint.Y && !isHorizontalMoving)
                    {
                        car.Top += carSpeed;
                        //car.Image = Properties.Resources.car_32x17__down;
                        destPoint = PreventIntersection(car, DirectionEnum.Direction.Down);
                    }
                }
            }
            else
            {
                // Go left
                if (car.Left >= destPoint.X)
                {
                    car.Left -= carSpeed;
                    //car.Image = Properties.Resources.car_32x17__left;
                    destPoint = PreventIntersection(car, DirectionEnum.Direction.Left);
                }

                // Go Right
                if (car.Right <= destPoint.X)
                {
                    car.Left += carSpeed;
                    //car.Image = Properties.Resources.car_32x17__right;
                }

                // Go Up
                if (car.Top >= destPoint.Y)
                {
                    car.Top -= carSpeed;
                    //car.Image = Properties.Resources.car_32x17__up;
                    destPoint = PreventIntersection(car, DirectionEnum.Direction.Up);
                }

                // Go Down
                if (car.Bottom <= destPoint.Y)
                {
                    car.Top += carSpeed;
                    //car.Image = Properties.Resources.car_32x17__down;

                    destPoint = PreventIntersection(car, DirectionEnum.Direction.Down);
                }
            }

            return destPoint;
        }

        internal static void SetCarSpeed(int carSpeedFilling, int carSpeedNoFilling)
        {
            _carSpeedFilling = carSpeedFilling;
            _carSpeedNoFilling = carSpeedNoFilling;
        }
    }
}
