using System;
using GasStationMs.App.TemplateElements;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor
    {
        private bool _isCheckedradioButtonFuelDispenser = false;
        private bool _isCheckedradioButtonFuelTank = false;
        private bool _isCheckedRbCashCounter = false;
        private bool _isCheckedRbEntry = false;
        private bool _isCheckedRbExit = false;

        private void radioButtonFuelDispenser_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            _isCheckedradioButtonFuelDispenser = rbFuelDispenser.Checked;
        }

        private void radioButtonFuelDispenser_Click(object sender, EventArgs e)
        {
            if (rbFuelDispenser.Checked && !_isCheckedradioButtonFuelDispenser)
                rbFuelDispenser.Checked = false;
            else
            {
                rbFuelDispenser.Checked = true;
                _isCheckedradioButtonFuelDispenser = false;
            }
        }

        private void radioButtonFuelTank_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            _isCheckedradioButtonFuelTank = rbFuelTank.Checked;
        }

        private void radioButtonFuelTank_Click(object sender, EventArgs e)
        {
            if (rbFuelTank.Checked && !_isCheckedradioButtonFuelTank)
                rbFuelTank.Checked = false;
            else
            {
                rbFuelTank.Checked = true;
                _isCheckedradioButtonFuelTank = false;
            }
        }

        #region касса
        private void rbCashCounter_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            _isCheckedRbCashCounter = rbCashCounter.Checked;
        }

        private void rbCashCounter_Click(object sender, EventArgs e)
        {
            if (rbCashCounter.Checked && !_isCheckedRbCashCounter)
                rbCashCounter.Checked = false;
            else
            {
                rbCashCounter.Checked = true;
                _isCheckedRbCashCounter = false;
            }
        }
        #endregion /касса

        #region Въезд
        private void rbEntry_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            _isCheckedRbEntry = rbEntry.Checked;
        }

        private void rbEntry_Click(object sender, EventArgs e)
        {
            if (rbEntry.Checked && !_isCheckedRbEntry)
                rbEntry.Checked = false;
            else
            {
                rbEntry.Checked = true;
                _isCheckedRbEntry = false;
            }
        }
        #endregion /Въезд

        #region Выезд
        private void rbExit_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            _isCheckedRbExit = rbExit.Checked;
        }

        private void rbExit_Click(object sender, EventArgs e)
        {
            if (rbExit.Checked && !_isCheckedRbExit)
            {
                rbExit.Checked = false;
            }
            else
            {
                rbExit.Checked = true;
                _isCheckedRbExit = false;
            }
        }
        #endregion /Выезд
    }
}