using Unity;

namespace AutoService
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var container = ContainerConfig.Configure();

            var mainForm = container.Resolve<MainForm>();

            Application.Run(mainForm);
        }
    }
}