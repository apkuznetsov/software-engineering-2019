using System;
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
    }
}
