using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Q101.ConsoleNetCoreTetris.Application.Extensions;

namespace Q101.ConsoleNetCoreTetris.Application
{
    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry point 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                // Регистрация источников конфигурации.
                IConfiguration configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var services = new ServiceCollection()
                    .RegisterConfiguration(configuration)
                    .RegisterServices()
                    .BuildServiceProvider(true);

                var scope = services.CreateScope();

                scope.ServiceProvider.GetRequiredService<Startup>().Run();
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exception);
            }
        }
    }
}
