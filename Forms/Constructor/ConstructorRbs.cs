using System;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor
    {
        private bool canCheckRbCashCounter = false;
        private bool canCheckRbEntry = false;
        private bool canCheckRbExit = false;
        private bool canCheckRbFuelDispenser = false;
        private bool canCheckRbFuelTank = false;

        #region касса
        private void rbCashCounter_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            canCheckRbCashCounter = rbCashCounter.Checked;
        }

        private void rbCashCounter_Click(object sender, EventArgs e)
        {
            if (rbCashCounter.Checked && !canCheckRbCashCounter)
            {
                rbCashCounter.Checked = false;
            }
            else
            {
                rbCashCounter.Checked = true;
                canCheckRbCashCounter = false;
            }
        }
        #endregion /касса

        #region въезд
        private void rbEntry_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            canCheckRbEntry = rbEntry.Checked;
        }

        private void rbEntry_Click(object sender, EventArgs e)
        {
            if (rbEntry.Checked && !canCheckRbEntry)
            {
                rbEntry.Checked = false;
            }
            else
            {
                rbEntry.Checked = true;
                canCheckRbEntry = false;
            }
        }
        #endregion /въезд

        #region выезд
        private void rbExit_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            canCheckRbExit = rbExit.Checked;
        }

        private void rbExit_Click(object sender, EventArgs e)
        {
            if (rbExit.Checked && !canCheckRbExit)
            {
                rbExit.Checked = false;
            }
            else
            {
                rbExit.Checked = true;
                canCheckRbExit = false;
            }
        }
        #endregion /выезд

        #region ТРК
        private void radioButtonFuelDispenser_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            canCheckRbFuelDispenser = rbFuelDispenser.Checked;
        }

        private void rbFuelDispenser_Click(object sender, EventArgs e)
        {
            if (rbFuelDispenser.Checked && !canCheckRbFuelDispenser)
            {
                rbFuelDispenser.Checked = false;
            }
            else
            {
                rbFuelDispenser.Checked = true;
                canCheckRbFuelDispenser = false;
            }
        }
        #endregion /ТРК

        #region ТБ
        private void rbFuelTank_CheckedChanged(object sender, EventArgs e)
        {
            MakeAllPropertiesContorlsInvisible();

            canCheckRbFuelTank = rbFuelTank.Checked;
        }

        private void rbFuelTank_Click(object sender, EventArgs e)
        {
            if (rbFuelTank.Checked && !canCheckRbFuelTank)
            {
                rbFuelTank.Checked = false;
            }
            else
            {
                rbFuelTank.Checked = true;
                canCheckRbFuelTank = false;
            }
        }
        #endregion /ТБ
    }
}