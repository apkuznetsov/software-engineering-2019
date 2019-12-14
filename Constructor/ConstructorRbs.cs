using GasStationMs.App.Models;
using GasStationMs.App.TemplateElements;
using System;

namespace GasStationMs.App
{
    public partial class Constructor
    {
        bool isCheckedradioButtonFuelDispenser = false;
        bool isCheckedradioButtonFuelTank = false;
        bool isCheckedRbCashCounter = false;
        bool isCheckedRbEntry = false;
        bool isCheckedRbExit;

        private void SetRbsNames()
        {
            rbFuelDispenser.Name = typeof(FuelDispenser).ToString();
            rbFuelTank.Name = typeof(FuelTank).ToString();
            rbCashCounter.Name = typeof(CashCounter).ToString();
            rbEntry.Name = typeof(Entry).ToString();
            rbExit.Name = typeof(Exit).ToString();
        }

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

        #region Въезд
        private void rbEntry_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedRbEntry = rbEntry.Checked;
        }

        private void rbEntry_Click(object sender, EventArgs e)
        {
            if (rbEntry.Checked && !isCheckedRbEntry)
                rbEntry.Checked = false;
            else
            {
                rbEntry.Checked = true;
                isCheckedRbEntry = false;
            }
        }
        #endregion /Въезд

        #region Выезд
        private void rbExit_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedRbExit = rbExit.Checked;
        }

        private void rbExit_Click(object sender, EventArgs e)
        {
            if (rbExit.Checked && !isCheckedRbExit)
            {
                rbExit.Checked = false;
            }
            else
            {
                rbExit.Checked = true;
                isCheckedRbExit = false;
            }
        }
        #endregion /Выезд
    }
}