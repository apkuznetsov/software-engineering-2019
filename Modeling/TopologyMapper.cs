using GasStationMs.App.DB.Models;
using GasStationMs.App.Forms;
using GasStationMs.App.TemplateElements;
using System.Drawing;
using GasStationMs.App.Modeling.MovingLogic;
using GasStationMs.App.Models;
using static GasStationMs.App.Modeling.ElementPictureBoxProducer;
using static GasStationMs.App.Modeling.ElementSizeDefiner;
using static GasStationMs.App.Modeling.ElementViewProducer;

namespace GasStationMs.App.Modeling
{
    internal static class TopologyMapper
    {
        private static ModelingForm _modelingForm;
        private static Topology.Topology _topology;
        private static MappedTopology _mappedTopology;


        internal static MappedTopology MapTopology(ModelingForm modelingForm, 
            Topology.Topology topology, TrafficFlow trafficFlow)
        {
            _modelingForm = modelingForm;
            _topology = topology;
            ModelSettings.SetUpModelSettings(trafficFlow);
            _mappedTopology = new MappedTopology();
            ElementPictureBoxProducer.SetUpElementPictureBoxProducer(modelingForm, _mappedTopology);

            SetupPlaygroundPanel();
            SetupServiceArea();

            DestinationPointsDefiner.DefineElementsPoints(_mappedTopology);

            return _mappedTopology;
        }

        private static void SetupPlaygroundPanel()
        {
            var panelPlayground = _modelingForm.PlaygroundPanel;
            PanelPlaygroundWidth = _topology.ColsCount * TopologyCellSize;
            PanelPlaygroundHeight = _topology.RowsCount * TopologyCellSize + 1 * TopologyCellSize;

            DestinationPointsDefiner.DefineCommonPoints();

            panelPlayground.Size = new Size(PanelPlaygroundWidth, PanelPlaygroundHeight);

            for (int i = 0; i < _topology.RowsCount; i++)
            {
                for (int j = 0; j < _topology.ColsCount; j++)
                {
                    var topologyElement = _topology[j, i];

                    if (topologyElement == null)
                    {
                        continue;
                    }

                    var creationPointX = j * TopologyCellSize;
                    var creationPointY = i * TopologyCellSize;

                    var creationPoint = new Point(creationPointX, creationPointY);

                    if (topologyElement is CashCounter)
                    {
                        CreateCashCounter(creationPoint);
                    }

                    if (topologyElement is Entry)
                    {
                        CreateEnter(creationPoint);
                    }

                    if (topologyElement is Exit)
                    {
                        CreateExit(creationPoint);
                    }


                    if (topologyElement is FuelDispenser fuelDispenser)
                    {
                        CreateFuelDispenser(fuelDispenser, creationPoint);
                    }

                    if (topologyElement is FuelTank fuelTank)
                    {
                        CreateFuelTank(fuelTank, creationPoint);
                        ModelSettings.AddUniqueFuel(fuelTank.Fuel);
                    }
                }
            }

            panelPlayground.MouseClick += ClickEventProvider.PlaygroundPanel_Click;
        }

        private static void SetupServiceArea()
        {
            var pictureBoxServiceArea = _modelingForm.PictureBoxServiceArea;
            var width = (_topology.ColsCount - _topology.FirstBorderPoint.X) * TopologyCellSize;
            var height = (_topology.RowsCount - 1) * TopologyCellSize;

            var creationPointX = _topology.FirstBorderPoint.X * TopologyCellSize;
            var creationPointY = _topology.FirstBorderPoint.Y * TopologyCellSize;
            var creationPoint = new Point(creationPointX, creationPointY);

            pictureBoxServiceArea.Location = creationPoint;
            pictureBoxServiceArea.Size = new Size(width, height);
            pictureBoxServiceArea.BackColor = Color.Wheat;

            pictureBoxServiceArea.MouseClick += ClickEventProvider.ServiceArea_Click;

            _mappedTopology.ServiceArea = pictureBoxServiceArea;
        }

        #region CashCounter

        private static void CreateCashCounter(Point creationPoint)
        {
            var cashCounterView = CreateCashCounterView("Cash Counter", CashCounter.MaxCashInRubles);
            _mappedTopology.CashCounter = CreateCashCounterPictureBox(cashCounterView, creationPoint);
        }

        #endregion /CashCounter

        #region Enter/Exit

        private static void CreateEnter(Point creationPoint)
        {
            _mappedTopology.Enter = CreateEnterPictureBox(creationPoint);
        }

        private static void CreateExit(Point creationPoint)
        {
            _mappedTopology.Exit = CreateExitPictureBox(creationPoint);
        }

        #endregion /Enter/Exit

        #region FuelDispensers

        private static void CreateFuelDispenser(FuelDispenser fuelDispenser, Point creationPoint)
        {
            var speedOfFilling = fuelDispenser.FuelFeedRateInLitersPerMinute;
            //var speedOfFilling = 15;
            var fuelView = CreateFuelDispenserView("Fuel Dispenser", speedOfFilling);

            CreateFuelDispenserPictureBox(fuelView, creationPoint);
        }

        #endregion /FuelDispensers

        #region FuelTanks

        private static void CreateFuelTank(FuelTank fuelTank, Point creationPoint)
        {
            var fuel = fuelTank.Fuel;
            var volume = fuelTank.Volume;
            var currentFullness = fuelTank.OccupiedVolume;

            // test
            //FuelModel fuel = new FuelModel(1, "АИ-92", 42.9);
            //var volume = 10000;
            //var currentFullness = 5000;
            // /test

            var fuelTankView = CreateFuelTankView("Fuel Tank", volume, currentFullness, fuel);
            CreateFuelTankPictureBox(fuelTankView, creationPoint);
        }

        #endregion /FuelTanks
    }
}
