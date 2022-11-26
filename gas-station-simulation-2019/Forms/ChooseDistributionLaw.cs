using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GasStationMs.App.DistributionLaws;
using GasStationMs.App.Forms;
using GasStationMs.App.Models;

namespace GasStationMs.App
{
    public partial class ChooseDistributionLaw : Form
    {
        private readonly Topology.Topology topology;
        private IDistributionLaw randNumGenerator;

        public ChooseDistributionLaw(Topology.Topology topology)
        {
            this.topology = topology ?? throw new NullReferenceException();

            InitializeComponent();

            SetupDefaultSettings();

            labelDeterminedFlowParams.Visible = true;
            nudDeterminedFlow.Visible = true;
        }

        private void SetupDefaultSettings()
        {
            MakeDeterminedFlowParamsVisible();

            SetupCbChooseDistributionLaw();
            SetupFlowsSettings();
            SetupChoosingProbabilityOfStoppingAtGasStation();
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

        private void MakeUniformFlowParamsVisible()
        {
            labelUniformDistParamA.Visible = true;
            nudUniformDistParamA.Visible = true;

            labelUniformDistParamB.Visible = true;
            nudUniformDistParamB.Visible = true;
        }

        private void MakeUniformFlowParamsInvisible()
        {
            labelUniformDistParamA.Visible = false;
            nudUniformDistParamA.Visible = false;

            labelUniformDistParamB.Visible = false;
            nudUniformDistParamB.Visible = false;
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

        private void SetupFlowsSettings()
        {
            SetupDeteminedFlowSettings();
            SetupUniformFlowSettings();
            SetupNormalFlowSettings();
            SetupExponentialFlowSettings();
        }

        private void SetupDeteminedFlowSettings()
        {
            nudDeterminedFlow.Minimum = (decimal)TrafficFlow.MinParamForDeterminedFlow;
            nudDeterminedFlow.Maximum = (decimal)TrafficFlow.MaxParamForDeterminedFlow;
        }

        private void SetupUniformFlowSettings()
        {
            nudUniformDistParamA.Minimum = (decimal)TrafficFlow.MinAaParamForUniformFlow;
            nudUniformDistParamA.Maximum = (decimal)TrafficFlow.MaxAaParamForUniformFlow;

            nudUniformDistParamB.Minimum = (decimal)TrafficFlow.MinBbParamForUniformFlow;
            nudUniformDistParamB.Maximum = (decimal)TrafficFlow.MaxBbParamForUniformFlow;
        }

        private void SetupNormalFlowSettings()
        {
            nudNormalDistrVariance.Minimum = (decimal)TrafficFlow.MinVarianceForNormalFlow;
            nudNormalDistrVariance.Maximum = (decimal)TrafficFlow.MaxVarianceForNormalFlow;

            nudNormalDistrExpectedValue.Minimum = (decimal)TrafficFlow.MinExpectedValueForNormalFlow;
            nudNormalDistrExpectedValue.Maximum = (decimal)TrafficFlow.MaxExpectedValueForNormalFlow;
        }

        private void SetupExponentialFlowSettings()
        {
            nudExponentialDistrLambda.Minimum = (decimal)TrafficFlow.MinLambdaForExponentialFlow;
            nudExponentialDistrLambda.Maximum = (decimal)TrafficFlow.MaxLambdaForExponentialFlow;
        }

        private void SetupChoosingProbabilityOfStoppingAtGasStation()
        {
            nudProbabilityOfStoppingAtGasStation.Minimum = (decimal)TrafficFlow.MinProbabilityOfStoppingAtGasStation;
            nudProbabilityOfStoppingAtGasStation.Maximum = (decimal)TrafficFlow.MaxProbabilityOfStoppingAtGasStation;
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
                    MakeExponentialFlowParamsVisible();
                    break;
            }
        }

        private enum DistributionLaws
        {
            None,
            UniformDistribution,
            NormalDistribution,
            ExponentialDistribution,
            Determined
        }

        private void MakeAllFlowsParamsInvisible()
        {
            MakeDeterminedFlowParamsInvisible();
            MakeUniformFlowParamsInvisible();
            MakeNormalFlowParamsInvisible();
            MakeExponentialFlowParamsInvisible();
        }

        private void MakeNormalFlowParamsVisible()
        {
            labelNormalDistrVariance.Visible = true;
            nudNormalDistrVariance.Visible = true;

            labelNormalDistrExpectedValue.Visible = true;
            nudNormalDistrExpectedValue.Visible = true;
        }

        private void MakeNormalFlowParamsInvisible()
        {
            labelNormalDistrVariance.Visible = false;
            nudNormalDistrVariance.Visible = false;

            labelNormalDistrExpectedValue.Visible = false;
            nudNormalDistrExpectedValue.Visible = false;
        }

        private void MakeExponentialFlowParamsVisible()
        {
            labelExponentialDistrLambda.Visible = true;
            nudExponentialDistrLambda.Visible = true;
        }

        private void MakeExponentialFlowParamsInvisible()
        {
            labelExponentialDistrLambda.Visible = false;
            nudExponentialDistrLambda.Visible = false;
        }

        private void btnOpenModeling_Click(object sender, EventArgs e)
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
                            randNumGenerator = new NormalDistribution((double)nudNormalDistrExpectedValue.Value, (double)nudNormalDistrVariance.Value);
                            break;

                        case (int)DistributionLaws.ExponentialDistribution:
                            randNumGenerator = new ExponentialDistribution((double)nudExponentialDistrLambda.Value);
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

            TrafficFlow trafficFlow = new TrafficFlow(randNumGenerator, (double)nudProbabilityOfStoppingAtGasStation.Value);

            ModelingForm modeling = new ModelingForm(topology, trafficFlow);
            modeling.Show();

            Dispose();
            Close();
        }

        private void rbRandomFlow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandomFlow.Checked == true)
            {
                cbChooseDistributionLaw.Visible = true;
                labelChooseDistrLaw.Visible = true;
                MakeDeterminedFlowParamsInvisible();

                cbChooseDistributionLaw.Text = "НЕ ВЫБРАН";
            }
            else
            {
                cbChooseDistributionLaw.Visible = false;
                labelChooseDistrLaw.Visible = false;
                MakeRandomFlowsParamsInvisible();

                MakeDeterminedFlowParamsVisible();
            }
        }

        private void MakeRandomFlowsParamsInvisible()
        {
            MakeUniformFlowParamsInvisible();
            MakeNormalFlowParamsInvisible();
            MakeExponentialFlowParamsInvisible();
        }
    }
}
