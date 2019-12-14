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
                    Topology.TopologyConstructor.DeleteTemplateElement(cell);
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
                        if (Topology.TopologyConstructor.CanAddFuelDispenser())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new FuelDispenser();
                            Topology.TopologyConstructor.AddFuelDispenser();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить ТРК");
                        }
                    }
                    else if (rb.Name == typeof(FuelTank).ToString())
                    {
                        if (Topology.TopologyConstructor.CanAddFuelTank())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new FuelTank();
                            Topology.TopologyConstructor.AddFuelTank();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить ТБ");
                        }
                    }
                    else if (rb.Name == typeof(CashCounter).ToString())
                    {
                        if (Topology.TopologyConstructor.CanAddCashCounter())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new CashCounter();
                            Topology.TopologyConstructor.AddCashCounter();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить кассу");
                        }
                    }
                    else if (rb.Name == typeof(Entry).ToString())
                    {
                        if (Topology.TopologyConstructor.CanAddEntry())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new Entry();
                            Topology.TopologyConstructor.AddEntry();
                            tbClickedCell.Text = cell.Tag.ToString();
                        }
                        else
                        {
                            MessageBox.Show("невозможно добавить въезд");
                        }
                    }
                    else if (rb.Name == typeof(Exit).ToString())
                    {
                        if (Topology.TopologyConstructor.CanAddExit())
                        {
                            cell.Value = rb.Image;
                            cell.Tag = new Exit();
                            Topology.TopologyConstructor.AddExit();
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
