using System;
using System.Drawing;
using GasStationMs.App.DB;
using GasStationMs.App.Properties;
using GasStationMs.App.TemplateElements;
using GasStationMs.App.Topology;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor
    {
        public static readonly int CellSizeInPx = 30;

        public Constructor(string fullFilePath, Topology.Topology topology)
        {
            this.fullFilePath = fullFilePath ?? throw new NullReferenceException();

            if (topology == null)
                throw new NullReferenceException();

            InitializeComponent();
            connection = ConnectionHelpers.OpenConnection();
            crudHelper = new CrudHelper(connection);

            SetupSettings();
            topologyBuilder = new TopologyBuilder(dgvField, topology);
        }

        public Constructor(string fullFilePath, int cols, int rows)
        {
            this.fullFilePath = fullFilePath ?? throw new NullReferenceException();

            if (cols < Topology.Topology.MinColsCount ||
                cols > Topology.Topology.MaxColsCount)
                throw new ArgumentOutOfRangeException();

            if (rows < Topology.Topology.MinRowsCount ||
                rows > Topology.Topology.MaxRowsCount)
                throw new ArgumentOutOfRangeException();

            InitializeComponent();
            connection = ConnectionHelpers.OpenConnection();
            crudHelper = new CrudHelper(connection);

            SetupSettings();
            topologyBuilder = new TopologyBuilder(dgvField, cols, rows); ;
        }

        private void SetupSettings()
        {
            SetupCellsSize();
            SetupRbsNames();
            SetupTemplateElementsImages();
        }

        private void SetupCellsSize()
        {
            for (int i = 0; i < dgvField.ColumnCount; i++)
                dgvField.Columns[i].Width = CellSizeInPx;

            for (int j = 0; j < dgvField.RowCount; j++)
                dgvField.Rows[j].Height = CellSizeInPx;
        }

        private void SetupRbsNames()
        {
            rbFuelDispenser.Name = typeof(FuelDispenser).ToString();
            rbFuelTank.Name = typeof(FuelTank).ToString();
            rbCashCounter.Name = typeof(CashCounter).ToString();
            rbEntry.Name = typeof(Entry).ToString();
            rbExit.Name = typeof(Exit).ToString();
        }

        private void SetupTemplateElementsImages()
        {
            FuelDispenser.Image = new Bitmap(Resources.Fuel, CellSizeInPx, CellSizeInPx);
            FuelTank.Image = new Bitmap(Resources.FuelTank, CellSizeInPx, CellSizeInPx);
            CashCounter.Image = new Bitmap(Resources.CashCounter, CellSizeInPx, CellSizeInPx);
            Entry.Image = new Bitmap(Resources.Entry, CellSizeInPx, CellSizeInPx);
            Exit.Image = new Bitmap(Resources.Exit, CellSizeInPx, CellSizeInPx);
            ServiceArea.Image = new Bitmap(Resources.ServiceArea, CellSizeInPx, CellSizeInPx);
            Road.Image = new Bitmap(Resources.Road, CellSizeInPx, CellSizeInPx);
        }
    }
}
