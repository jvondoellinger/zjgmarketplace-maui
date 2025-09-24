using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.ViewModels.Dashboard;
using Marketplace.Users.UI.Views;

namespace Marketplace.Users.UI.DependencyInjection;

public static class ProductDenpendencyInjectionModule
{
    public static IServiceCollection RegisterUserUIServices(this IServiceCollection services)
    {
        services.AddScoped<UserLoginPage>();
        services.AddScoped<UserSignupPage>();
        services.AddScoped<AccountDashboardView>();
        services.AddSingleton<IPageResolver, PageResolver>();

        services.AddDashboardItems();

        return services;
    }

    private static IServiceCollection AddDashboardItems(this IServiceCollection services)
    {
        services.AddScoped<IDashboardItem, OrdersDashboardItem>();
        services.AddScoped<IDashboardItem, TicketsDashboardItem>();
        return services;
    }
}
