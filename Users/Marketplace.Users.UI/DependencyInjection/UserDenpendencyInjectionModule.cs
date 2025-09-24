using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.Views;

namespace Marketplace.Users.UI.DependencyInjection;

public static class ProductDenpendencyInjectionModule
{
    public static IServiceCollection RegisterUserUIServices(this IServiceCollection services)
    {
        services.AddScoped<UserLoginPage>();
        services.AddScoped<UserSignupPage>();
        services.AddSingleton<IPageResolver, PageResolver>();

        return services;
    }
}
