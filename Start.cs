using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Container = SimpleInjector.Container;

namespace GasStationMs.App
{
    public partial class Start : Form
    {
        private readonly Container _container;
        public Start(Container container)
        {
            _container = container;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Constructor formTopologyBuilder = _container.GetInstance<Constructor>();
            formTopologyBuilder.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            const string Directory = @"D:\software_engineering_2019\bin\Debug\";
            const string FileName = "Топология" + ".tplg";

            Topology.Topology topology;

            if (File.Exists(FileName))
            {
                Stream downloadingFileStream = File.OpenRead(Directory + FileName);

                BinaryFormatter deserializer = new BinaryFormatter();
                topology = (Topology.Topology)deserializer.Deserialize(downloadingFileStream);

                downloadingFileStream.Close();

                Constructor formConstructor = _container.GetInstance<Constructor>();
                formConstructor.Show();
                formConstructor.TopologyBuilder.SetTopologyBuilder(topology);
            }
        }
    }
}
