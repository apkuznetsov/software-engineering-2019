using System;

namespace GasStationMs.App
{
    public partial class Constructor
    {
        bool isCheckedradioButtonFuelDispenser = false;
        bool isCheckedradioButtonFuelTank = false;

        private void radioButtonFuelDispenser_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedradioButtonFuelDispenser = rbFuelDispenser.Checked;
        }

        private void radioButtonFuelDispenser_Click(object sender, EventArgs e)
        {
            if (rbFuelDispenser.Checked && !isCheckedradioButtonFuelDispenser)
                rbFuelDispenser.Checked = false;
            else
            {
                rbFuelDispenser.Checked = true;
                isCheckedradioButtonFuelDispenser = false;
            }
        }

        private void radioButtonFuelTank_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedradioButtonFuelTank = rbFuelTank.Checked;
        }

        private void radioButtonFuelTank_Click(object sender, EventArgs e)
        {
            if (rbFuelTank.Checked && !isCheckedradioButtonFuelTank)
                rbFuelTank.Checked = false;
            else
            {
                rbFuelTank.Checked = true;
                isCheckedradioButtonFuelTank = false;
            }
        }
    }
}
