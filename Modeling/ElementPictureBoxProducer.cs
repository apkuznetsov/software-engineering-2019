using System.Drawing;
using System.Windows.Forms;
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
            PictureBox cashCounter = new PictureBox();
            cashCounter.Tag = cashCounterView;
            cashCounter.Image = Properties.Resources.cashbox;
            cashCounter.Size = new Size(size, size);
            cashCounter.Location = locationPoint;
            cashCounter.SizeMode = PictureBoxSizeMode.StretchImage;

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
            PictureBox enter = new PictureBox();
            enter.Tag = "Enter";
            enter.BackColor = Color.Chartreuse;
            //enter.Image = Properties.Resources.Enter;
            enter.Size = new Size(sizeX, sizeY);
            enter.Location = locationPoint;
            enter.SizeMode = PictureBoxSizeMode.StretchImage;

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
            PictureBox exit = new PictureBox();
            exit.Tag = "Exit";
            exit.BackColor = Color.Coral;
            //enter.Image = Properties.Resources.Exit;
            exit.Size = new Size(sizeX, sizeY);
            exit.Location = locationPoint;
            exit.SizeMode = PictureBoxSizeMode.StretchImage;

            exit.MouseClick += new MouseEventHandler(ExitPictureBox_Click);


            _modelingForm.PlaygroundPanel.Controls.Add(exit);
            exit.BringToFront();

            _mappedTopology.Exit = exit;

            return exit;
        }

        internal static PictureBox CreateCarPictureBox(CarView carView)
        {
            PictureBox car = new PictureBox();
            car.Tag = carView;
            car.Image = Properties.Resources.car_32x17__left;
            car.Location = DestinationPointsDefiner.SpawnPoint;
            car.SizeMode = PictureBoxSizeMode.AutoSize;

            car.MouseClick += new MouseEventHandler(CarPictureBox_Click);

            _modelingForm.PlaygroundPanel.Controls.Add(car);
            car.BringToFront();

            return car;
        }

        internal static PictureBox CreateFuelDispenserPictureBox(FuelDispenserView fuelDispenserView,
            Point locationPoint)
        {
            var size = 50;
            PictureBox fuelDispenser = new PictureBox();
            fuelDispenser.Tag = fuelDispenserView;
            fuelDispenser.Image = Properties.Resources.dispenser70;
            fuelDispenser.Size = new Size(size, size);
            fuelDispenser.Location = locationPoint;
            fuelDispenser.SizeMode = PictureBoxSizeMode.StretchImage;

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
            PictureBox fuelTank = new PictureBox();
            fuelTank.Tag = fuelTankView;
            fuelTank.Image = Properties.Resources.FuelTank;
            fuelTank.Size = new Size(size, size);
            fuelTank.Location = locationPoint;
            fuelTank.SizeMode = PictureBoxSizeMode.StretchImage;
            fuelTank.BackColor = Color.Wheat; //For testing

            fuelTank.MouseClick += new MouseEventHandler(FuelTankPictureBox_Click);

            _modelingForm.PlaygroundPanel.Controls.Add(fuelTank);
            fuelTank.BringToFront();

            _mappedTopology.FuelTanksList.Add(fuelTank);

            return fuelTank;
        }
    }
}
