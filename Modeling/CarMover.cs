using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;
using GasStationMs.App.Modeling.Models.PictureBoxes;
using static GasStationMs.App.Modeling.CarRouter;
using static GasStationMs.App.Modeling.DestinationPointsDefiner;
using static GasStationMs.App.Modeling.ModelingProcessor;

namespace GasStationMs.App.Modeling
{
    internal static class CarMover
    {
        private static ModelingForm _modelingForm;

        private static int _carSpeedFilling = 3;
        private static int _carSpeedNoFilling = 4;

        internal static void  SetUpCarMover(ModelingForm modelingForm)
        {
            _modelingForm = modelingForm;
        }

        internal static void MoveCarToDestination(MoveablePictureBox car)
        {
            CarView carView  = null;
            CollectorView collectorView = null;

            if (car is CarPictureBox)
            {
                carView = car.Tag as CarView;
            }

            if (car is CollectorPictureBox)
            {
                collectorView = car.Tag as CollectorView;
            }

            if (car.IsFilling)
            {
                if (car is CarPictureBox carPictureBox)
                {
                    var chosenFuelDispenser = (FuelDispenserView)carView.ChosenFuelDispenser.Tag;

                    FillCar(carPictureBox, chosenFuelDispenser);

                    return;
                }

                if (car is CollectorPictureBox collector)
                {
                    var cashCounter = collectorView.CashCounter.Tag as CashCounterView;

                    CollectCash(collector, cashCounter);

                    return;
                }
            }

            var destPoint = car.GetDestinationPoint();
            PictureBox destSpot = car.DestinationSpot;

            var carSpeed = car.IsGoesFilling ? _carSpeedFilling : _carSpeedNoFilling;

            #region MotionLogic

            destPoint = MoveCar(car, destPoint, carSpeed);

            #endregion /MotionLogic


            if (car.DestinationSpot == null)
            {
                destSpot = car.CreateDestinationSpot(destPoint);
                _modelingForm.PlaygroundPanel.Controls.Add(destSpot);
            }

            if (car.Bounds.IntersectsWith(destSpot.Bounds))
            {
                car.RemoveDestinationPoint(_modelingForm);

                car.IsBypassingObject = false;
                //_isGoHorizontal = false;
                //_isGoVertical = false;

                if (destPoint.Equals(EnterPoint3))
                {
                    car.IsOnStation = true;
                }

                if (car is CarPictureBox carPictureBox)
                {
                    foreach (var fuelDispensersDestPoint in FuelDispensersDestPoints.Values)
                    {
                        if (destPoint.Equals(fuelDispensersDestPoint))
                        {
                            StartFilling(carPictureBox, carView.ChosenFuelDispenser);
                            //test
                            //carView.IsFilled = true;
                        }
                    }
                }

                if (car is CollectorPictureBox collector)
                {
                    if (destPoint.Equals(DestinationPointsDefiner.CashCounter))
                    {
                        StartCollectingCash(collector, collectorView.CashCounter.Tag as CashCounterView);
                        return;
                    }
                }
               

                if (destPoint.Equals(ExitPoint1))
                {
                    car.IsOnStation = false;
                }

                if (destPoint.Equals(LeavePointNoFilling) || destPoint.Equals(LeavePointFilled))
                {
                    _modelingForm.PlaygroundPanel.Controls.Remove(car);
                    car.Dispose();
                }
            }
        }

        internal static Point MoveCar(MoveablePictureBox car, Point destPoint, int carSpeed)
        {
            var isHorizontalMoving = false;
            var isVerticalMoving = false;

            if (!car.IsBypassingObject)
            {
                if (!car.IsFilled)
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
