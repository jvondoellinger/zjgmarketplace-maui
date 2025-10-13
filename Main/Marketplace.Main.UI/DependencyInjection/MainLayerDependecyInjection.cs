using Marketplace.Main.Infrastructure.DependecyInjection;
namespace Marketplace.Main.UI.DependencyInjection;

public static class MainLayerDependecyInjection
{
    public static IServiceCollection RegisterMainOnDependecyInjection(this IServiceCollection services)
    {
        services
            .RegisterMainInfrastructureServices();
        return services;
    }
}
