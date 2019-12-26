using GasStationMs.App.Forms;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Container = SimpleInjector.Container;

namespace GasStationMs.App
{
    public partial class StartingForm : Form
    {
        private readonly Container _container;
        public StartingForm(Container container)
        {
            _container = container;
            InitializeComponent();
        }

        private void btnOpenCreatingTopologyForm_Click(object sender, EventArgs e)
        {
            CreatingTopologyForm creatingTopologyForm = _container.GetInstance<CreatingTopologyForm>();
            creatingTopologyForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string filePath;
            string dotExt = Topology.Topology.DotExt;
            string filter = " " + dotExt + "|" + "*" + dotExt;

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

                        Constructor.Constructor formConstructor = _container.GetInstance<Constructor.Constructor>();
                        formConstructor.Show();
                        formConstructor.TopologyBuilder.SetTopologyBuilder(topology);
                        formConstructor.CurrFilePath = filePath;
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
