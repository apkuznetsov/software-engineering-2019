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
            string filePath;
            string dotExt = Topology.Topology.DotExt;
            string filter = " " + dotExt + "|" + "*." + dotExt;

            OpenFileDialog ofd = new OpenFileDialog
            {
                DefaultExt = dotExt,
                Filter = filter
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;

                if (File.Exists(filePath))
                {
                    Stream downloadingFileStream = File.OpenRead(filePath);

                    try
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        Topology.Topology topology = (Topology.Topology)deserializer.Deserialize(downloadingFileStream);
                        downloadingFileStream.Close();

                        Constructor formConstructor = _container.GetInstance<Constructor>();
                        formConstructor.Show();
                        formConstructor.TopologyBuilder.SetTopologyBuilder(topology);
                    }
                    catch
                    {
                        MessageBox.Show("ОШИБКА: файл повреждён");
                    }
                }
                else
                    MessageBox.Show("ОШИБКА: файл не существует");
            }
        }
    }
}
