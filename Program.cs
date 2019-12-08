using System;
using System.Windows.Forms;
using GasStationMs.Dal;

namespace GasStationMs.App
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TopologyConstructor());
        }
    }
}
