using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationMs.App.DistributionLaws
{
    public partial class DistributionLaws : Form
    {
        public DistributionLaws()
        {
            InitializeComponent();
        }
        #region Отображение ЗР

        private void distributionLaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (distributionLaw.SelectedIndex)
            {
                case 0:
                    uniformDistributionTimeLabel.Visible = true;
                    uniformDistributionTime.Visible = true;
                    uniformDistributionPanel.Visible = true;


                    break;

                case 1:
                    normalDistributionDispersion.Visible = true;
                    normalDistributionPredicted.Visible = true;
                    normalDistributionDispersionLabel.Visible = true;
                    normalDistributionPredictedLabel.Visible = true;
                    normalDistributionPanel.Visible = true;


                    break;

                case 2:
                    exponentialDistributionLambda.Visible = true;
                    exponentialDistributionLambdaLabel.Visible = true;
                    exponentialDistributionPanel.Visible = true;


                    break;

                default:
                    break;
            }
        }
        #endregion

        #region radiobuttons
        bool isCheckedradioButtonDeterminedFlow = false;
        bool isCheckedradioButtonRandomFlow = false;

        private void radioButtonDeterminedFlow_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedradioButtonDeterminedFlow = determinedFlow.Checked;
        }

        private void radioButtonDeterminedFlow_Click(object sender, EventArgs e)
        {
            if (determinedFlow.Checked && !isCheckedradioButtonDeterminedFlow)
                determinedFlow.Checked = false;
            else
            {
                determinedFlow.Checked = true;
                isCheckedradioButtonDeterminedFlow = false;
            }
        }

        private void radioButtonRandomFlow_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedradioButtonRandomFlow = randomFlow.Checked;
        }

        private void radioButtonRandomFlow_Click(object sender, EventArgs e)
        {
            if (randomFlow.Checked && !isCheckedradioButtonRandomFlow)
                randomFlow.Checked = false;
            else
            {
                randomFlow.Checked = true;
                isCheckedradioButtonRandomFlow = false;
            }
        }
        #endregion

        #region

        public IDistributionLaw generator;
        private void buttonToModelling_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                var flow = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

                if (flow.Name == "randomFlow")
                {
                    switch (distributionLaw.SelectedIndex)
                    {
                        case 0:
                            generator = new UniformDistribution(0.1,(double)uniformDistributionTime.Value);
                            break;

                        case 1:
                            generator = new NormalDistribution((double)normalDistributionPredicted.Value, (double)normalDistributionDispersion.Value);
                            break;

                        case 2:
                            generator = new ExponentialDistribution((double)exponentialDistributionLambda.Value);
                            break;


                        default:
                            break;
                    }

                }
                else
                {
                    generator = new DeterminedDistribution((double)determinedFlowInterval.Value);
                }
                label4.Text = generator.GetRandNumber().ToString();
            }

        }

        #endregion


        #region Методы обязательные для форм
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exponentialDistributionLambdaLabel_Click(object sender, EventArgs e)
        {

        }

        private void exponentialDistributionLambda_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
