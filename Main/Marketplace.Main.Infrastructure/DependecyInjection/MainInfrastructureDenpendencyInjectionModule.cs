using Marketplace.Main.Infrastructure.Implementations.Redirect;
using Marketplace.Products.UI.Interfaces;
using Marketplace.SharedLayer.Headers;
using Marketplace.Users.UI.Interfaces;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class MainInfrastructureDenpendencyInjectionModule
{
    public static IServiceCollection RegisterMainInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IOrderPageRedirect, OrderPageRedirect>();
        services.AddSingleton<ICheckoutPageRedirect, CheckoutPageAdapterRedirect>();
        services.AddSingleton<BearerTokenAuthentication>((provider) => BearerTokenAuthentication.Instance);
        return services;
    }
}
