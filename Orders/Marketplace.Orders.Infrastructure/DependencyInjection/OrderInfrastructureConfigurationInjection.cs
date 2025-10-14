using Marketplace.Orders.Infrastructure.Implementantion.Requests.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Orders.Infrastructure.DependencyInjection;

public static class OrderInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureOrderLayer(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetRequiredSection("Api:OrderRoutes");
        services.Configure<OrderRoutesConfig>(section.Bind);
        return services;
    } 
        
}
