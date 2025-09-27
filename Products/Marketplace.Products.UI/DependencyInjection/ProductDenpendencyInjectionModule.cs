using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Products.UI.Views;

namespace Marketplace.Products.UI.DependencyInjection;

public static class ProductDenpendencyInjectionModule
{
    public static IServiceCollection RegisterProductUIServices(this IServiceCollection services)
    {
        services.AddScoped<ProductPage>();
        services.AddScoped<ProductCardsPage>();
        services.AddScoped<ProductCategoriesPage>();
        services.AddScoped<ProductCartPage>();
        services.AddSingleton<IPageResolver, PageResolver>();

        return services;
    }
}
