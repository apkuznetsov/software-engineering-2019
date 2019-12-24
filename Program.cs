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
            Bootstrap();
            //Application.Run(container.GetInstance<Constructor>());
            //Application.Run(new ModelingForm(null));
            //Application.Run(container.GetInstance<DistributionLaws.DistributionLaws>());
            //Так будет выглядеть запуск приложения в будущем
            Application.Run(new Start(_container));
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            _container = new Container();

            // Register your types, for instance:
            _container.Register<GasStationContext>(Lifestyle.Singleton);
            //container.Register<IUserContext, WinFormsUserContext>();
            _container.Register<Constructor.Constructor>(/*Lifestyle.Scoped*/);
            _container.Register<DistributionLawsForm>();
            // Optionally verify the container.
            _container.Verify(VerificationOption.VerifyOnly);
        }

    }
}
