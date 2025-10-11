using Marketplace.Main.Infrastructure.Implementations.Redirect;
using Marketplace.Products.UI.Interfaces;
using Marketplace.SharedLayer.Configs;
using Marketplace.SharedLayer.Headers;
using Marketplace.SharedLayer.Services;
using Marketplace.Users.UI.Interfaces;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class MainInfrastructureDenpendencyInjectionModule
{
    public static IServiceCollection RegisterMainInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IOrderPageRedirect, OrderPageRedirect>();
        services.AddSingleton<ICheckoutPageRedirect, CheckoutPageAdapterRedirect>();
        services.AddSingleton<CurrentRequestURI>();
        services.AddSingleton<GuestTokenRequest>();
        services.AddSingleton<BearerTokenAuthentication>((provider) => BearerTokenAuthentication.Instance);
        return services;
    }
}
