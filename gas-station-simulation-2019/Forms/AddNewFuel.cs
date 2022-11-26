using GasStationMs.App.DB;
using GasStationMs.App.DB.Models;
using GasStationMs.App.TemplateElements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class AddNewFuel : Form
    {
        private static readonly int MinNameLen = 1;
        private static readonly int MaxNameLen = 20;

        private readonly CrudHelper crudHelper;
        private FuelTank fuelTank;

        public AddNewFuel(CrudHelper crudHelper, FuelTank fuelTank)
        {
            if (crudHelper == null ||
                fuelTank == null)
            {
                throw new NullReferenceException();
            }

            InitializeComponent();

            this.crudHelper = crudHelper;
            this.fuelTank = fuelTank;

            labelWrongFuelName.Visible = false;
            nudCostPerLiter.Minimum = CashCounter.MinPricePerLiterOfFuelInRubles;
            nudCostPerLiter.Maximum = CashCounter.MaxPricePerLiterOfFuelInRubles;
        }

        private void btnAddNewFuel_Click(object sender, System.EventArgs e)
        {
            if (AddNewFuelToDb())
            {
                Dispose();
                Close();
            }
        }

        private bool AddNewFuelToDb()
        {
            if (IsRightFuelName())
            {
                string newFuelName = tbFuelName.Text;
                double newFuelCostPerLiter = (double)nudCostPerLiter.Value;

                crudHelper.AddFuelToDb(newFuelName, newFuelCostPerLiter);
                fuelTank.Fuel = new FuelModel(-1, newFuelName, newFuelCostPerLiter);

                MessageBox.Show(
                    "УСПЕШНО ДОБАВЛЕНО В БД" + Environment.NewLine +
                    newFuelName + ", " + newFuelCostPerLiter + " руб./литр");

                return true;
            }
            else
            {
                labelWrongFuelName.Visible = true;
                labelWrongFuelName.Text = "название должно быть не менее 1 символа и не более 20";

                return false;
            }
        }

        private void tbFuelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelWrongFuelName.Visible = false;
        }

        private bool IsRightFuelName()
        {
            if (tbFuelName.Text.Length >= MinNameLen &&
                tbFuelName.Text.Length <= MaxNameLen)
            {
                return true;
            }
            else
                return false;
        }
    }
}
