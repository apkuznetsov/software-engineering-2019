using System.Linq;
using System.Windows.Forms;
using GasStationMs.App.TemplateElements;

namespace GasStationMs.App.Constructor
{
    public partial class Constructor
    {
        private static readonly string cannotAddCashCounter = "невозможно добавить КАССУ: касса может быть расположена только на АЗС";
        private static readonly string cannotAddFuelTank = "невозможно добавить ТБ: ТБ может быть расположен только на служебной зоне";
        private static readonly string cannotAddFuelDispenser = "невозможно добавить ТРК: ТРК может быть расположена только на АЗС";
        private static readonly string cannotAddEntry = "невозможно добавить ВЪЕЗД: въезд может быть расположен только на дороге";
        private static readonly string cannotAddExit = "невозможно добавить ВЫЕЗД: выезд может быть расположен только на дороге";

        private void dgvField_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)dgvField.Rows[e.RowIndex].Cells[e.ColumnIndex];

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
                    AddElementToBlankCell(cell, rb);
                }
                else if (cell.Tag is ServiceArea)
                {
                    AddElementToServiceAreaCell(cell, rb);
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
                    gbClickedCell.Text = cell.Tag.ToString();

                    gbClickedCell.Visible = true;

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

        private void AddElementToBlankCell(DataGridViewImageCell cell, RadioButton rb)
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
                MessageBox.Show(cannotAddFuelTank);
            }
            else if (rb.Name == typeof(Entry).ToString())
            {
                MessageBox.Show(cannotAddEntry);
            }
            else if (rb.Name == typeof(Exit).ToString())
            {
                MessageBox.Show(cannotAddExit);
            }
        }

        private void AddElementToServiceAreaCell(DataGridViewImageCell cell, RadioButton rb)
        {
            bool isAdded = false;

            if (rb.Name == typeof(FuelTank).ToString())
            {
                isAdded = topologyBuilder.AddFuelTank(cell.ColumnIndex, cell.RowIndex);

                if (!isAdded)
                    MessageBox.Show("невозможно добавить ТБ");
            }
            else if (rb.Name == typeof(FuelDispenser).ToString())
            {
                MessageBox.Show(cannotAddFuelDispenser);
            }
            else if (rb.Name == typeof(CashCounter).ToString())
            {
                MessageBox.Show(cannotAddCashCounter);
            }
            else if (rb.Name == typeof(Entry).ToString())
            {
                MessageBox.Show(cannotAddEntry);
            }
            else if (rb.Name == typeof(Exit).ToString())
            {
                MessageBox.Show(cannotAddExit);
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