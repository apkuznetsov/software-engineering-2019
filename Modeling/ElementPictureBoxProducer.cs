using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;
using static GasStationMs.App.Modeling.ClickEventProvider;

namespace GasStationMs.App.Modeling
{
    internal static class ElementPictureBoxProducer
    {
        private static ModelingForm _modelingForm;
        private static MappedTopology _mappedTopology;

        internal static void SetUpElementPictureBoxProducer(ModelingForm modelingForm, MappedTopology mappedTopology)
        {
            _modelingForm = modelingForm;
            _mappedTopology = mappedTopology;
        }

        internal static PictureBox CreateCashCounterPictureBox(CashCounterView cashCounterView,
            Point locationPoint)
        {
            var size = 50;
            PictureBox cashCounter = new PictureBox
            {
                Tag = cashCounterView,
                Image = Properties.Resources.cashbox,
                Size = new Size(size, size),
                Location = locationPoint,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            cashCounter.MouseClick += new MouseEventHandler(CashCounterPictureBox_Click);

            _modelingForm.PlaygroundPanel.Controls.Add(cashCounter);
            cashCounter.BringToFront();

            _mappedTopology.CashCounter = cashCounter;

            return cashCounter;
        }

        internal static PictureBox CreateEnterPictureBox(Point locationPoint)
        {
            var sizeX = ElementSizeDefiner.TopologyCellSize;
            var sizeY = 20;
            PictureBox enter = new PictureBox
            {
                Tag = "Enter",
                BackColor = Color.Chartreuse,
                Size = new Size(sizeX, sizeY),
                Location = locationPoint,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            //enter.Image = Properties.Resources.Enter;

            enter.MouseClick += new MouseEventHandler(EnterPictureBox_Click);

            _modelingForm.PlaygroundPanel.Controls.Add(enter);
            enter.BringToFront();

            _mappedTopology.Enter = enter;

            return enter;
        }

        internal static PictureBox CreateExitPictureBox(Point locationPoint)
        {
            var sizeX = ElementSizeDefiner.TopologyCellSize;
            var sizeY = 20;
            PictureBox exit = new PictureBox
            {
                Tag = "Exit",
                BackColor = Color.Coral,
                Size = new Size(sizeX, sizeY),
                Location = locationPoint,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            //enter.Image = Properties.Resources.Exit;

            exit.MouseClick += new MouseEventHandler(ExitPictureBox_Click);


            _modelingForm.PlaygroundPanel.Controls.Add(exit);
            exit.BringToFront();

            _mappedTopology.Exit = exit;

            return exit;
        }

        internal static PictureBox CreateCarPictureBox(CarView carView)
        {
            PictureBox car = new PictureBox
            {
                Tag = carView,
                Image = Properties.Resources.car_32x17__left,
                Location = DestinationPointsDefiner.SpawnPoint,
                SizeMode = PictureBoxSizeMode.AutoSize
            };

            car.MouseClick += new MouseEventHandler(CarPictureBox_Click);

            _modelingForm.PlaygroundPanel.Controls.Add(car);
            car.BringToFront();

            return car;
        }

        internal static PictureBox CreateFuelDispenserPictureBox(FuelDispenserView fuelDispenserView,
            Point locationPoint)
        {
            var size = 50;
            PictureBox fuelDispenser = new PictureBox
            {
                Tag = fuelDispenserView,
                Image = Properties.Resources.dispenser70,
                Size = new Size(size, size),
                Location = locationPoint,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            fuelDispenser.MouseClick += new MouseEventHandler(FuelDispenserPictureBox_Click);

            _modelingForm.PlaygroundPanel.Controls.Add(fuelDispenser);
            fuelDispenser.BringToFront();

            _mappedTopology.FuelDispensersList.Add(fuelDispenser);

            var pointOfFueling = new Point(fuelDispenser.Left + DestinationPointsDefiner.FuelingPointDeltaX,
                fuelDispenser.Bottom + DestinationPointsDefiner.FuelingPointDeltaY);
            _mappedTopology.AddFuelDispenserWithDestPoint(fuelDispenser, pointOfFueling);

            return fuelDispenser;
        }

        internal static PictureBox CreateFuelTankPictureBox(FuelTankView fuelTankView,
            Point locationPoint)
        {
            var size = 50;
            PictureBox fuelTank = new PictureBox
            {
                Tag = fuelTankView,
                Image = Properties.Resources.FuelTank,
                Size = new Size(size, size),
                Location = locationPoint,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Wheat
            };
            //For testing

            fuelTank.MouseClick += new MouseEventHandler(FuelTankPictureBox_Click);

            _modelingForm.PlaygroundPanel.Controls.Add(fuelTank);
            fuelTank.BringToFront();

            _mappedTopology.FuelTanksList.Add(fuelTank);

            return fuelTank;
        }
    }
}
