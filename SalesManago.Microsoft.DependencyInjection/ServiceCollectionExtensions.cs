using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SalesManago.Microsoft.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSalesManago(this IServiceCollection services,
            IConfigurationSection configurationSection)
        {
            services.AddHttpClient<ISalesManagoService, SalesManagoService>();
            var config = configurationSection.Get<SalesManagoSettings>();
            services.AddSingleton<SalesManagoSettings>(config);

            return services;
        }
    }
}