using GasStationMs.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasStationMs.App.DB;
using GasStationMs.Dal;
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
                    DeleteTemplateElement(cell);
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

        private void DeleteTemplateElement(DataGridViewImageCell cell)
        {
            if (cell.Tag != null)
            {
                if (cell.Tag is FuelDispenser)
                {
                    Topology.DeleteFuelDispenser();
                }
                else if (cell.Tag is FuelTank)
                {
                    Topology.DeleteFuelTank();
                }
                else { }

                cell.Value = null;
                cell.Tag = null;
            }
        }
    }
}
