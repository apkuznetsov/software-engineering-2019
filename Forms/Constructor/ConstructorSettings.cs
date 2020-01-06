using System;
using System.Drawing;
using GasStationMs.App.DB;
using GasStationMs.App.TemplateElements;
using GasStationMs.App.Topology;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor
    {
        const int CellSizeInPx = 30;

        public Constructor(string fullFilePath, Topology.Topology topology)
        {
            if (fullFilePath == null ||
                topology == null)
                throw new NullReferenceException();

            _connection = ConnectionHelpers.OpenConnection();
            _crudHelper = new CrudHelper(_connection);
            InitializeComponent();

            this.fullFilePath = fullFilePath;
            SetSettings();
            topologyBuilder = new TopologyBuilder(dgvTopology, topology);
        }

        public Constructor(string fullFilePath, int cols, int rows)
        {
            if (cols < Topology.Topology.MinColsCount ||
                cols > Topology.Topology.MaxColsCount)
                throw new ArgumentOutOfRangeException();

            if (rows < Topology.Topology.MinRowsCount ||
                rows > Topology.Topology.MaxRowsCount)
                throw new ArgumentOutOfRangeException();

            _connection = ConnectionHelpers.OpenConnection();
            _crudHelper = new CrudHelper(_connection);
            InitializeComponent();

            SetSettings();
            topologyBuilder = new TopologyBuilder(dgvTopology, cols, rows); ;
        }

        private void SetSettings()
        {
            SetCellsSize();
            SetRbsNames();
            SetTemplateElementsImages();
        }

        private void SetCellsSize()

        {
            for (int i = 0; i < dgvTopology.ColumnCount; i++)
            {
                dgvTopology.Columns[i].Width = CellSizeInPx;
            }

            for (int j = 0; j < dgvTopology.RowCount; j++)
            {
                dgvTopology.Rows[j].Height = CellSizeInPx;
            }
        }

        private void SetTemplateElementsImages()
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
