using System;
using System.Windows.Forms;

namespace software_engineering_2019
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
