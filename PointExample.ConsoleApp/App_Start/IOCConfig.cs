using System;
using Microsoft.Extensions.DependencyInjection;
using PointExample.Common;
using PointExample.Common.Factories;
using PointExample.Common.Interfaces;

namespace PointExample.ConsoleApp.App_Start
{
    /// <summary>
    /// This class is for configuring Inversion of Control containers or Service Providers.
    /// </summary>
    public static class IocConfig
    {
        /// <summary>
        /// Configure the IOC Service Provider to use for the application.
        /// </summary>
        /// <returns>A Service Provider to resolve objects from.</returns>
        public static IServiceProvider ConfigureIocService()
        {
            // Setup our DI (Dependency Injection)
            var serviceProvider = new ServiceCollection()
                .AddSingleton(
                    x => new PointFactory(
                        new ScreenPointFactory(new NoOpTransformation()),
                        new ArbitraryPointFactory(new ArbitraryTransformation())))
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
