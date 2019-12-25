using System;
using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.DistributionLaws;
using GasStationMs.App.Modeling;

namespace GasStationMs.App.Forms
{
    public partial class ModelingForm : Form
    {
        //private readonly IDistributionLaw timeBetweenCarsGenerator;

        private readonly MappedTopology _mappedTopology;

        public PictureBox SelectedItem { get; set; }
        public Panel PlaygroundPanel { get; private set; }
        public Label LabelSelectedElement { get; private set; }
        public Label LabelCashCounterSumValue { get; private set; }
        public TextBox TextBoxSelectedItemInformation { get; private set; }
        public PictureBox PictureBoxServiceArea { get; private set; }

        public ModelingForm(Topology.Topology topology/*, IDistributionLaw timeBetweenCarsGenerator*/)
        {
            InitializeComponent();
            RemoveUnusedControls();
            DefineProperties();
            LocateFormElements();

            ElementSizeDefiner.TopologyCellSize = 50;

            ClickEventProvider.SetUpClickEventProvider(this);

            //this.timeBetweenCarsGenerator = timeBetweenCarsGenerator;
            _mappedTopology = TopologyMapper.MapTopology(this, topology);

            ModelingProcessor.SetUpModelingProcessor(this, _mappedTopology);
        }

        private void TimerModeling_Tick(object sender, EventArgs e)
        {
            ModelingTicker.Tick(this, _mappedTopology);
        }

        private void RemoveUnusedControls()
        {
            panelPlayground.Controls.Remove(pictureBoxCashCounter);
            panelPlayground.Controls.Remove(pictureBoxCar);
            panelPlayground.Controls.Remove(pictureBoxEnter);
            panelPlayground.Controls.Remove(pictureBoxExit);
            panelPlayground.Controls.Remove(pictureBoxFuelDispenser1);
            panelPlayground.Controls.Remove(pictureBoxFuelDispenser2);
            panelPlayground.Controls.Remove(pictureBoxFuelTank1);
            panelPlayground.Controls.Remove(pictureBoxFuelTank2);
        }

        private void DefineProperties()
        {
            PlaygroundPanel = panelPlayground;
            LabelSelectedElement = labelSelectedElement;
            TextBoxSelectedItemInformation = textBoxSelectedItemInformation;
            PictureBoxServiceArea = pictureBoxServiceArea;
            LabelCashCounterSumValue = labelCashCounterSumValue;
        }

        private void LocateFormElements()
        {
            this.Size = new Size(1280, 800);

            panelModelingInformation.Size = new Size(250, 800);
            panelModelingInformation.Location = new Point(this.Width - panelModelingInformation.Width, 0);

            labelSelectedElement.Visible = false;
            textBoxSelectedItemInformation.Visible = false;

            textBoxSelectedItemInformation.Size = new Size(225, 150);

            panelTimeManagment.Size = new Size(1030, 100);
            panelTimeManagment.Location = new Point(0, this.Height - panelTimeManagment.Height);

            labelTotalTime.Location = new Point(25, 25);
            labelTotalTimeValue.Location = new Point(labelTotalTime.Right + 10, 25);
        }

        private void ModelingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}