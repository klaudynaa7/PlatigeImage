using Microsoft.Extensions.DependencyInjection;
using PlatigeImage.Infrastructure;

namespace PlatigeImage
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var services = new ServiceCollection();
            services.AddInfrastructure(null);
            services.AddApplication();

            ServiceProvider = services.BuildServiceProvider();
            Application.Run(ServiceProvider.GetRequiredService<DatabaseConnectionForm>());
        }
    }
}