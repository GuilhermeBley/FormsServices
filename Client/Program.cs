using FormsServices.Client.Forms;
using FormsServices.Client.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FormsServices.Client;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = Host.CreateDefaultBuilder()
             .ConfigureAppConfiguration((context, builder) =>
             {
                 // Add other configuration files...
                 builder.AddJsonFile("appsettings.json", optional:false);

             })
             .ConfigureServices((context, services) =>
             {
                 ConfigureServices(context.Configuration, services);
                 
             })
             .ConfigureLogging(logging =>
             {
                 // Add other loggers...
             })
             .Build();

        var services = host.Services;
        var mainForm = services.GetRequiredService<Form1>();
        Application.Run(mainForm);
    }

    private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
    {
        services
            .AddSingleton<Form1>()
            .AddTransient<Form2>()
            .AddTransient<ISampleService, SampleService>();
    }
}