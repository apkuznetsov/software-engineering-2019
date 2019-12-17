using GasStationMs.App.Elements;
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
                if (cell.Tag == null)
                {
                    var rb = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

                    bool isAdded = false;
                    if (rb.Name == typeof(FuelDispenser).ToString())
                    {
                        isAdded = tb.AddFuelDispenser(cell.ColumnIndex, cell.RowIndex);
                        if (!isAdded)
                            MessageBox.Show("невозможно добавить ТРК");
                    }
                    else if (rb.Name == typeof(FuelTank).ToString())
                    {
                        if (tb.AddFuelTank())
                        {
                            FuelTank fuelTank = new FuelTank
                            {
                                Fuel = "топливо",
                                volume = 10000
                            };
                            cell.Tag = fuelTank;
                            cell.Value = rb.Image;
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить ТБ");
                        }
                    }
                    else if (rb.Name == typeof(CashCounter).ToString())
                    {
                        if (tb.AddCashCounter())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new CashCounter();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить кассу");
                        }
                    }
                    else if (rb.Name == typeof(Entry).ToString())
                    {
                        if (tb.AddEntry())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new Entry();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить въезд");
                        }
                    }
                    else if (rb.Name == typeof(Exit).ToString())
                    {
                        if (tb.AddExit())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new Exit();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить выезд");
                        }
                    }
                    else
                    {
                        cell.Value = rb.Image;
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
                        numericUpDownVolume.Value = _selectedFuelTank.volume;
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
                    tb.DeleteFuelDispenser();
                }
                else if (cell.Tag is FuelTank)
                {
                    tb.DeleteFuelTank();
                }
                else if (cell.Tag is CashCounter)
                {
                    tb.DeleteCashCounter();
                }
                else if (cell.Tag is Entry)
                {
                    tb.DeleteEntry();
                }
                else if (cell.Tag is Exit)
                {
                    tb.DeleteExit();
                }
                else
                {
                }

                cell.Tag = null;
                cell.Value = null;
            }
        }
    }
}