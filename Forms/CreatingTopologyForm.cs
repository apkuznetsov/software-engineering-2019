using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class CreatingTopologyForm : Form
    {
        private string currFilePath;

        public CreatingTopologyForm()
        {
            InitializeComponent();
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            string dotExt = Topology.Topology.DotExt;
            string filter = " " + dotExt + "|" + "*" + dotExt;

            SaveFileDialog sfd = new SaveFileDialog
            {
                DefaultExt = dotExt,
                Filter = filter
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                currFilePath = sfd.FileName;
            }
        }
    }
}
