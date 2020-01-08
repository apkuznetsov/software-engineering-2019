using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GasStationMs.App.DB;
using GasStationMs.App.DB.Models;
using GasStationMs.App.TemplateElements;
using GasStationMs.App.Topology;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor : Form
    {
        private string fullFilePath;
        private TopologyBuilder topologyBuilder;

        private DataTable fuelDataTable;
        private readonly SqlConnection _connection;
        private readonly CrudHelper _crudHelper;

        private void TopologyConstructor_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        #region события
        private void rbFuelDispenser_mouseDown(object sender, MouseEventArgs e)
        {
            rbFuelDispenser.Checked = true;
            _isCheckedradioButtonFuelDispenser = false;
            rbFuelDispenser.DoDragDrop(rbFuelDispenser.Image, DragDropEffects.Copy);
        }
        private void rbFuelTank_mouseDown(object sender, MouseEventArgs e)
        {
            rbFuelTank.Checked = true;
            _isCheckedradioButtonFuelTank = false;
            rbFuelTank.DoDragDrop(rbFuelTank.Image, DragDropEffects.Copy);
        }

        private void rbCashCounter_mouseDown(object sender, MouseEventArgs e)
        {
            rbCashCounter.Checked = true;
            _isCheckedRbCashCounter = false;
            rbCashCounter.DoDragDrop(rbFuelTank.Image, DragDropEffects.Copy);
        }

        private void rbEntry_mouseDown(object sender, MouseEventArgs e)
        {
            rbEntry.Checked = true;
            _isCheckedRbEntry = false;
            rbEntry.DoDragDrop(rbEntry.Image, DragDropEffects.Copy);
        }

        private void rbExit_mouseDown(object sender, MouseEventArgs e)
        {
            rbExit.Checked = true;
            _isCheckedRbExit = false;
            rbExit.DoDragDrop(rbExit.Image, DragDropEffects.Copy);
        }

        private void DataGridView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void DataGridView_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Point cursorPosition = dgvField.PointToClient(Cursor.Position);
                DataGridView.HitTestInfo hitTestInfo = dgvField.HitTest(cursorPosition.X, cursorPosition.Y);
                DataGridViewImageCell cell = (DataGridViewImageCell)dgvField[hitTestInfo.ColumnIndex, hitTestInfo.RowIndex];

                AddElement(cell);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newFuelName = textBoxNewFuelName.Text;
            var newFuelPrice = Double.Parse(textBoxNewFuelPrice.Text);
            _crudHelper.AddFuelToDb(newFuelName, newFuelPrice);
            LoadList();
        }

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
            this.fuelDataTable = fuelDataTable;
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

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Topology.Topology topology = topologyBuilder.ToTopology();
                TopologySaverAndLoader.Save(fullFilePath, topology);
                MessageBox.Show("Топология сохраненена в\n" + fullFilePath);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSaveTopologyAs_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                DefaultExt = TopologySaverAndLoader.DotExt,
                Filter = TopologySaverAndLoader.Filter
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = sfd.FileName;
                Topology.Topology topology = topologyBuilder.ToTopology();
                TopologySaverAndLoader.Save(fullFilePath, topology);
            }
        }

        private void btnToDistributionLawsForm_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseDistributionLaw distributionLawsForm = new ChooseDistributionLaw(topologyBuilder.ToTopology());
                distributionLawsForm.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
