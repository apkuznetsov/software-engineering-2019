using GasStationMs.App.Modeling;
using System;
using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.Models;
using static GasStationMs.App.Modeling.ModelingTimeManager;

namespace GasStationMs.App.Forms
{
    public partial class ModelingForm : Form
    {
        private readonly MappedTopology _mappedTopology;

        public PictureBox SelectedItem { get; set; }
        public Panel PlaygroundPanel { get; private set; }
        public Label LabelSelectedElement { get; private set; }
        public Label LabelCashCounterSumValue { get; private set; }
        public TextBox TextBoxSelectedItemInformation { get; private set; }
        public PictureBox PictureBoxServiceArea { get; private set; }

        public PictureBox ButtonPausePlay { get; set; }
        public Label LabelModelState { get; private set; }
        public Timer ModelingTimer { get; private set; }
        public ModelingForm(Topology.Topology topology, TrafficFlow trafficFlow)
        {
            InitializeComponent();
            RemoveUnusedControls();
            DefineProperties();
            LocateFormElements();
            SetUpModelingTimeManager(timerModeling);

            ElementSizeDefiner.TopologyCellSize = 50;

            ClickEventProvider.SetUpClickEventProvider(this);
            pictureBoxPauseAndPlay.MouseClick += ClickEventProvider.PictureBoxPauseAndPlay_Click;

            _mappedTopology = TopologyMapper.MapTopology(this, topology, trafficFlow);

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
            ModelingTimer = timerModeling;
            ButtonPausePlay = pictureBoxPauseAndPlay;
            LabelModelState = labelModelState;
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

            pictureBoxPauseAndPlay.Size = new Size(30, 30);
            pictureBoxPauseAndPlay.Location = new Point(panelTimeManagment.Right - 80, 15);
        }

        private void ModelingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}