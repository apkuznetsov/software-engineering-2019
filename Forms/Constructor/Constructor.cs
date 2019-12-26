using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using GasStationMs.App.DB;
using GasStationMs.App.DB.Models;
using GasStationMs.App.TemplateElements;
using GasStationMs.App.Topology;
using GasStationMs.Dal;

namespace GasStationMs.App.Constructor
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

        public string CurrFilePath
        {
            get
            {
                return currFilePath;
            }
            set
            {
                currFilePath = value;
            }
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

            Point cursorPosition = dgvTopology.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo info = dgvTopology.HitTest(cursorPosition.X, cursorPosition.Y);
            var rb = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            DataGridViewImageCell cell = (DataGridViewImageCell)dgvTopology[info.ColumnIndex, info.RowIndex];
            if (cell.Tag == null)
            {
                bool isAdded = false;
                if (rb.Name == typeof(FuelDispenser).ToString())
                {
                    isAdded = topologyBuilder.AddFuelDispenser(info.ColumnIndex, info.RowIndex);
                    rbFuelDispenser.Checked = false;
                    if (!isAdded)
                        MessageBox.Show("невозможно добавить ТРК");
                }
                else if (rb.Name == typeof(CashCounter).ToString())
                {
                    isAdded = topologyBuilder.AddCashCounter(cell.ColumnIndex, cell.RowIndex);
                    rbCashCounter.Checked = false;
                    if (!isAdded)
                        MessageBox.Show("невозможно добавить кассу");
                }
                else if (rb.Name == typeof(FuelTank).ToString())
                {
                    rbFuelTank.Checked = false;
                    MessageBox.Show("невозможно добавить ТБ");
                }
                else if (rb.Name == typeof(Entry).ToString())
                {
                    rbEntry.Checked = false;
                    MessageBox.Show("невозможно добавить въезд");
                }
                else if (rb.Name == typeof(Exit).ToString())
                {
                    rbExit.Checked = false;
                    MessageBox.Show("невозможно добавить выезд");
                }
            }
            else if (cell.Tag is ServiceArea)
            {
                bool isAdded = false;
                if (rb.Name == typeof(FuelTank).ToString())
                {
                    isAdded = topologyBuilder.AddFuelTank(cell.ColumnIndex, cell.RowIndex);
                    rbFuelTank.Checked = false;
                    if (!isAdded)
                        MessageBox.Show("невозможно добавить ТБ");
                }
            }
            else if (cell.Tag is Road)
            {
                bool isAdded = false;
                if (rb.Name == typeof(Entry).ToString())
                {
                    isAdded = topologyBuilder.AddEntry(cell.ColumnIndex, cell.RowIndex);
                    rbEntry.Checked = false;
                    if (!isAdded)
                        MessageBox.Show("невозможно добавить въезд");
                }
                else if (rb.Name == typeof(Exit).ToString())
                {
                    isAdded = topologyBuilder.AddExit(cell.ColumnIndex, cell.RowIndex);
                    rbExit.Checked = false;
                    if (!isAdded)
                        MessageBox.Show("невозможно добавить выезд");
                }
                else if (rb.Name == typeof(FuelTank).ToString())
                {
                    rbFuelTank.Checked = false;
                    MessageBox.Show("невозможно добавить ТБ");
                }
                else if (rb.Name == typeof(CashCounter).ToString())
                {
                    rbCashCounter.Checked = false;
                    MessageBox.Show("невозможно добавить кассу");
                }
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
            SaveTopologyIntoCurrFilePath(topologyBuilder.ToTopology());
        }

        private void SaveTopologyIntoCurrFilePath(Topology.Topology topology)
        {
            try
            {
                if (topology == null)
                    throw new NullReferenceException();

                topology.Save(currFilePath);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDownloadTopology_Click(object sender, EventArgs e)
        {
            const string fileName = "Топология" + ".tplg";
            if (File.Exists(fileName))
            {
                Stream downloadingFileStream = File.OpenRead(fileName);

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
                SaveTopologyIntoCurrFilePath(topologyBuilder.ToTopology());
            }
        }

        private void btnToDistributionLawsForm_Click(object sender, EventArgs e)
        {
            try
            {
                DistributionLawsForm distributionLawsForm = new DistributionLawsForm(topologyBuilder.ToTopology());
                distributionLawsForm.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
