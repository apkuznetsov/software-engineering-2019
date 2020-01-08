using System;
using System.Drawing;
using GasStationMs.App.DB;
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

            _connection = ConnectionHelpers.OpenConnection();
            crudHelper = new CrudHelper(_connection);

            InitializeComponent();

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

            _connection = ConnectionHelpers.OpenConnection();
            crudHelper = new CrudHelper(_connection);

            InitializeComponent();

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
            {
                dgvField.Columns[i].Width = CellSizeInPx;
            }

            for (int j = 0; j < dgvField.RowCount; j++)
            {
                dgvField.Rows[j].Height = CellSizeInPx;
            }
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
            FuelDispenser.Image = new Bitmap(Properties.Resources.Fuel, CellSizeInPx, CellSizeInPx);
            FuelTank.Image = new Bitmap(Properties.Resources.FuelTank, CellSizeInPx, CellSizeInPx);
            CashCounter.Image = new Bitmap(Properties.Resources.CashCounter, CellSizeInPx, CellSizeInPx);
            Entry.Image = new Bitmap(Properties.Resources.Entry, CellSizeInPx, CellSizeInPx);
            Exit.Image = new Bitmap(Properties.Resources.Exit, CellSizeInPx, CellSizeInPx);
            ServiceArea.Image = new Bitmap(Properties.Resources.ServiceArea, CellSizeInPx, CellSizeInPx);
            Road.Image = new Bitmap(Properties.Resources.Road, CellSizeInPx, CellSizeInPx);
        }
    }
}
