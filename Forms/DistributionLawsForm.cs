using System;
using System.Linq;
using System.Windows.Forms;
using GasStationMs.App.DistributionLaws;
using GasStationMs.App.Forms;
using GasStationMs.App.Models;
using GasStationMs.App.Topology;

namespace GasStationMs.App
{
    public partial class DistributionLawsForm : Form
    {
        private TopologyBuilder tb;

        public DistributionLawsForm(TopologyBuilder tb)
        {
            InitializeComponent();

            this.tb = tb;

            nudDeterminedFlow.Minimum = (decimal)TrafficFlow.MinTimeBetweenCarsInSeconds;
            nudDeterminedFlow.Maximum = (decimal)TrafficFlow.MaxTimeBetweenCarsInSeconds;

            rbDeterminedFlow.Checked = true;
            MakeDeterminedFlowParamsVisible();
        }
        #region Отображение ЗР

        private void cbSelectDistributionLaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSelectDistributionLaw.SelectedIndex)
            {
                case 0:
                    labelDeterminedFlowParams.Visible = true;
                    nudDeterminedFlow.Visible = true;


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

        #region

        public IDistributionLaw Generator;
        private void buttonToModelling_Click(object sender, EventArgs e)
        {
            if (rbRandomFlow.Checked == true)
            {
                switch (cbSelectDistributionLaw.SelectedIndex)
                {
                    case 0:
                        Generator = new UniformDistribution(0.1, (double)nudDeterminedFlow.Value);
                        break;

                    case 1:
                        Generator = new NormalDistribution((double)normalDistributionPredicted.Value, (double)normalDistributionDispersion.Value);
                        break;

                    case 2:
                        Generator = new ExponentialDistribution((double)exponentialDistributionLambda.Value);
                        break;


                    default:
                        break;
                }

            }
            else
            {
                Generator = new DeterminedDistribution((double)nudDeterminedFlow.Value);
            }
            label4.Text = Generator.GetRandNumber().ToString();

            Topology.Topology topology = tb.ToTopology();
            ModelingForm modelingForm = new ModelingForm(topology, Generator);
            modelingForm.ShowDialog();
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

        private void rbRandomFlow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandomFlow.Checked == true)
            {
                cbSelectDistributionLaw.Visible = true;
                MakeDeterminedFlowParamsInvisible();
            }
            else
            {
                cbSelectDistributionLaw.Visible = false;
                MakeDeterminedFlowParamsVisible();
            }
        }

        private void MakeDeterminedFlowParamsVisible()
        {
            labelDeterminedFlowParams.Visible = true;
            nudDeterminedFlow.Visible = true;
        }

        private void MakeDeterminedFlowParamsInvisible()
        {
            labelDeterminedFlowParams.Visible = false;
            nudDeterminedFlow.Visible = false;
        }
    }
}
