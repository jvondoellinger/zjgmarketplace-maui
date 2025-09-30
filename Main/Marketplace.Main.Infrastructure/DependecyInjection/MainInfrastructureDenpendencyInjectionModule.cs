using Marketplace.Main.Infrastructure.Implementations.Redirect;
using Marketplace.Users.UI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Main.Infrastructure.DependecyInjection;

public static class MainInfrastructureDenpendencyInjectionModule
{
    public static IServiceCollection RegisterMainInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IOrderPageRedirect, OrderPageRedirect>();
        return services;
    }
}
