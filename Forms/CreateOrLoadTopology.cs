using GasStationMs.App.Forms;
using GasStationMs.App.Topology;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace GasStationMs.App
{
    public partial class CreateOrLoadTopology : Form
    {
        public CreateOrLoadTopology()
        {
            InitializeComponent();
        }

        private void btnOpenCreateTopology_Click(object sender, EventArgs e)
        {
            CreatingTopologyForm createTopology = new CreatingTopologyForm();
            createTopology.ShowDialog();
        }

        private void btnLoadTopology_Click(object sender, EventArgs e)
        {
            string fullFilePath;
            string dotExt = TopologySaverAndLoader.DotExt;
            string filter = TopologySaverAndLoader.Filter;

            OpenFileDialog ofd = new OpenFileDialog
            {
                DefaultExt = dotExt,
                Filter = filter
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = ofd.FileName;

                if (File.Exists(fullFilePath))
                {
                    try
                    {
                        Topology.Topology topology = TopologySaverAndLoader.Load(fullFilePath);

                        Constructor.Constructor constructor = new Constructor.Constructor(fullFilePath, topology);
                        constructor.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("ОШИБКА: файл повреждён");
                    }
                }
                else
                {
                    MessageBox.Show("ОШИБКА: файл не существует");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
