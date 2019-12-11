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

        private int _carSpeed = 3;
        private bool _paused;
        private readonly Random _rnd = new Random();

        #region TopologyElements

        private PictureBox _cashCounter;
        private PictureBox _enter;
        private PictureBox _exit;
        private List<PictureBox> _fuelDispensersList = new List<PictureBox>();
        private List<PictureBox> _fuelTanksList = new List<PictureBox>();

        #endregion /TopologyElements

        public ModelingForm()
        {
            InitializeComponent();

            this.Controls.Remove(pictureBoxCar);
            MapTopology();
            
        }

        private void TimerModeling_Tick(object sender, EventArgs e)
        {
            _timerTicksCount++;

            if (_paused)
            {
                return;
            }

            if (_timerTicksCount % 100 == 0)
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

                    var destPoint = new Point(_enter.Left + this._enter.Width / 2, _enter.Top + 40);
                    PictureBox destSpot = carView.DestinationSpot;

                    if (!carView.GetDestinationPoint().Equals(destPoint))
                    {
                        carView.AddDestinationPoint(destPoint.X, destPoint.Y);

                        destSpot = new PictureBox()
                        {
                            Size = new Size(5, 5),
                            Location = destPoint,
                            Visible = true,
                            BackColor = Color.DarkRed
                        };

                        carView.DestinationSpot = destSpot;
                        this.Controls.Add(destSpot);
                    }
                    

                    MoveCarToDestination(car);

                    if (car.Bounds.IntersectsWith(destSpot.Bounds))
                    {
                        this.Controls.Remove(car);
                        this.Controls.Remove(destSpot);
                        car.Dispose();
                        destSpot.Dispose();
                    }
                }
            }

            #endregion /LoopingControls
        }

        #region CarLogic

        private void SpawnCar(/*CarModel carModel*/)
        {
            var id = _timerTicksCount;
            var name = "mycar";
            var tankVolume = 80;
            var fuelRemained = 20;
            FuelView fuel = new FuelView(1, "АИ-92", 42.9);
            var isTruck = false;
            var isGoesFilling = true;

            var carView = new CarView(id, name, tankVolume, fuelRemained,
                fuel, isTruck, isGoesFilling);

            PictureBox car = new PictureBox();
            car.Tag = carView; 
            car.Image = Properties.Resources.car_64x34_;
            car.Left = this.Width - car.Width;
            car.Top = this.Height - car.Height - 50;
            car.SizeMode = PictureBoxSizeMode.AutoSize;

            this.Controls.Add(car);
            //car.BringToFront();
        }

        private void MoveCarToDestination(PictureBox car)
        {
            var carView = (CarView)car.Tag;

            Point destinationPoint = carView.GetDestinationPoint();
            //Point destinationPoint = new Point(100, this.Height - 200);
            //Point destinationPoint = new Point(_fuelDispensersList[0].Left,
            //   _fuelDispensersList[0].Bottom);


            // Go left
            if (car.Left > destinationPoint.X)
            {
                car.Left -= _carSpeed;
                //car.Image = Properties.Resources.car_64x34_left;
            }

            // Go Right
            if (car.Right < destinationPoint.X)
            {
                car.Left += _carSpeed;
                //car.Image = Properties.Resources.car_64x34_right;
            }

            // Go Up
            if (car.Top > destinationPoint.Y)
            {
                car.Top -= _carSpeed;
                //car.Image = Properties.Resources.car_64x34_up;
            }

            // Go Down
            if (car.Bottom < destinationPoint.Y)
            {
                car.Top += _carSpeed;
                //car.Image = Properties.Resources.car_64x34_down;
            }
        }

        #endregion CarLogic

        #region TopologyMappingLogic

        private void MapTopology(/*int[][] topology*/)
        {
            //CreateCashCounter();
            //CreateEnter();
            //CreateExit();
            //CreateFuelDispenser();
            //CreateFuelTank();

            _cashCounter = pictureBoxCashCounter;
            _enter = pictureBoxEnter;
            _exit = pictureBoxExit;
            _fuelDispensersList.Add(pictureBoxFuelDispenser1);
            _fuelDispensersList.Add(pictureBoxFuelDispenser2);
            _fuelTanksList.Add(pictureBoxFuelTank1);
            _fuelTanksList.Add(pictureBoxFuelTank2);
        }

        #endregion /TopologyMappingLogic
    }
}
