using System.Linq;
using System.Windows.Forms;
using GasStationMs.App.TemplateElements;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor
    {
        private void dgvTopology_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)dgvTopology.Rows[e.RowIndex].Cells[e.ColumnIndex];

            switch (e.Button)
            {
                case MouseButtons.Left:
                    AddElement(cell);
                    break;
                case MouseButtons.Right:
                    DeleteElement(cell);
                    break;
                default:
                    break;
            }
        }

        private void AddElement(DataGridViewImageCell cell)
        {
            if (Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                var rb = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

                if (cell.Tag == null)
                {
                    bool isAdded = false;
                    if (rb.Name == typeof(FuelDispenser).ToString())
                    {
                        isAdded = _topologyBuilder.AddFuelDispenser(cell.ColumnIndex, cell.RowIndex);
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить ТРК");
                    }
                    else if (rb.Name == typeof(CashCounter).ToString())
                    {
                        isAdded = _topologyBuilder.AddCashCounter(cell.ColumnIndex, cell.RowIndex);
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить кассу");
                    }
                    else if (rb.Name == typeof(FuelTank).ToString())
                    {
                        MessageBox.Show("невозможно добавить ТБ");
                    }
                    else if (rb.Name == typeof(Entry).ToString())
                    {
                        MessageBox.Show("невозможно добавить въезд");
                    }
                    else if (rb.Name == typeof(Exit).ToString())
                    {
                        MessageBox.Show("невозможно добавить выезд");
                    }
                }
                else if (cell.Tag is ServiceArea)
                {
                    bool isAdded = false;
                    if (rb.Name == typeof(FuelTank).ToString())
                    {
                        isAdded = _topologyBuilder.AddFuelTank(cell.ColumnIndex, cell.RowIndex);
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить ТБ");
                    }
                }
                else if (cell.Tag is Road)
                {
                    bool isAdded = false;
                    if (rb.Name == typeof(Entry).ToString())
                    {
                        isAdded = _topologyBuilder.AddEntry(cell.ColumnIndex, cell.RowIndex);
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить въезд");
                    }
                    else if (rb.Name == typeof(Exit).ToString())
                    {
                        isAdded = _topologyBuilder.AddExit(cell.ColumnIndex, cell.RowIndex);
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить выезд");
                    }
                    else if (rb.Name == typeof(FuelTank).ToString())
                    {
                        MessageBox.Show("невозможно добавить ТБ");
                    }
                    else if (rb.Name == typeof(CashCounter).ToString())
                    {
                        MessageBox.Show("невозможно добавить кассу");
                    }
                }
                else
                {
                    labelClickedTeName.Text = cell.Tag.ToString();

                    panelClickedCell.Visible = true;

                    if (cell.Tag is FuelDispenser)
                    {
                        labelMainTeProperty.Visible = true;
                        labelMainTeProperty.Text = "Скорость подачи топлива";


                        numericUpDownVolume.Visible = false;
                        clickedFuelList.Visible = false;
                        textBoxChosenFuel.Visible = false;


                        numericUpDownFuelDispenserSpeed.Visible = true;
                        FuelDispenser clickedFuelDispenser = cell.Tag as FuelDispenser;
                        _selectedFuelDispenser = clickedFuelDispenser;
                        numericUpDownFuelDispenserSpeed.Value = clickedFuelDispenser.FuelFeedRateInLitersPerMinute;
                    }
                    else if (cell.Tag is FuelTank)
                    {
                        labelMainTeProperty.Visible = true;
                        labelMainTeProperty.Text = "Объём";


                        numericUpDownFuelDispenserSpeed.Visible = false;


                        numericUpDownVolume.Visible = true;
                        clickedFuelList.Visible = true;
                        textBoxChosenFuel.Visible = true;
                        FuelTank clickedFuelTank = cell.Tag as FuelTank;
                        _selectedFuelTank = clickedFuelTank;
                        textBoxChosenFuel.Text = _selectedFuelTank.Fuel.Name;
                        clickedFuelList.DisplayMember = "Fuel";
                        clickedFuelList.ValueMember = "Id";
                        clickedFuelList.DataSource = _fuelDataTable;
                        numericUpDownVolume.Value = _selectedFuelTank.Volume;
                    }
                }
            }
        }


        private void DeleteElement(DataGridViewImageCell cell)
        {
            bool canDelete = (cell.Tag != null);

            if (canDelete)
            {
                if (cell.Tag is FuelDispenser)
                {
                    _topologyBuilder.DeleteFuelDispenser();
                }
                else if (cell.Tag is FuelTank)
                {
                    _topologyBuilder.DeleteFuelTank(cell.ColumnIndex, cell.RowIndex);
                    return;
                }
                else if (cell.Tag is CashCounter)
                {
                    _topologyBuilder.DeleteCashCounter();
                }
                else if (cell.Tag is Entry)
                {
                    _topologyBuilder.DeleteEntry(cell.ColumnIndex, cell.RowIndex);
                    return;
                }
                else if (cell.Tag is Exit)
                {
                    _topologyBuilder.DeleteExit(cell.ColumnIndex, cell.RowIndex);
                    return;
                }
                else if (cell.Tag is ServiceArea)
                {
                    return;
                }
                else if (cell.Tag is Road)
                {
                    return;
                }

                cell.Tag = null;
                cell.Value = null;
            }
        }
    }
}