using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasStationMs.App.Modeling.Models;

namespace GasStationMs.App
{
    public partial class ModelingForm : Form
    {
        private int _timerTicksCount = 0;

        private int _carSpeedNoFilling = 4;
        private int _carSpeedFilling = 3;
        private bool _paused;
        private readonly Random _rnd = new Random();

        #region TopologyElements

        private PictureBox _cashCounter;
        private PictureBox _enter;
        private PictureBox _exit;
        private List<PictureBox> _fuelDispensersList = new List<PictureBox>();
        private List<PictureBox> _fuelTanksList = new List<PictureBox>();

        #endregion /TopologyElements

        #region DestinationPoints

        private Dictionary<string, Point> _destPointsDictionary = new Dictionary<string, Point>();

        private int _noFillingHorizontalLine;
        private int _filledHorizontalLine;
                
        private int _rightPlaygroundBorder;
        private int _leftPlaygroundBorder;
        private int _leftCarDestroyingEdge;

        // Spawning/destroying car destination points
        private Point _spawnPoint;
        private Point _leavePointNoFilling;
        private Point _leavePointFilled;

        // Destination points to enter/leave gas station
        private Point _enterCenter;
        private Point _exitCenter;

        private Point _enterPoint1;
        private Point _enterPoint2;
        private Point _enterPoint3;

        private Point _exitPoint1 ;
        private Point _exitPoint2;

        #endregion /DestinationPoints

        public ModelingForm()
        {
            InitializeComponent();

            this.Controls.Remove(pictureBoxCar);
            this.Controls.Remove(pictureBoxFuelDispenser1);
            this.Controls.Remove(pictureBoxFuelDispenser2);

            MapTopology();
        }

        private void TimerModeling_Tick(object sender, EventArgs e)
        {
            _timerTicksCount++;

            if (_paused)
            {
                return;
            }

            if (_timerTicksCount % 40 == 0)
            {
                SpawnCar();
            }

            #region LoopingControls

            foreach (Control c in this.Controls)
            {
                if (!(c is PictureBox) || c.Tag == null)
                {
                    continue;
                }

                var pictureBox = (PictureBox) c;

                // Car
                if (pictureBox.Tag is CarView)
                {
                    var car = pictureBox;
                    var carView = (CarView) car.Tag;

                    MoveCarToDestination(car);
                }
            }

            #endregion /LoopingControls
        }

        #region CarLogic

        private void SpawnCar( /*CarModel carModel*/)
        {
            var carView = CreateCarView( /*caeModel*/);

            // Some Distribution law here
            if (_rnd.NextDouble() >= 0.5)
            {
                carView.IsGoesFilling = true;
            }

            if (carView.IsGoesFilling)
            {
                //test
                carView.AddDestinationPoint(_leavePointFilled);
                carView.AddDestinationPoint(_exitPoint2);
                carView.AddDestinationPoint(_exitPoint1);
                //\test-----------

                carView.AddDestinationPoint(_enterPoint3);
                carView.AddDestinationPoint(_enterPoint2);
                carView.AddDestinationPoint(_enterPoint1);
            }
            else
            {
                carView.AddDestinationPoint(_leavePointNoFilling);
            }

            CreateCarPictureBox(carView);
        }

        private void MoveCarToDestination(PictureBox car)
        {
            var carView = (CarView) car.Tag;
            var destPoint = carView.GetDestinationPoint();
            PictureBox destSpot = carView.DestinationSpot;

            var carSpeed = carView.IsGoesFilling ? _carSpeedFilling : _carSpeedNoFilling;
            
            // Go left
            if (car.Left > destPoint.X)
            {
                car.Left -= carSpeed;
                //car.Image = Properties.Resources.car_64x34_left;
            }

            // Go Right
            if (car.Right < destPoint.X)
            {
                car.Left += carSpeed;
                //car.Image = Properties.Resources.car_64x34_right;
            }

            // Go Up
            if (car.Top > destPoint.Y)
            {
                car.Top -= carSpeed;
                //car.Image = Properties.Resources.car_64x34_up;
            }

            // Go Down
            if (car.Bottom < destPoint.Y)
            {
                car.Top += carSpeed;
                //car.Image = Properties.Resources.car_64x34_down;
            }


            if (carView.DestinationSpot == null)
            {
                destSpot = carView.CreateDestinationSpot(destPoint);
                this.Controls.Add(destSpot);
            }

            if (car.Bounds.IntersectsWith(destSpot.Bounds))
            {
                carView.RemoveDestinationPoint(this);

                if (destPoint.Equals(_leavePointNoFilling) || destPoint.Equals(_leavePointFilled))
                {
                    this.Controls.Remove(car);
                    car.Dispose();
                }
            }
        }

        #endregion CarLogic

        #region TopologyMappingLogic

        private void MapTopology( /*int[][] topology*/)
        {
            //CreateCashCounter();
            //CreateEnter();
            //CreateExit();
            //CreateFuelDispenser();
            //CreateFuelTank();

            _cashCounter = pictureBoxCashCounter;
            _enter = pictureBoxEnter;
            _exit = pictureBoxExit;

            #region FuelDispenser

            //_fuelDispensersList.Add(pictureBoxFuelDispenser1);
            //_fuelDispensersList.Add(pictureBoxFuelDispenser2);
            var fuelView1 = CreateFuelDispenserView("fuelDispenser1", 10);
            var fuelView2 = CreateFuelDispenserView("fuelDispenser2", 15);

            CreateFuelDispenserPictureBox(fuelView1, new Point(235, 30));
            CreateFuelDispenserPictureBox(fuelView2, new Point(235, 180));

            #endregion


            _fuelTanksList.Add(pictureBoxFuelTank1);
            _fuelTanksList.Add(pictureBoxFuelTank2);

            #region DestinationPoints

            var carHeight = 35;

            _noFillingHorizontalLine = this.Height - 2*carHeight - 20;
            _filledHorizontalLine = this.Height - 3*carHeight - 40;

            _rightPlaygroundBorder = this.Width;
            _leftPlaygroundBorder =  0;
            _leftCarDestroyingEdge = _leftPlaygroundBorder - 40;

            // Spawning/destroying car destination points
            _spawnPoint = new Point(_rightPlaygroundBorder + 50, _noFillingHorizontalLine);
            _leavePointNoFilling = new Point(_leftCarDestroyingEdge, _noFillingHorizontalLine);
            _leavePointFilled = new Point(_leftCarDestroyingEdge, _filledHorizontalLine);

            // Destination points to enter/leave gas station
            _enterCenter = new Point(_enter.Left + _enter.Width / 2,
                _enter.Top + _enter.Height / 2);
            _exitCenter = new Point(_exit.Left + _exit.Width / 2,
                _exit.Top + _exit.Height / 2);

            _enterPoint1 = new Point(_spawnPoint.X - 200, _filledHorizontalLine);
            _enterPoint2 = new Point(_enterCenter.X, _enterCenter.Y + _enter.Height);
            _enterPoint3 = new Point(_enterCenter.X, _enterCenter.Y - _enter.Height);
            
            _exitPoint1 = new Point(_exitCenter.X, _exitCenter.Y - _exit.Height);
            _exitPoint2 = new Point(_exitCenter.X, _exitCenter.Y + _exit.Height);

            #endregion /DestinationPoints
        }

        #endregion /TopologyMappingLogic

        #region ElementsProducers

        private CarView CreateCarView( /*CarModel*/)
        {
            var id = _timerTicksCount;
            var name = "mycar";
            var tankVolume = 80;
            var fuelRemained = 20;
            FuelModel fuel = new FuelModel(1, "АИ-92", 42.9);
            var isTruck = false;
            var isGoesFilling = false;

             return new CarView(id, name, tankVolume, fuelRemained,
                fuel, isTruck, isGoesFilling);
        }

        private PictureBox CreateCarPictureBox(CarView carView)
        {
            PictureBox car = new PictureBox();
            car.Tag = carView;
            car.Image = Properties.Resources.car_64x34_;
            car.Location = _spawnPoint;
            car.SizeMode = PictureBoxSizeMode.AutoSize;

            this.Controls.Add(car);
            car.BringToFront();

            return car;
        }

        private FuelDispenserView CreateFuelDispenserView( string name, int speedOfFilling)
        {
            return new FuelDispenserView(name, speedOfFilling);
        }

        private PictureBox CreateFuelDispenserPictureBox(FuelDispenserView fuelDispenserView, 
            Point locactionPoint)
        {
            var size = 50;
            PictureBox fuelDispenser = new PictureBox();
            fuelDispenser.Tag = fuelDispenserView;
            fuelDispenser.Image = Properties.Resources.dispenser70;
            fuelDispenser.Size = new Size(size, size);
            fuelDispenser.Location = locactionPoint;
            fuelDispenser.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Filling area
            PictureBox fillingArea = new PictureBox();
            fillingArea.Tag = fuelDispenserView;
            fillingArea.BackColor = Color.LightSlateGray;
            fillingArea.Size = new Size(size, size/2);
            fillingArea.Left = fuelDispenser.Left;
            fillingArea.Top = fuelDispenser.Bottom;
            fillingArea.SizeMode = PictureBoxSizeMode.AutoSize;

            this.Controls.Add(fuelDispenser);
            this.Controls.Add(fillingArea);
            fuelDispenser.BringToFront();
            fillingArea.BringToFront();

            _fuelDispensersList.Add(fuelDispenser);


            return fuelDispenser;
        }

        #endregion /ElementsProducers
    }
}
