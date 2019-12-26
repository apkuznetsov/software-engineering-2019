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
        private enum DistributionLaws
        {
            None,
            UniformDistribution,
            NormalDistribution,
            ExponentialDistribution,
            Determined
        }

        private TopologyBuilder tb;
        public IDistributionLaw randNumGenerator;

        public DistributionLawsForm(TopologyBuilder tb)
        {
            InitializeComponent();
            this.tb = tb;

            SetupCbChooseDistributionLaw();

            nudDeterminedFlow.Minimum = (decimal)TrafficFlow.MinParamForDeterminedFlow;
            nudDeterminedFlow.Maximum = (decimal)TrafficFlow.MaxParamForDeterminedFlow;

            SetupDefaultSettings();
            SetupUniformFlowSettings();
        }

        private void SetupCbChooseDistributionLaw()
        {
            List<string> distributionLawsList = new List<string>();
            distributionLawsList.Add("НЕ ВЫБРАН");
            distributionLawsList.Add("Равномерный");
            distributionLawsList.Add("Нормальный");
            distributionLawsList.Add("Показательный");

            cbChooseDistributionLaw.DataSource = distributionLawsList;
        }

        private void SetupDefaultSettings()
        {
            rbDeterminedFlow.Checked = true;
            MakeDeterminedFlowParamsVisible();

            MakeUniformFlowParamsInvisible();
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

        private void SetupUniformFlowSettings()
        {
            nudUniformDistParamA.Minimum = (decimal)TrafficFlow.MinAaParamForUniformFlow;
            nudUniformDistParamA.Maximum = (decimal)TrafficFlow.MaxAaParamForUniformFlow;

            nudUniformDistParamB.Minimum = (decimal)TrafficFlow.MinBbParamForUniformFlow;
            nudUniformDistParamB.Maximum = (decimal)TrafficFlow.MaxBbParamForUniformFlow;
        }

        private void cbChooseDistributionLaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeAllFlowsParamsInvisible();

            switch (cbChooseDistributionLaw.SelectedIndex)
            {
                case (int)DistributionLaws.UniformDistribution:
                    MakeUniformFlowParamsVisible();
                    break;

                case (int)DistributionLaws.NormalDistribution:
                    MakeNormalFlowParamsVisible();
                    break;

                case (int)DistributionLaws.ExponentialDistribution:
                    MakeExponetialFlowParamsVisible();
                    break;
            }
        }

        private void MakeAllFlowsParamsInvisible()
        {
            MakeDeterminedFlowParamsInvisible();
            MakeUniformFlowParamsInvisible();
            MakeNormalFlowParamsInvisible();
            MakeExponetialFlowParamsInvisible();
        }

        private void MakeUniformFlowParamsInvisible()
        {
            labelUniformDistParamA.Visible = false;
            nudUniformDistParamA.Visible = false;

            labelUniformDistParamB.Visible = false;
            nudUniformDistParamB.Visible = false;
        }

        private void MakeNormalFlowParamsInvisible()
        {

        }

        private void MakeExponetialFlowParamsInvisible()
        {

        }

        private void MakeUniformFlowParamsVisible()
        {
            labelUniformDistParamA.Visible = true;
            nudUniformDistParamA.Visible = true;

            labelUniformDistParamB.Visible = true;
            nudUniformDistParamB.Visible = true;
        }

        private void MakeNormalFlowParamsVisible()
        {

        }

        private void MakeExponetialFlowParamsVisible()
        {

        }


        #region


        private void buttonToModelling_Click(object sender, EventArgs e)
        {
            if (rbRandomFlow.Checked == true)
            {
                try
                {
                    switch (cbChooseDistributionLaw.SelectedIndex)
                    {
                        case (int)DistributionLaws.UniformDistribution:
                            randNumGenerator = new UniformDistribution((double)nudUniformDistParamA.Value, (double)nudUniformDistParamB.Value);
                            break;

                        case (int)DistributionLaws.NormalDistribution:
                            randNumGenerator = new NormalDistribution((double)normalDistributionPredicted.Value, (double)normalDistributionDispersion.Value);
                            break;

                        case (int)DistributionLaws.ExponentialDistribution:
                            randNumGenerator = new ExponentialDistribution((double)exponentialDistributionLambda.Value);
                            break;


                        default:
                            break;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    return;
                }
            }
            else
            {
                randNumGenerator = new DeterminedDistribution((double)nudDeterminedFlow.Value);
            }
            MessageBox.Show(randNumGenerator.GetRandNumber().ToString());

            Topology.Topology topology = tb.ToTopology();
            ModelingForm modelingForm = new ModelingForm(topology, randNumGenerator);
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
