using Marketplace.Orders.Core.Models;
using Marketplace.Orders.Core.Query;
using Marketplace.Orders.Core.Requests;
using Marketplace.Orders.Core.State;
using Marketplace.Orders.Infrastructure.Implementantion.Query.Tests;
using Marketplace.Orders.Infrastructure.Implementantion.Requests;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Orders.Infrastructure.DependencyInjection;

public static class OrderInfrastructureInjection
{
    public static IServiceCollection RegisterOrderInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<OrderCheckoutState>(x => OrderCheckoutState.Instance);
        services.AddSingleton<IOrderState, OrderState>();
        services.AddSingleton<IOrderQuery, OrderQueryTest>();
        services.AddSingleton<ICreateOrderRequest, CreateOrderRequest>();
        return services;
    }
}