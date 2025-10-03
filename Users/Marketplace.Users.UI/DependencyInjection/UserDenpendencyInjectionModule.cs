using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.ViewModels;
using Marketplace.Users.UI.ViewModels.Dashboard;
using Marketplace.Users.UI.Views;

namespace Marketplace.Users.UI.DependencyInjection;

public static class ProductDenpendencyInjectionModule
{
    public static IServiceCollection RegisterUserUIServices(this IServiceCollection services)
    {
        services.AddSingleton<IPageResolver, PageResolver>();

        services
            .AddPages()
            .AddViewModels()
            .AddDashboardItems();

        return services;
    }

    private static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddSingleton<DashboardViewModel>();
        services.AddSingleton<UserSignupViewModel>();
        return services;
    }
    private static IServiceCollection AddPages(this IServiceCollection services)
    {
        services.AddSingleton<UserLoginPage>();
        services.AddSingleton<UserSignupPage>();
        services.AddSingleton<AccountDashboardPage>();
        return services;
    }


    private static IServiceCollection AddDashboardItems(this IServiceCollection services)
    {
        services.AddScoped<DashboardItem, OrdersDashboardItem>();
        return services;
    }
}
