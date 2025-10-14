using Marketplace.AuthorizationLayer.DependencyInjection;
using Marketplace.Orders.Infrastructure.DependencyInjection;
using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Users.Infrastructure.DependecyInjection;
using Microsoft.Extensions.Configuration;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class MainInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureLayers(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .ConfigureProductInfrastructure(configuration)
            .ConfigureOrderLayer(configuration)
            .ConfigureUserInfrastructure(configuration)
            .ConfigureAuthorizationLayer(configuration)
            .ConfigureOrderLayer(configuration);
        return services;
    }
}
