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
                    AddTemplateElement(cell);
                    break;
                case MouseButtons.Right:
                    tb.DeleteTemplateElement(cell);
                    break;
                default:
                    break;
            }
        }

        private void AddTemplateElement(DataGridViewImageCell cell)
        {
            if (Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                if (cell.Tag == null)
                {
                    var rb = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

                    if (rb.Name == typeof(FuelDispenser).ToString())
                    {
                        if (tb.AddFuelDispenser())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new FuelDispenser();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить ТРК");
                        }
                    }
                    else if (rb.Name == typeof(FuelTank).ToString())
                    {
                        if (tb.AddFuelTank())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new FuelTank();
                            tbClickedCell.Text = cell.Tag.ToString();
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
                            tbClickedCell.Text = cell.Tag.ToString();
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
                            tbClickedCell.Text = cell.Tag.ToString();
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
                            tbClickedCell.Text = cell.Tag.ToString();
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
                }
            }
        }
    }
}
