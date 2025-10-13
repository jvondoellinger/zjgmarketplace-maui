using Marketplace.Orders.Infrastructure.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class MainInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureLayers(this IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureOrderLayer(configuration);
        return services;
    }
}
