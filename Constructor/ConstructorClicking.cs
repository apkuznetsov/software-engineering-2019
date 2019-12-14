using GasStationMs.App.Models;
using System.Linq;
using System.Windows.Forms;
using GasStationMs.App.TemplateElements;

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
                    Topology.DeleteTemplateElement(cell);
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
                        if (Topology.CanAddFuelDispenser())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new FuelDispenser();
                            Topology.AddFuelDispenser();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить ТРК");
                        }
                    }
                    else if (rb.Name == typeof(FuelTank).ToString())
                    {
                        if (Topology.CanAddFuelTank())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new FuelTank();
                            Topology.AddFuelTank();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить ТБ");
                        }
                    }
                    else if (rb.Name == typeof(CashCounter).ToString())
                    {
                        if (Topology.CanAddCashCounter())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new CashCounter();
                            Topology.AddCashCounter();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить кассу");
                        }
                    }
                    else if (rb.Name == typeof(Entry).ToString())
                    {
                        if (Topology.CanAddEntry())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new Entry();
                            Topology.AddEntry();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить въезд");
                        }
                    }
                    else if (rb.Name == typeof(Exit).ToString())
                    {
                        if (Topology.CanAddExit())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new Exit();
                            Topology.AddExit();
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
