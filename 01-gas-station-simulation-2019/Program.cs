using System;
using System.Windows.Forms;
using GasStationMs.Dal;
using SimpleInjector;

namespace GasStationMs.App
{
    static class Program
    {
        private static Container _container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new CreateOrLoadTopology());
        }
    }
}
