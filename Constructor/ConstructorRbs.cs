using System;

namespace GasStationMs.App
{
    public partial class Constructor
    {
        bool isCheckedradioButtonFuelDispenser = false;
        bool isCheckedradioButtonFuelTank = false;
        bool isCheckedRbCashCounter = false;

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

        #region касса
        private void rbCashCounter_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedRbCashCounter = rbCashCounter.Checked;
        }

        private void rbCashCounter_Click(object sender, EventArgs e)
        {
            if (rbCashCounter.Checked && !isCheckedRbCashCounter)
                rbCashCounter.Checked = false;
            else
            {
                rbCashCounter.Checked = true;
                isCheckedRbCashCounter = false;
            }
        }
        #endregion /касса
    }
}
