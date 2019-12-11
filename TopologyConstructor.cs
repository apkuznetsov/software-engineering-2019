using GasStationMs.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasStationMs.App.DB;
using GasStationMs.Dal;
using GasStationMs.App.Models;

namespace GasStationMs.App
{
    public partial class TopologyConstructor : Form
    {
        private GasStationContext _gasStationContext;
        private readonly SqlConnection _connection;
        private readonly CrudHelper _crudHelper;

        public TopologyConstructor(GasStationContext gasStationContext)
        {
            _gasStationContext = gasStationContext;
            _connection = ConnectionHelpers.OpenConnection();
            _crudHelper = new CrudHelper(_connection);
            InitializeComponent();

            SetSettings();
        }

        private void TopologyConstructor_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        #region события
        private void cellsHorizontally_ValueChanged(object sender, EventArgs e)
        {
            fillingStationField.ColumnCount = (int)cellsHorizontally.Value;
            // передалать потому что добавляются текст колонки а не imagecolumn

        }

        private void cellsVertically_ValueChanged(object sender, EventArgs e)
        {
            fillingStationField.RowCount = (int)cellsVertically.Value;
            // добавляем и удаляем предпоследний ряд а не последний 
        }
        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void fillingStationField_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewImageCell cell = (DataGridViewImageCell)fillingStationField.Rows[e.RowIndex].Cells[e.ColumnIndex];


            if (Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                var radioButton = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

                if (radioButton.Name == "radioButtonFuelDispenser")
                {
                    if (Topology.CanAddFuelDispenser())
                    {
                        cell.Value = radioButton.Image;
                        Topology.AddFuelDispenser();
                    }
                    else
                    {
                        MessageBox.Show("невозможно добавить ТРК");
                    }
                }
                else if (radioButton.Name == "radioButtonFuelTank")
                {
                    if (Topology.CanAddFuelTank())
                    {
                        cell.Value = radioButton.Image;
                        Topology.AddFuelTank();
                    }
                    else
                    {
                        MessageBox.Show("невозможно добавить ТБ");
                    }
                }
                else
                {
                    cell.Value = radioButton.Image;
                }
            }
        }

        bool isCheckedradioButtonFuelDispenser = false;
        private void radioButtonFuelDispenser_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedradioButtonFuelDispenser = radioButtonFuelDispenser.Checked;
        }

        private void radioButtonFuelDispenser_Click(object sender, EventArgs e)
        {
            if (radioButtonFuelDispenser.Checked && !isCheckedradioButtonFuelDispenser)
                radioButtonFuelDispenser.Checked = false;
            else
            {
                radioButtonFuelDispenser.Checked = true;
                isCheckedradioButtonFuelDispenser = false;
            }
        }

        bool isCheckedradioButtonFuelTank = false;
        private void radioButtonFuelTank_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedradioButtonFuelTank = radioButtonFuelTank.Checked;
        }

        private void radioButtonFuelTank_Click(object sender, EventArgs e)
        {
            if (radioButtonFuelTank.Checked && !isCheckedradioButtonFuelTank)
                radioButtonFuelTank.Checked = false;
            else
            {
                radioButtonFuelTank.Checked = true;
                isCheckedradioButtonFuelTank = false;
            }
        }


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

            var fuel = (FuelModel) row["Fuel"];
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
