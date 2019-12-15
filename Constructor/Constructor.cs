using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GasStationMs.App.DB;
using GasStationMs.App.Topology;
using GasStationMs.Dal;

namespace GasStationMs.App
{
    public partial class Constructor : Form
    {
        private TopologyBuilder tb;

        private GasStationContext _gasStationContext;
        private readonly SqlConnection _connection;
        private readonly CrudHelper _crudHelper;

        public Constructor(GasStationContext gasStationContext)
        {
            _gasStationContext = gasStationContext;
            _connection = ConnectionHelpers.OpenConnection();
            _crudHelper = new CrudHelper(_connection);
            InitializeComponent();

            tb = new TopologyBuilder(dgvTopology);

            SetSettings();
        }

        private void TopologyConstructor_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        #region события
        int oldValue = Topology.Topology.MinColsCount;
        private void cellsHorizontally_ValueChanged(object sender, EventArgs e)
        {
            if (oldValue < (int)cellsHorizontally.Value)
            {
                for (int i = 0; i < ((int)cellsHorizontally.Value - oldValue); i++)
                {
                    dgvTopology.Columns.Add(new CustomImageColumn(Properties.Resources.Blank));
                }
                oldValue = (int)cellsHorizontally.Value;
            }
            else
            {
                for (int i = 0; i < (oldValue - (int)cellsHorizontally.Value); i++)
                {
                    dgvTopology.Columns.Remove(dgvTopology.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None));
                }
                oldValue = (int)cellsHorizontally.Value;
            }
        
        

    }

        private void cellsVertically_ValueChanged(object sender, EventArgs e)
        {
            dgvTopology.RowCount = (int)cellsVertically.Value;
            // добавляем и удаляем предпоследний ряд а не последний 
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
    }
}
