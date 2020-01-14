using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using GasStationMs.App.DB;
using GasStationMs.App.DB.Models;
using GasStationMs.App.Properties;
using GasStationMs.App.Topology;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor : Form
    {
        private string fullFilePath;
        private TopologyBuilder topologyBuilder;

        private readonly SqlConnection connection;
        private DataTable fuelDataTable;

        private void Constructor_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        internal void LoadList()
        {
            string rawSqlCommand = "SELECT * FROM Fuels";

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(rawSqlCommand, connection);
            adapter.Fill(dataTable);

            DataTable fuelDataTable = new DataTable();

            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Id";
            column.ReadOnly = true;
            column.Unique = true;

            fuelDataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(FuelModel);
            column.ColumnName = "Fuel";
            column.AutoIncrement = false;
            column.Caption = "Fuel";
            column.ReadOnly = false;
            column.Unique = false;
            fuelDataTable.Columns.Add(column);

            foreach (DataRow dataTableRow in dataTable.Rows)
            {
                int id = int.Parse(dataTableRow["Id"].ToString());
                string name = dataTableRow["Name"].ToString();
                double price = double.Parse(dataTableRow["Price"].ToString());

                var fuel = new FuelModel(name, price);

                var row = fuelDataTable.NewRow();
                row["id"] = id;
                row["Fuel"] = fuel;
                fuelDataTable.Rows.Add(row);
            }

            this.fuelDataTable = fuelDataTable;
        }

        private void Constructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionHelpers.CloseConnection(connection);
        }

        #region drag-and-drop
        private void rbFuelDispenser_mouseDown(object sender, MouseEventArgs e)
        {
            rbFuelDispenser.Checked = true;
            canCheckRbFuelDispenser = false;
            rbFuelDispenser.DoDragDrop(rbFuelDispenser.Image, DragDropEffects.Copy);
        }

        private void rbFuelTank_mouseDown(object sender, MouseEventArgs e)
        {
            rbFuelTank.Checked = true;
            canCheckRbFuelTank = false;
            rbFuelTank.DoDragDrop(rbFuelTank.Image, DragDropEffects.Copy);
        }

        private void rbCashCounter_mouseDown(object sender, MouseEventArgs e)
        {
            rbCashCounter.Checked = true;
            canCheckRbCashCounter = false;
            rbCashCounter.DoDragDrop(rbFuelTank.Image, DragDropEffects.Copy);
        }

        private void rbEntry_mouseDown(object sender, MouseEventArgs e)
        {
            rbEntry.Checked = true;
            canCheckRbEntry = false;
            rbEntry.DoDragDrop(rbEntry.Image, DragDropEffects.Copy);
        }

        private void rbExit_mouseDown(object sender, MouseEventArgs e)
        {
            rbExit.Checked = true;
            canCheckRbExit = false;
            rbExit.DoDragDrop(rbExit.Image, DragDropEffects.Copy);
        }

        private void dgvField_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dgvField_DragDrop(object sender, DragEventArgs e)
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
        #endregion /drag-and-drop

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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullFilePath = System.IO.Path.GetFullPath(Resources.ConstructorPage);
            System.Diagnostics.Process.Start(fullFilePath);
        }

        private void оРазбработчикахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDevs aboutDevs = new AboutDevs();
            aboutDevs.ShowDialog();

            aboutDevs.Dispose();
            aboutDevs.Close();
        }

        private void btnOpenChooseDistributionLaw_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseDistributionLaw chooseDistributionLaw = new ChooseDistributionLaw(topologyBuilder.ToTopology());
                chooseDistributionLaw.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
