using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using DATA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Education_System
{
    public partial class App : Application
    {
        private ServiceProvider __serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            var servicesCollection = new ServiceCollection();
            ConfigureServices(servicesCollection);
            __serviceProvider = servicesCollection.BuildServiceProvider();

            var mainWindow = __serviceProvider.GetRequiredService<Views.MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SistemaEducativoContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<>();

            services.AddTransient<Views.MainWindow>();
            
        }
    }
}
