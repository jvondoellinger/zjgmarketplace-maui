using Marketplace.Orders.Infrastructure.Implementantion.Requests.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Marketplace.Orders.Infrastructure.DependencyInjection;

public static class OrderInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureOrderInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        Debug.WriteLine("Configuring order layer...");
        var section = configuration.GetRequiredSection("Api:OrderRoutes");
        services.Configure<OrderRoutesConfig>(section.Bind);
        return services;
    } 
        
}
