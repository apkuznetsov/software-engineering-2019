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
            var myForm = _container.GetInstance<Constructor>();
            myForm.Show();
        }
    }
}
