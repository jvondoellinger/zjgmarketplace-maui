using Marketplace.AuthorizationLayer.DependencyInjection;
using Marketplace.Main.Infrastructure.Implementations.Redirect;
using Marketplace.Main.Infrastructure.Services;
using Marketplace.Orders.Infrastructure.DependencyInjection;
using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Users.Infrastructure.DependecyInjection;
using Marketplace.Users.UI.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class MainInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureLayers(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<BackgroundServicesWorker>();

        services
            .ConfigureAuthorizationLayer(configuration)
            .ConfigureProductInfrastructureLayer(configuration)
            .ConfigureOrderInfrastructureLayer(configuration)
            .ConfigureUserInfrastructureLayer(configuration);
        return services;
    }
}
