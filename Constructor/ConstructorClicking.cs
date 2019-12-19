using GasStationMs.App.Elements;
using GasStationMs.App.TemplateElements;
using System.Linq;
using System.Windows.Forms;

namespace GasStationMs.App
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
                        isAdded = topologyBuilder.AddFuelDispenser(cell.ColumnIndex, cell.RowIndex);
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить ТРК");
                    }
                    else if (rb.Name == typeof(CashCounter).ToString())
                    {
                        isAdded = topologyBuilder.AddCashCounter(cell.ColumnIndex, cell.RowIndex);
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
                        isAdded = topologyBuilder.AddFuelTank(cell.ColumnIndex, cell.RowIndex);
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
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить въезд");
                    }
                    else if (rb.Name == typeof(Exit).ToString())
                    {
                        isAdded = topologyBuilder.AddExit(cell.ColumnIndex, cell.RowIndex);
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
                    tbClickedCell.Text = cell.Tag.ToString();
                    //MessageBox.Show("невозможно добавить: ячейка уже занята");

                    panelClickedCell.Visible = true;

                    if (cell.Tag.ToString() == "ТРК: ")
                    {
                        label1.Visible = false;
                        numericUpDownVolume.Visible = false;
                        clickedFuelList.Visible = false;
                        textBoxChosenFuel.Visible = false;


                        label2.Visible = true;
                        numericUpDownFuelDispenserSpeed.Visible = true;
                        FuelDispenser clickedFuelDispenser = cell.Tag as FuelDispenser;
                        _selectedFuelDispenser = clickedFuelDispenser;
                        numericUpDownFuelDispenserSpeed.Value = clickedFuelDispenser.FuelFeedRateInLitersPerMinute;
                    }
                    else if (cell.Tag.ToString() == "Топливный бак: ")
                    {
                        label2.Visible = false;
                        numericUpDownFuelDispenserSpeed.Visible = false;


                        label1.Visible = true;
                        numericUpDownVolume.Visible = true;
                        clickedFuelList.Visible = true;
                        textBoxChosenFuel.Visible = true;
                        FuelTank clickedFuelTank = cell.Tag as FuelTank;
                        _selectedFuelTank = clickedFuelTank;
                        textBoxChosenFuel.Text = _selectedFuelTank.Fuel;
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
                    topologyBuilder.DeleteFuelDispenser();
                }
                else if (cell.Tag is FuelTank)
                {
                    topologyBuilder.DeleteFuelTank(cell.ColumnIndex, cell.RowIndex);
                    return;
                }
                else if (cell.Tag is CashCounter)
                {
                    topologyBuilder.DeleteCashCounter();
                }
                else if (cell.Tag is Entry)
                {
                    topologyBuilder.DeleteEntry(cell.ColumnIndex, cell.RowIndex);
                    return;
                }
                else if (cell.Tag is Exit)
                {
                    topologyBuilder.DeleteExit(cell.ColumnIndex, cell.RowIndex);
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