using GasStationMs.App.Properties;
using System.Windows.Forms;

namespace GasStationMs.App.Forms
{
    public partial class AboutDevs : Form
    {
        public AboutDevs()
        {
            InitializeComponent();

            tbAboutDevs.Text = Resources.AboutDevs;
        }
    }
}
