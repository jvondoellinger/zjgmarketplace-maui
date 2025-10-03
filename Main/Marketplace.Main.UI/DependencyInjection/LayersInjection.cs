using Marketplace.Main.Infrastructure.DependecyInjection;
using Marketplace.Orders.Infrastructure.DependencyInjection;
using Marketplace.Orders.UI.DependecyInjection;
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
            .RegisterMainInfrastructureServices()
            .RegisterProductInfrastructureServices()
            .RegisterProductUIServices()
            .RegisterUserUIServices()
            .RegisterUserInfrastructureServices()
            .RegisterOrderUIServices()
            .RegisterOrderInfrastructureServices();
        return services;
    }
}
