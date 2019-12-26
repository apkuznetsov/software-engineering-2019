using System;
using System.Collections.Generic;
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

            SetupCbChooseDistributionLaw();

            nudDeterminedFlow.Minimum = (decimal)TrafficFlow.MinTimeBetweenCarsInSeconds;
            nudDeterminedFlow.Maximum = (decimal)TrafficFlow.MaxTimeBetweenCarsInSeconds;

            SetupDefaultSettings();
        }

        private void SetupDefaultSettings()
        {
            rbDeterminedFlow.Checked = true;
            MakeDeterminedFlowParamsVisible();
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

        private void SetupCbChooseDistributionLaw()
        {
            List<string> distributionLawsList = new List<string>();
            distributionLawsList.Add("Равномерный");
            distributionLawsList.Add("Нормальный");
            distributionLawsList.Add("Показательный");

            cbChooseDistributionLaw.DataSource = distributionLawsList;
        }

        private void cbChooseDistributionLaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeDeterminedFlowParamsInvisible();

            MakeUniformFlowParamsInvisible();
            MakeNormalFlowParamsInvisible();
            MakeExponetialFlowParamsInvisible();

            switch (cbChooseDistributionLaw.SelectedIndex)
            {
                case 0:
                    MakeUniformFlowParamsVisible();
                    break;

                case 1:
                    MakeNormalFlowParamsVisible();
                    break;

                case 2:
                    MakeExponetialFlowParamsVisible();
                    break;
            }
        }

        private void MakeUniformFlowParamsInvisible()
        {

        }

        private void MakeNormalFlowParamsInvisible()
        {

        }

        private void MakeExponetialFlowParamsInvisible()
        {

        }

        private void MakeUniformFlowParamsVisible()
        {

        }

        private void MakeNormalFlowParamsVisible()
        {

        }

        private void MakeExponetialFlowParamsVisible()
        {

        }


        #region

        public IDistributionLaw Generator;
        private void buttonToModelling_Click(object sender, EventArgs e)
        {
            if (rbRandomFlow.Checked == true)
            {
                switch (cbChooseDistributionLaw.SelectedIndex)
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
                cbChooseDistributionLaw.Visible = true;
                MakeDeterminedFlowParamsInvisible();
            }
            else
            {
                cbChooseDistributionLaw.Visible = false;
                MakeDeterminedFlowParamsVisible();
            }
        }


    }
}
