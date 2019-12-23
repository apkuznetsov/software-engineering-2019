using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using GasStationMs.App.DB;
using GasStationMs.App.Elements;
using GasStationMs.App.Topology;
using GasStationMs.App.Topology.TopologyBuilderHelpers;
using GasStationMs.Dal;

namespace GasStationMs.App
{
    public partial class Constructor : Form
    {
        private string currFilePath;
        private TopologyBuilder topologyBuilder;
        private DataTable _fuelDataTable;
        private FuelDispenser _selectedFuelDispenser;
        private FuelTank _selectedFuelTank;
        private GasStationContext _gasStationContext;
        private readonly SqlConnection _connection;
        private readonly CrudHelper _crudHelper;

        public Constructor(GasStationContext gasStationContext)
        {
            _gasStationContext = gasStationContext;
            _connection = ConnectionHelpers.OpenConnection();
            _crudHelper = new CrudHelper(_connection);
            InitializeComponent();

            topologyBuilder = new TopologyBuilder(dgvTopology);
            SetSettings();
            currFilePath = "Топология" + Topology.Topology.DotExt;
        }

        public TopologyBuilder TopologyBuilder
        {
            get
            {
                return topologyBuilder;
            }

        }

        private void TopologyConstructor_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        public string CurrFilePath { get; set; }

        #region события


        int oldColValue = GasStationMs.App.Topology.Topology.MinColsCount;
        private void cellsHorizontally_ValueChanged(object sender, EventArgs e)
        {

           // topologyBuilder.ColsCount = (int)cellsHorizontally.Value;

            if (oldColValue < (int)cellsHorizontally.Value)
            {
                for (int i = 0; i < ((int)cellsHorizontally.Value - oldColValue); i++)
                {
                    dgvTopology.Columns.Add(new BlankTopologyBuilderCol());
                }
                oldColValue = (int)cellsHorizontally.Value;
            }
            else
            {
                for (int i = 0; i < (oldColValue - (int)cellsHorizontally.Value); i++)
                {
                    dgvTopology.Columns.Remove(dgvTopology.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None));
                }
                oldColValue = (int)cellsHorizontally.Value;
            }

        }

        int oldRowValue = GasStationMs.App.Topology.Topology.MinRowsCount;
        private void cellsVertically_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    topologyBuilder.RowsCount = (int)cellsVertically.Value;
            //}
            //catch (CannotRemoveTopologyBuilderRow)
            //{
            //    cellsVertically.Value = topologyBuilder.RowsCount;
            //    MessageBox.Show("удалите ШЭ прежде чем удалить строку");
            //}
            if (oldRowValue < (int)cellsVertically.Value)
            {
                for (int i = 0; i < ((int)cellsVertically.Value - oldRowValue); i++)
                {
                    dgvTopology.Rows.Add(new DataGridViewRow());
                }
                
               oldRowValue = (int)cellsVertically.Value;
            }
            else
            {
                for (int i = 0; i < (oldRowValue - (int)cellsVertically.Value); i++)
                {
                    dgvTopology.Rows.RemoveAt(dgvTopology.Rows.GetLastRow(DataGridViewElementStates.Visible));
                }
                oldRowValue = (int)cellsVertically.Value;
            }


        }

        private void numericUpDownVolume_ValueChanged(object sender, EventArgs e)
        {
            _selectedFuelTank.Volume = (int)numericUpDownVolume.Value;
        }

        private void numericUpDownFuelDispenserSpeed_ValueChanged(object sender, EventArgs e)
        {

            _selectedFuelDispenser.FuelFeedRateInLitersPerMinute = (int)numericUpDownFuelDispenserSpeed.Value;
        }

        private void clickedFuelList_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataRowView row = clickedFuelList.SelectedItem as DataRowView;
            var fuel = (FuelModel)row["Fuel"];

            textBoxChosenFuel.Text = fuel.Name;
            _selectedFuelTank.Fuel = fuel.Name;

        }




        #endregion

        #region DbButtons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newFuelName = textBoxNewFuelName.Text;
            var newFuelPrice = Double.Parse(textBoxNewFuelPrice.Text);
            _crudHelper.AddFuelToDb(newFuelName, newFuelPrice);
            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _crudHelper.DeleteFuelFromDb(listFuels);
            LoadList();
        }

        #endregion  /DbButtons



        #region DbMethods
        internal void LoadList()
        {
            //var connection = OpenConnection();

            string rawSqlCommand = "SELECT * FROM Fuels";

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(rawSqlCommand, _connection);

            adapter.Fill(dataTable);

            DataTable fuelDataTable = new DataTable();

            // Create new DataColumn, set DataType, 
            // ColumnName and add to DataTable.    
            var column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Id";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            fuelDataTable.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = typeof(FuelModel);
            column.ColumnName = "Fuel";
            column.AutoIncrement = false;
            column.Caption = "Fuel";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            fuelDataTable.Columns.Add(column);


            foreach (DataRow dataTableRow in dataTable.Rows)
            {
                var id = Int32.Parse(dataTableRow["Id"].ToString());
                var name = dataTableRow["Name"].ToString();
                var price = Double.Parse(dataTableRow["Price"].ToString());

                var fuel = new FuelModel(name, price);

                var row = fuelDataTable.NewRow();
                row["id"] = id;
                row["Fuel"] = fuel;
                fuelDataTable.Rows.Add(row);
            }

            //listFuels.DataSource = dataTable;
            //listFuels.DisplayMember = "Name";
            //listFuels.ValueMember = "Id";
            this._fuelDataTable = fuelDataTable;
            listFuels.DataSource = fuelDataTable;
            listFuels.DisplayMember = "Fuel";
            listFuels.ValueMember = "Id";
        }
        #endregion /DbMethods


        private void listFuels_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = listFuels.SelectedItem as DataRowView;

            var fuel = (FuelModel)row["Fuel"];
            textBoxNewFuelName.Text = fuel.Name;
            textBoxNewFuelPrice.Text = fuel.Price.ToString();
            //textBoxNewFuelName.Text = row["Name"].ToString();
            //textBoxNewFuelPrice.Text = row["Price"].ToString();
        }

        private void TopologyConstructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionHelpers.CloseConnection(_connection);
        }

        private void btnSaveTopology_Click(object sender, EventArgs e)
        {
            SaveTopologyIntoCurrFilePath();
        }

        private void SaveTopologyIntoCurrFilePath()
        {
            Topology.Topology topology = topologyBuilder.ToTopology();
            topology.Save(currFilePath);
        }

        private void btnDownloadTopology_Click(object sender, EventArgs e)
        {
            const string FileName = "Топология" + ".tplg";
            if (File.Exists(FileName))
            {
                Stream downloadingFileStream = File.OpenRead(FileName);

                BinaryFormatter deserializer = new BinaryFormatter();
                Topology.Topology topology = (Topology.Topology)deserializer.Deserialize(downloadingFileStream);

                downloadingFileStream.Close();

                topologyBuilder.SetTopologyBuilder(topology);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            string dotExt = Topology.Topology.DotExt;
            string filter = " " + dotExt + "|" + "*" + dotExt;

            SaveFileDialog sfd = new SaveFileDialog
            {
                DefaultExt = dotExt,
                Filter = filter
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                currFilePath = sfd.FileName;
                SaveTopologyIntoCurrFilePath();
            }
        }
    }
}
