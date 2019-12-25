using System.Text;
using System.Windows.Forms;
using GasStationMs.App.Forms;
using GasStationMs.App.Modeling.Models;
using GasStationMs.App.Modeling.Models.PictureBoxes;
using GasStationMs.App.Modeling.Models.Views;

namespace GasStationMs.App.Modeling
{
    internal static class ClickEventProvider
    {
        private static ModelingForm _modelingForm;
        private static Label _labelSelectedElement;
        private static TextBox _textBoxSelectedItemInformation;

        internal static void SetUpClickEventProvider(ModelingForm modelingForm)
        {
            _modelingForm = modelingForm;
            _labelSelectedElement = modelingForm.LabelSelectedElement;
            _textBoxSelectedItemInformation = modelingForm.TextBoxSelectedItemInformation;
        }
        internal static void CarPictureBox_Click(object sender, MouseEventArgs e)
        {
            var car = (PictureBox)sender;
            var carView = (CarView)car.Tag;

            // textBoxSelectedItemInformation.Text = "";
           _labelSelectedElement.Text = "Автомобиль";

            StringBuilder carInfo = new StringBuilder();

            carInfo.Append("Название: " + carView.Name);
            carInfo.Append("\r\nОбъем бака: " + carView.TankVolume);
            carInfo.Append("\r\nТоплива в баке: " + (int)carView.FuelRemained);


            _textBoxSelectedItemInformation.Text = carInfo.ToString();
            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

           _modelingForm.SelectedItem = car;
        }

        internal static void FuelDispenserPictureBox_Click(object sender, MouseEventArgs e)
        {
            var fuelDispenser = (PictureBox)sender;
            var fuelDispenserView = (FuelDispenserView)fuelDispenser.Tag;

            _labelSelectedElement.Text = "ТРК";

            StringBuilder fuelDispenserInfo = new StringBuilder();

            fuelDispenserInfo.Append("\r\nСкорость подачи топлива: " + fuelDispenserView.SpeedOfFillingPerSecond +
                                     " литров/сек.");

            _textBoxSelectedItemInformation.Text = fuelDispenserInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = fuelDispenser;
        }

        internal static void FuelTankPictureBox_Click(object sender, MouseEventArgs e)
        {
            var fuelTank = (PictureBox)sender;
            var fuelTankView = (FuelTankView)fuelTank.Tag;

            _labelSelectedElement.Text = "Топливный бак";

            StringBuilder fuelTankInfo = new StringBuilder();

            fuelTankInfo.Append("\r\nОбъем: " + fuelTankView.Volume + " литров");
            fuelTankInfo.Append("\r\nТопливо: " + fuelTankView.Fuel);
            fuelTankInfo.Append("\r\nОстаток: " + (int)fuelTankView.CurrentFullness + " литров");

            _textBoxSelectedItemInformation.Text = fuelTankInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = fuelTank;
        }

        internal static void CashCounterPictureBox_Click(object sender, MouseEventArgs e)
        {
            var cashCounter = (PictureBox)sender;
            var cashCounterView = (CashCounterView)cashCounter.Tag;

            _labelSelectedElement.Text = "Касса";

            StringBuilder cashCounterInfo = new StringBuilder();

            cashCounterInfo.Append("\r\nСумма: " + (int)cashCounterView.CurrentCashVolume + " руб.");
            cashCounterInfo.Append("\r\nЛимит кассы: " + cashCounterView.MaxCashVolume + " руб.");

            //cashCounterInfo.Append("\r\nIsFull: " + cashCounterView.IsFull);
            //cashCounterInfo.Append("\r\n-------------------------------");

            _textBoxSelectedItemInformation.Text = cashCounterInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = cashCounter;
        }

        internal static void CashCollectorPictureBox_Click(object sender, MouseEventArgs e)
        {
            var cashCollector = (CollectorPictureBox)sender;
            var cashCollectorView = cashCollector.Tag as CollectorView;

            _labelSelectedElement.Text = "Инкассация";

            StringBuilder cashCollectorInfo = new StringBuilder();

            cashCollectorInfo.Append("\r\nИзьято денег: " + (int)cashCollectorView.TakenCashVolume + " руб.");

            _textBoxSelectedItemInformation.Text = cashCollectorInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = cashCollector;
        }

        internal static void RefuellerPictureBox_Click(object sender, MouseEventArgs e)
        {
            var refueller = (RefuellerPictureBox)sender;
            var refuellerView = refueller.Tag as RefuellerView;

            _labelSelectedElement.Text = "Дозаправщик";

            StringBuilder cashCollectorInfo = new StringBuilder();

            cashCollectorInfo.Append("\r\nОсталось топлива: " + (int)refuellerView.FuelRemaining + " л.");

            _textBoxSelectedItemInformation.Text = cashCollectorInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = refueller;
        }


        internal static void EnterPictureBox_Click(object sender, MouseEventArgs e)
        {
            var enter = (PictureBox)sender;

            StringBuilder enterInfo = new StringBuilder();

            _labelSelectedElement.Text = "Въезд";

            enterInfo.Append("\r\nЗдесь автомобили въезжают на АЗС");

            _textBoxSelectedItemInformation.Text = enterInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = enter;
        }

        internal static void ExitPictureBox_Click(object sender, MouseEventArgs e)
        {
            var exit = (PictureBox)sender;

            StringBuilder exitInfo = new StringBuilder();

            _labelSelectedElement.Text = "Выезд";

            exitInfo.Append("\r\nЗдесь автомобили выезжают с АЗС");

            _textBoxSelectedItemInformation.Text = exitInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = exit;
        }

        internal static void ServiceArea_Click(object sender, MouseEventArgs e)
        {
            var serviceArea = (PictureBox)sender;

            StringBuilder serviceAreaInfo = new StringBuilder();

            _labelSelectedElement.Text = "Сервисная зона";

            serviceAreaInfo.Append("\r\nСервисна зона с топливными баками");
            serviceAreaInfo.Append("\r\nОбычным машинам тут не место");

            _textBoxSelectedItemInformation.Text = serviceAreaInfo.ToString();

            _labelSelectedElement.Visible = true;
            _textBoxSelectedItemInformation.Visible = true;

            _modelingForm.SelectedItem = serviceArea;
        }


        internal static void PlaygroundPanel_Click(object sender, MouseEventArgs e)
        {
            _labelSelectedElement.Visible = false;
            _textBoxSelectedItemInformation.Visible = false;
        }

    }
}
