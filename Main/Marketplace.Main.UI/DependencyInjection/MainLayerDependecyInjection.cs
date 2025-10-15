using Marketplace.Main.Infrastructure.DependecyInjection;
using Marketplace.Main.UI.TabMenu;
namespace Marketplace.Main.UI.DependencyInjection;

public static class MainLayerDependecyInjection
{
    public static IServiceCollection RegisterMainOnDependecyInjection(this IServiceCollection services)
    {
        services
            .RegisterMainInfrastructureServices()
            .AddTabMenu();
        return services;
    }

    public static IServiceCollection AddTabMenu(this IServiceCollection services)
    {
        services.AddSingleton<ITabMenuLoader, ProductCardsTabLoader>();
        services.AddSingleton<ITabMenuLoader, ProductCartTabLoader>();
        services.AddSingleton<ITabMenuLoader, ProductCategoriesTabLoader>();
        services.AddSingleton<ITabMenuLoader, UserLoginPageTabLoader>();
        services.AddSingleton<ITabMenuLoader, AccountDashboardTabLoader>();
        return services;
    }


}
