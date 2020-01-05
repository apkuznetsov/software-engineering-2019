﻿using GasStationMs.App.Forms;
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
            string dotExt = Topology.Topology.DotExt;
            string filter = " " + dotExt + "|" + "*" + dotExt;

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
                    Stream downloadingFileStream = File.OpenRead(fullFilePath);

                    try
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        Topology.Topology topology = (Topology.Topology)deserializer.Deserialize(downloadingFileStream);
                        downloadingFileStream.Close();

                        Constructor.Constructor constructor = new Constructor.Constructor(fullFilePath, topology);
                        constructor.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
