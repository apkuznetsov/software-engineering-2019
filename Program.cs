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
            //Application.Run(container.GetInstance<TopologyConstructor>());
            Application.Run(container.GetInstance<ModelingForm>());

            //Так будет выглядеть запуск приложения в будущем
            //Application.Run(new Start(container));
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<GasStationContext>(Lifestyle.Singleton);
            //container.Register<IUserContext, WinFormsUserContext>();
            container.Register<TopologyConstructor>(/*Lifestyle.Scoped*/);

            // Optionally verify the container.
            container.Verify(VerificationOption.VerifyOnly);
        }

    }
}
