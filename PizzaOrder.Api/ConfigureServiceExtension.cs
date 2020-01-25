using GraphQL;
using GraphQL.Server;
using Microsoft.Extensions.DependencyInjection;
using PizzaOrder.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrder.Api
{
    public static class ConfigureServiceExtension
    {
        public static void AddCustomService(this IServiceCollection services)
        {
            services.AddTransient<IPizzaDetailsService, PizzaDetailsService>();
            services.AddTransient<IOrderDetailsService, OrderDetailsService>();

        }


        public static void AddCustomGraphQLServices(this IServiceCollection services)
        {
            // GraphQL services
            services.AddScoped<IServiceProvider>(c => new FuncServiceProvider(type => c.GetRequiredService(type)));
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = false; // false prints message only, true will ToString
                options.UnhandledExceptionDelegate = context =>
                {
                    Console.WriteLine("Error: " + context.OriginalException.Message);
                };
            })
            .AddWebSockets()
            .AddDataLoader();
        }

    }
}
