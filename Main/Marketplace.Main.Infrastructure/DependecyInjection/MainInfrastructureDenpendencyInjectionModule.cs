using Marketplace.Main.Infrastructure.Implementations.Redirect;
using Marketplace.Orders.Infrastructure.DependencyInjection;
using Marketplace.Orders.UI.DependecyInjection;
using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Products.UI.DependencyInjection;
using Marketplace.Products.UI.Interfaces;
using Marketplace.SharedLayer.DependencyInjection;
using Marketplace.Users.Infrastructure.DependecyInjection;
using Marketplace.Users.UI.DependencyInjection;
using Marketplace.Users.UI.Interfaces;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class MainInfrastructureDenpendencyInjectionModule
{
    public static IServiceCollection RegisterMainInfrastructureServices(this IServiceCollection services)
    {
        services
            .AddLayersInjection()
            .AddRedirections();

        return services;
    }

    private static IServiceCollection AddLayersInjection(this IServiceCollection services)
    {
        services
            .RegisterAuthorizationLayer()
            .RegisterProductUIServices()
            .RegisterProductInfrastructureServices()
            .RegisterUserUIServices()
            .RegisterUserInfrastructureServices()
            .RegisterOrderUIServices()
            .RegisterOrderInfrastructureServices()
            .AddSharedLayerOnDependecyInjection();
        return services;
    }

    private static IServiceCollection AddRedirections(this IServiceCollection services)
    {
        services.AddSingleton<IOrderPageRedirect, OrderPageRedirect>();
        services.AddSingleton<ICheckoutPageRedirect, CheckoutPageAdapterRedirect>();
        return services;
    }
}
