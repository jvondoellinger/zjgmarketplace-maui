using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Products.UI.DependencyInjection;

namespace Marketplace.Main.UI.DependencyInjection;

public static class LayersInjection
{
    public static IServiceCollection InjectLayers(this IServiceCollection services)
    {
        services
            .RegisterProductInfrastructureServices()
            .RegisterProductUIServices();
        return services;
    }
}
