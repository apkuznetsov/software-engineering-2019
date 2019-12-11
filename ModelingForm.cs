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

        public ModelingForm()
        {
            InitializeComponent();

            this.Controls.Remove(pictureBoxCar);
            
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

                var pictureBox = (PictureBox)c;

                // Car
                if (pictureBox.Tag is CarView)
                {
                    var car = pictureBox;
                    var carView = (CarView)car.Tag;

                    //carView.AddDestination()

                    MoveCarToDestination(car);

                    
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

            //Point destinationPoint = carView.GetDestinationPoint();
            Point destinationPoint = new Point(100, this.Height - 200);

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
    }
}
