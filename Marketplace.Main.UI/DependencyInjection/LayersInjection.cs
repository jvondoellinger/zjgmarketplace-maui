using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Products.UI.DependencyInjection;
using Marketplace.Users.Infrastructure.DependecyInjection;
using Marketplace.Users.UI.DependencyInjection;

namespace Marketplace.Main.UI.DependencyInjection;

public static class LayersInjection
{
    public static IServiceCollection InjectLayers(this IServiceCollection services)
    {
        services
            .RegisterProductInfrastructureServices()
            .RegisterProductUIServices()
            .RegisterUserUIServices();
        return services;
    }
}
