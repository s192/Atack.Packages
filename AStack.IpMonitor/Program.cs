// See https://aka.ms/new-console-template for more information
global using Microsoft.Extensions.Hosting;
using AStack.IpMonitor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

var config = new ConfigurationBuilder()
   .SetBasePath(AppContext.BaseDirectory) //From NuGet Package Microsoft.Extensions.Configuration.Json
   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
   .Build();

NLog.LogManager.Configuration = new NLogLoggingConfiguration(config.GetSection("NLog"));

using IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService(options =>
    {
        options.ServiceName = "AStack IP Service";
    })
    .ConfigureLogging(logging =>
    {
        // configure Logging with NLog
        logging.ClearProviders();
        logging.SetMinimumLevel(LogLevel.Trace);
        logging.AddNLog(config);
    })
    .ConfigureServices(services =>
    {
        services.AddSingleton<EmailHelper>();
        services.AddHostedService<IPService>();
    })
    .Build();

await host.RunAsync();