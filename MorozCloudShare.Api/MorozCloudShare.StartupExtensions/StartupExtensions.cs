using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MorozCloudShare.Core.Auth;
using MorozCloudShare.Core.Common;
using MorozCloudShare.Infrastructure.Auth;
using MorozCloudShare.Infrastructure.Common;
using System;

namespace MorozCloudShare.StartupExtensions
{
    /// <summary>
    /// Extension methods for configuring startup.
    /// </summary>
    public static class StartupExtensions
    {
        /// <summary>
        /// Configure by configuration and add services.
        /// </summary>
        /// <param name="services">Service collection.</param>
        /// <param name="configuration">Configuration.</param>
        public static void AddConfiguredServices(this IServiceCollection services, object configuration)
        {
            //TODO: configuration logic.
            //TODO: choose best lifetimes for serivices;
            services.AddScoped<IAuthorizationService, AuthorizationService>();            
            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddSingleton<ILogger, LoggersContainer>();
            services.AddScoped<IServiceWrapper, ServiceWrapper>();
            services.AddSingleton<IAuthControl, AuthControl>();
            services.AddTransient<AuthControlMiddleware>();

        }

        /// <summary>
        /// Use custom middlewares by config.
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <param name="configuration">Configuration</param>
        public static void UseCustom(this IApplicationBuilder app, object configuration)
        {
            app.UseMiddleware<AuthControlMiddleware>();
            //TODO: configuration.
        }
    }
}
