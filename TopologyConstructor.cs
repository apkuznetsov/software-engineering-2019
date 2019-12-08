﻿using GasStationMs.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationMs.App
{
    public partial class TopologyConstructor : Form
    {
        public TopologyConstructor()
        {
            InitializeComponent();

            SetSettings();
        }

        #region события
        private void cellsHorizontally_ValueChanged(object sender, EventArgs e)
        {
            fillingStationField.ColumnCount = (int)cellsHorizontally.Value;
            // передалать потому что добавляются текст колонки а не imagecolumn
            
        }

        private void cellsVertically_ValueChanged(object sender, EventArgs e)
        {
            fillingStationField.RowCount = (int)cellsVertically.Value;
            // добавляем и удаляем предпоследний ряд а не последний 
        }
        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void fillingStationField_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewImageCell cell = (DataGridViewImageCell)fillingStationField.Rows[e.RowIndex].Cells[e.ColumnIndex];

            
                cell.Value = FuelDispenser.icon;
            
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
