using GasStationMs.App.TemplateElements;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class AddNewFuel : Form
    {
        public AddNewFuel()
        {
            InitializeComponent();

            nudCostPerLiter.Minimum = CashCounter.MinPricePerLiterOfFuelInRubles;
            nudCostPerLiter.Maximum = CashCounter.MaxPricePerLiterOfFuelInRubles;
        }

        private void btnAddNewFuel_Click(object sender, System.EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
