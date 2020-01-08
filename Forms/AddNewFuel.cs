using GasStationMs.App.DB;
using GasStationMs.App.DB.Models;
using GasStationMs.App.TemplateElements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class AddNewFuel : Form
    {
        private readonly CrudHelper crudHelper;
        private FuelModel fuel;

        public AddNewFuel(CrudHelper crudHelper, FuelModel fuel)
        {
            if (crudHelper == null ||
                fuel == null)
            {
                throw new NullReferenceException();
            }

            InitializeComponent();

            this.crudHelper = crudHelper;
            this.fuel = fuel;

            labelWrongFuelName.Visible = false;
            nudCostPerLiter.Minimum = CashCounter.MinPricePerLiterOfFuelInRubles;
            nudCostPerLiter.Maximum = CashCounter.MaxPricePerLiterOfFuelInRubles;
        }

        private void btnAddNewFuel_Click(object sender, System.EventArgs e)
        {
            AddNewFuelToDb();

            Dispose();
            Close();
        }

        private void AddNewFuelToDb()
        {
            if (IsRightFuelName())
            {
                string newFuelName = tbFuelName.Text;
                double newFuelCostPerLiter = (double)nudCostPerLiter.Value;

                crudHelper.AddFuelToDb(newFuelName, newFuelCostPerLiter);
                fuel = new FuelModel(-1, newFuelName, newFuelCostPerLiter);

                MessageBox.Show("УСПЕШНО ДОБАВЛЕНО В БД" + newFuelName + ", " + newFuelCostPerLiter + " руб./литр");
            }
            else
            {
                labelWrongFuelName.Visible = true;
                labelWrongFuelName.Text = "ОШИБКА: название не может быть пустой строкой";
            }
        }

        private void tbFuelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelWrongFuelName.Visible = false;
        }

        private bool IsRightFuelName()
        {
            if (tbFuelName.Text != null ||
                tbFuelName.Text != "")
            {
                return true;
            }
            else
                return false;
        }
    }
}
