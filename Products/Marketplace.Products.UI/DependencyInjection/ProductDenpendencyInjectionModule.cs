using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Infrastructure.DependecyInjection;
using Marketplace.Products.UI.ViewModel;
using Marketplace.Products.UI.Views;
using System.Diagnostics;

namespace Marketplace.Products.UI.DependencyInjection;

public static class ProductDenpendencyInjectionModule
{
    public static IServiceCollection RegisterProductUIServices(this IServiceCollection services)
    {
        services
            .RegisterPages()
            .RegisterViewModels(); 

        services.AddSingleton<IPageResolver, PageResolver>();


        return services;
    }

    private static IServiceCollection RegisterViewModels(this IServiceCollection services)
    {
        services.AddSingleton<ProductCartViewModel>();
        services.AddSingleton<ProductCardsViewModel>();
        services.AddSingleton<ProductViewModel>();
        return services;
    }


    private static IServiceCollection RegisterPages(this IServiceCollection services)
    {
        services.AddSingleton<ProductCart>(x => ProductCart.Instance);

        services.AddSingleton<ProductPage>();
        services.AddSingleton<ProductCardsPage>();
        services.AddSingleton<ProductCategoriesPage>();
        services.AddSingleton<ProductCartPage>();
        return services;
    }
}
