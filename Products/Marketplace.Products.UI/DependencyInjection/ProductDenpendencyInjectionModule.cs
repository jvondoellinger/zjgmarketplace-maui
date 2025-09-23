using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Products.UI.Views;
using Microsoft.Extensions.DependencyInjection;
using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.DependencyInjection;

public static class ProductDenpendencyInjectionModule
{
    public static IServiceCollection RegisterProductUIServices(this IServiceCollection services)
    {
        services.AddScoped<ProductPage>();
        services.AddScoped<PreviewProductsPage>();
        services.AddScoped<ProductCategoriesPage>();
        services.AddSingleton<IPageResolver, PageResolver>();

        return services;
    }
}
