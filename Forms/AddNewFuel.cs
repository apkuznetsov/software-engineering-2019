using GasStationMs.App.DB;
using GasStationMs.App.TemplateElements;
using System;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class AddNewFuel : Form
    {
        private readonly CrudHelper crudHelper;

        public AddNewFuel(CrudHelper crudHelper)
        {
            InitializeComponent();

            this.crudHelper = crudHelper;

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
                double newFuelPrice = (double)nudCostPerLiter.Value;

                crudHelper.AddFuelToDb(newFuelName, newFuelPrice);
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
