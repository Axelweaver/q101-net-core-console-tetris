using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Q101.ConsoleNetCoreTetris.Application.Configurations.Abstract;
using Q101.ConsoleNetCoreTetris.Application.Configurations.Concrete;
using Q101.ConsoleNetCoreTetris.Application.Events;
using Q101.ConsoleNetCoreTetris.Application.Fields;
using Q101.ConsoleNetCoreTetris.Application.Games;

namespace Q101.ConsoleNetCoreTetris.Application.Extensions
{
    /// <summary>
    /// Расширения провайдера сервисов IServiceCollection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Регистрация зависимостей.
        /// </summary>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Старт приложения.
            services.AddTransient<Startup>();
            // 
            services.AddSingleton<KeyPressEventHandler>();

            services.AddTransient<StartingAwaiter>();

            services.AddTransient<Field>();

            services.AddTransient<FieldElements>();

            services.AddTransient<TetrisGame>();

            return services;
        }

        /// <summary>
        /// Регистрация провайдера конфигурации приложения.
        /// </summary>
        public static IServiceCollection RegisterConfiguration(this IServiceCollection services, 
                                                               IConfiguration config)
        {
            services.AddSingleton(config);
            services.AddSingleton<IApplicationConfig>
                (config.Get<ApplicationConfig>(
                options => options.BindNonPublicProperties = true));

            return services;
        }
    }
}
