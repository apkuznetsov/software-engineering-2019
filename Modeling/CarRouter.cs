using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;
using static GasStationMs.App.Modeling.DestinationPointsDefiner;
using static GasStationMs.App.Modeling.DirectionEnum;
using static GasStationMs.App.Modeling.ElementSizeDefiner;

namespace GasStationMs.App.Modeling
{
    internal static class CarRouter
    {
        private static ModelingForm _modelingForm;

        internal static void SetUpCarRouter(ModelingForm modelingForm)
        {
            _modelingForm = modelingForm;
        }

        internal static void RouteCar(PictureBox car)
        {
            var carView = (CarView) car.Tag;

            if (!carView.IsGoesFilling)
            {
                return;
            }

            var isOnStation = carView.IsOnStation;
            var isFilled = carView.IsFilled;
            var isFuelDispenserChosen = carView.IsFuelDispenserChosen;

            // New car
            if (!isOnStation && !isFilled && !carView.HasDestPoints())
            {
                GoToEnter(carView);
            }

            // Just entered the station
            if (isOnStation && !isFuelDispenserChosen)
            {
                ChooseFuelDispenser(carView);
            }

            // After filling 
            if (isOnStation && isFilled)
            {
                GoToExit(carView);
                carView.IsOnStation = false;
            }
        }


        private static void ChooseFuelDispenser(CarView car)
        {
            PictureBox optimalFuelDispenser = ModelingProcessor.FuelDispensersList[0];
            FuelDispenserView fuelDispenserView = (FuelDispenserView) optimalFuelDispenser.Tag;
            var minQueue = fuelDispenserView.CarsInQueue;

            // Looking for Fuel Dispenser with minimal queue
            foreach (var fuelDispenser in ModelingProcessor.FuelDispensersList)
            {
                fuelDispenserView = (FuelDispenserView) fuelDispenser.Tag;
                if (fuelDispenserView.CarsInQueue < minQueue)
                {
                    minQueue = fuelDispenserView.CarsInQueue;
                    optimalFuelDispenser = fuelDispenser;
                }
            }

            car.ChosenFuelDispenser = optimalFuelDispenser;
            fuelDispenserView = (FuelDispenserView) optimalFuelDispenser.Tag;
            fuelDispenserView.CarsInQueue++;
            car.IsFuelDispenserChosen = true;

            int destPointX;
            int destPointY;
            Point destPoint;

            // Additional points for better graphics
            destPointX = optimalFuelDispenser.Left - CarWidth + 5;
            destPointY = optimalFuelDispenser.Bottom + TopologyCellSize - 10;
            destPoint = new Point(destPointX, destPointY);

            car.AddDestinationPoint(destPoint);

            destPointX = optimalFuelDispenser.Left + FuelingPointDeltaX;
            destPointY = optimalFuelDispenser.Bottom + FuelingPointDeltaY;
            destPoint = new Point(destPointX, destPointY);

            // The main point of fueling
            car.AddDestinationPoint(destPoint);

            // Additional points for better graphics
            destPointX = optimalFuelDispenser.Right - TopologyCellSize / 2;
            destPoint = new Point(destPointX, destPointY + CarHeight + 5);
            car.AddDestinationPoint(destPoint);
        }

        private static void GoToEnter(CarView car)
        {
            car.AddDestinationPoint(EnterPoint3);
            car.AddDestinationPoint(EnterPoint2);
            car.AddDestinationPoint(EnterPoint1);
        }

        private static void GoToExit(CarView car)
        {
            var fuelDispenserExitPoint = car.GetDestinationPoint();
            car.RemoveDestinationPoint(_modelingForm);

            car.AddDestinationPoint(LeavePointFilled);
            car.AddDestinationPoint(ExitPoint3);
            car.AddDestinationPoint(ExitPoint2);
            car.AddDestinationPoint(ExitPoint1);

            car.AddDestinationPoint(fuelDispenserExitPoint);
        }

        internal static Point PreventIntersection(PictureBox activeCar, Direction direction)
        {
            var activeCarView = (CarView) activeCar.Tag;
            var destPoint = activeCarView.GetDestinationPoint();

            foreach (Control c in _modelingForm.PlaygroundPanel.Controls)
            {
                if (!(c is PictureBox) || c.Tag == null || c == activeCar)
                {
                    continue;
                }

                var pictureBox = (PictureBox) c;

                if (!activeCar.Bounds.IntersectsWith(pictureBox.Bounds))
                {
                    continue;
                }

                // Another Car
                if (pictureBox.Tag is CarView)
                {
                    var anotherCar = pictureBox;

                    switch (direction)
                    {
                        case Direction.Up:
                        {
                            activeCar.Top = anotherCar.Bottom;

                            break;
                        }

                        case Direction.Right:
                        {
                            activeCar.Left = anotherCar.Left - activeCar.Width;

                            break;
                        }

                        case Direction.Down:
                        {
                            activeCar.Top = anotherCar.Top - activeCar.Height;

                            break;
                        }

                        case Direction.Left:
                        {
                            activeCar.Left = anotherCar.Right;

                            break;
                        }
                    }
                }


                // Fuel Dispenser
                if (pictureBox.Tag is FuelDispenserView || pictureBox.Tag is CashCounterView)
                {
                    var fuelDispenser = pictureBox;

                    bool bypassFromLeft = false;
                    bool bypassFromRight = false;
                    bool bypassFromBottom = false;
                    bool bypassFromTop = false;

                    int newDestX;
                    int newDestY;

                    Point newDestinationPoint1;
                    Point newDestinationPoint2;
                    Point newDestinationPoint3;

                    switch (direction)
                    {
                        case Direction.Up:
                        {
                            activeCar.Top = fuelDispenser.Bottom;

                            if (!activeCarView.IsBypassingObject)
                            {
                                activeCarView.IsBypassingObject = true;
                                // choose where to bypass 
                                newDestX = destPoint.X < activeCar.Left
                                    ? fuelDispenser.Left - (activeCar.Width + 5)
                                    : fuelDispenser.Right + (activeCar.Width + 5);


                                if (destPoint.X < activeCar.Left)
                                {
                                    newDestX = fuelDispenser.Left - (activeCar.Width + 5);
                                    bypassFromLeft = true;
                                }
                                else
                                {
                                    newDestX = fuelDispenser.Right + (activeCar.Width + 5);
                                    bypassFromRight = true;
                                }

                                newDestY = fuelDispenser.Bottom + 10;


                                newDestinationPoint1 = new Point(newDestX,
                                    newDestY);

                                newDestY = fuelDispenser.Top + activeCar.Height + 10;
                                newDestinationPoint2 = new Point(newDestX,
                                    newDestY);

                                activeCarView.DeleteDestinationSpot(_modelingForm);
                                activeCarView.AddDestinationPoint(newDestinationPoint2);
                                activeCarView.AddDestinationPoint(newDestinationPoint1);
                            }

                            break;
                        }

                        case Direction.Right:
                        {
                            break;
                        }

                        case Direction.Down:
                        {
                            activeCar.Top = fuelDispenser.Top - activeCar.Height;

                            if (!activeCarView.IsBypassingObject)
                            {
                                activeCarView.IsBypassingObject = true;


                                // choose where to bypass 
                                newDestX = fuelDispenser.Right + 10;

                                if (destPoint.X <= fuelDispenser.Left + fuelDispenser.Width / 2)
                                {
                                    newDestX = fuelDispenser.Left - (activeCar.Width + 5);
                                    bypassFromLeft = true;
                                }
                                else
                                {
                                    newDestX = fuelDispenser.Right + (activeCar.Width + 5);
                                    bypassFromRight = true;
                                }

                                newDestY = fuelDispenser.Top - 10;

                                newDestinationPoint1 = new Point(newDestX,
                                    newDestY);

                                newDestY = fuelDispenser.Bottom + activeCar.Height + 10;
                                newDestinationPoint2 = new Point(newDestX,
                                    newDestY);

                                activeCarView.DeleteDestinationSpot(_modelingForm);
                                activeCarView.AddDestinationPoint(newDestinationPoint2);
                                activeCarView.AddDestinationPoint(newDestinationPoint1);
                            }

                            break;
                        }

                        case Direction.Left:
                        {
                            activeCar.Left = fuelDispenser.Right;

                            if (!activeCarView.IsBypassingObject)
                            {
                                activeCarView.IsBypassingObject = true;

                                // choose where to bypass 
                                newDestX = fuelDispenser.Right + 10;

                                if (destPoint.Y <= fuelDispenser.Bottom)
                                {
                                    newDestY = fuelDispenser.Top - (activeCar.Width + 5);
                                    bypassFromTop = true;
                                }
                                else
                                {
                                    newDestY = fuelDispenser.Bottom + (activeCar.Width + 1);
                                    bypassFromBottom = true;
                                }

                                newDestinationPoint1 = new Point(newDestX,
                                    newDestY);

                                newDestX = fuelDispenser.Left + fuelDispenser.Width / 2;
                                newDestinationPoint2 = new Point(newDestX,
                                    newDestY);

                                newDestinationPoint3 = new Point(fuelDispenser.Left - 20,
                                    destPoint.Y - 20);

                                activeCarView.DeleteDestinationSpot(_modelingForm);
                                //activeCarView.AddDestinationPoint(newDestinationPoint3);
                                activeCarView.AddDestinationPoint(newDestinationPoint2);
                                activeCarView.AddDestinationPoint(newDestinationPoint1);
                            }

                            break;
                        }
                    }
                }
            }

            return activeCarView.GetDestinationPoint();
        }
    }
}
