using System;
using System.Windows.Forms;
using GasStationMs.Dal;
using SimpleInjector;

namespace GasStationMs.App
{
    static class Program
    {
        private static Container container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            //Application.Run(container.GetInstance<Constructor>());
            //Application.Run(new ModelingForm(null));
            //Application.Run(container.GetInstance<DistributionLaws.DistributionLaws>());
            //Так будет выглядеть запуск приложения в будущем
            Application.Run(new Start(container));
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<GasStationContext>(Lifestyle.Singleton);
            //container.Register<IUserContext, WinFormsUserContext>();
            container.Register<Constructor>(/*Lifestyle.Scoped*/);
            container.Register<DistributionLaws.DistributionLaws>();
            // Optionally verify the container.
            container.Verify(VerificationOption.VerifyOnly);
        }

    }
}
