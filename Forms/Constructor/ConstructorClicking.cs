using System;
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

        private IGasStationElement clickedElement;

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
                    AddElementToRoadCell(cell, rb);
                }
                else
                {
                    ShowElementProperties(cell);
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
            else
            {
                throw new InvalidCastException();
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
            else
            {
                throw new InvalidCastException();
            }
        }

        private void AddElementToRoadCell(DataGridViewImageCell cell, RadioButton rb)
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
                MessageBox.Show(cannotAddFuelTank);
            }
            else if (rb.Name == typeof(FuelDispenser).ToString())
            {
                MessageBox.Show(cannotAddFuelDispenser);
            }
            else if (rb.Name == typeof(CashCounter).ToString())
            {
                MessageBox.Show(cannotAddCashCounter);
            }
            else
            {
                throw new InvalidCastException();
            }
        }

        private void ShowElementProperties(DataGridViewImageCell cell)
        {
            clickedElement = null;

            gbClickedCell.Text = cell.Tag.ToString();
            gbClickedCell.Visible = true;

            MakePropertiesControls1Invisible();
            MakePropertiesControls2Invisible();

            if (cell.Tag is CashCounter)
            {
                ShowClickedCashCounterProperties(cell);
            }
            else if (cell.Tag is Entry)
            {
                ShowClickedEntryProperties(cell);
            }
            else if (cell.Tag is Exit)
            {
                ShowClickedExitProperties(cell);
            }
            else if (cell.Tag is FuelDispenser)
            {
                ShowClickedFuelDispenserProperties(cell);
            }
            else if (cell.Tag is FuelTank)
            {
                ShowClickedFuelTankProperties(cell);
            }
        }

        private void MakePropertiesControls1Invisible()
        {
            labelElementProperty1.Visible = false;
            nudElementProperty1.Visible = false;
        }

        private void MakePropertiesControls2Invisible()
        {
            labelElementProperty2.Visible = false;
            nudElementProperty2.Visible = false;

            clickedFuelList.Visible = false;
            textBoxChosenFuel.Visible = false;
        }

        private void MakePropertiesControls1Visible()
        {
            labelElementProperty1.Visible = true;
            nudElementProperty1.Visible = true;
        }

        private void MakePropertiesControls2Visible()
        {
            labelElementProperty2.Visible = true;
            nudElementProperty2.Visible = true;

            clickedFuelList.Visible = true;
            textBoxChosenFuel.Visible = true;
        }

        private void ShowClickedCashCounterProperties(DataGridViewImageCell cell)
        {
            MakePropertiesControls1Visible();

            labelElementProperty1.Text = "Денег в кассе";

            nudElementProperty1.Minimum = CashCounter.MinCashInRubles;
            nudElementProperty1.Maximum = CashCounter.MaxCashInRubles;

            CashCounter clickedCashCounter = cell.Tag as CashCounter;
            nudElementProperty1.Value = clickedCashCounter.CashInRubles;
            clickedElement = clickedCashCounter;
        }

        private void nudElementProperty1_ValueChanged(object sender, EventArgs e)
        {
            if (clickedElement is CashCounter)
            {
                CashCounter cashCounter = (CashCounter)clickedElement;
                cashCounter.CashInRubles = (int)nudElementProperty1.Value;
            }
            else if (clickedElement is FuelDispenser)
            {
                FuelDispenser fuelDispenser = (FuelDispenser)clickedElement;
                fuelDispenser.FuelFeedRateInLitersPerMinute = (int)nudElementProperty1.Value;
            }
            else if (clickedElement is FuelTank)
            {
                FuelTank fuelTank = (FuelTank)clickedElement;
                fuelTank.Volume = (int)nudElementProperty1.Value;

                nudElementProperty2.Maximum = fuelTank.Volume;
            }
        }

        private void ShowClickedEntryProperties(DataGridViewImageCell cell)
        {
            Entry clickedEntry = cell.Tag as Entry;
            clickedElement = clickedEntry;
        }

        private void ShowClickedExitProperties(DataGridViewImageCell cell)
        {
            Exit clickedExit = cell.Tag as Exit;
            clickedElement = clickedExit;
        }

        private void ShowClickedFuelDispenserProperties(DataGridViewImageCell cell)
        {
            MakePropertiesControls1Visible();

            labelElementProperty1.Text = "Скорость подачи";

            nudElementProperty1.Minimum = FuelDispenser.MinFuelFeedRateInLitersPerMinute;
            nudElementProperty1.Maximum = FuelDispenser.MaxFuelFeedRateInLitersPerMinute;

            FuelDispenser clickedFuelDispenser = cell.Tag as FuelDispenser;
            nudElementProperty1.Value = clickedFuelDispenser.FuelFeedRateInLitersPerMinute;
            clickedElement = clickedFuelDispenser;
        }

        private void ShowClickedFuelTankProperties(DataGridViewImageCell cell)
        {
            MakePropertiesControls1Visible();
            MakePropertiesControls2Visible();

            labelElementProperty1.Text = "Объём";

            nudElementProperty1.Minimum = FuelTank.MinVolumeInLiters;
            nudElementProperty1.Maximum = FuelTank.MaxVolumeInLiters;

            FuelTank clickedFuelTank = cell.Tag as FuelTank;
            nudElementProperty1.Value = clickedFuelTank.Volume;
            clickedElement = clickedFuelTank;

            labelElementProperty2.Text = "Объём топлива";
            nudElementProperty2.Minimum = 0;
            nudElementProperty2.Maximum = clickedFuelTank.Volume;


        private void nudElementProperty2_ValueChanged(object sender, EventArgs e)
        {
            if (clickedElement is FuelTank)
            {
                FuelTank fuelTank = (FuelTank)clickedElement;
                fuelTank.OccupiedVolume = (int)nudElementProperty2.Value;
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