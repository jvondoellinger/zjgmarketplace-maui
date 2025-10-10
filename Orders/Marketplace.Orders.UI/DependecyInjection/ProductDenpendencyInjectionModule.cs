using Marketplace.Orders.Core.Interfaces;
using Marketplace.Orders.UI.ViewModels;
using Marketplace.Orders.UI.Views;

namespace Marketplace.Orders.UI.DependecyInjection;

public static class ProductDenpendencyInjectionModule
{
    public static IServiceCollection RegisterOrderUIServices(this IServiceCollection services)
    {
        services
            .AddPages()
            .AddViewModels();

        return services;
    }

    private static IServiceCollection AddPages(this IServiceCollection services)
    {
        services.AddSingleton<IPageResolver, PageResolver>();
        services.AddSingleton<CheckoutPage>();
        services.AddSingleton<OrderCardsPage>();
        return services;
    }


    private static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddSingleton<PaymentViewModel>();
        services.AddSingleton<OrderCardsViewModel>();
        return services;
    }
}
