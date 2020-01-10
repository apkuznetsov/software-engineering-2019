using GasStationMs.App.Forms;
using GasStationMs.App.Properties;
using GasStationMs.App.Topology;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace GasStationMs.App
{
    public partial class CreateOrLoadTopology : Form
    {
        public CreateOrLoadTopology()
        {
            InitializeComponent();
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fullFilePath = Path.GetFullPath(Resources.DevsPage);
            System.Diagnostics.Process.Start(fullFilePath);
        }

        private void btnOpenCreateTopology_Click(object sender, EventArgs e)
        {
            CreateTopology createTopology = new CreateTopology();
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
                    catch (SerializationException)
                    {
                        MessageBox.Show("ОШИБКА: файл повреждён");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.StackTrace);
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
