using Marketplace.Orders.Core.Query;
using Marketplace.Orders.Core.State;
using Marketplace.Orders.Infrastructure.Implementantion.Query.Tests;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Orders.Infrastructure.DependencyInjection;

public static class OrderInfrastructureInjection
{
    public static IServiceCollection RegisterOrderInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IOrderState, OrderState>();
        services.AddSingleton<IOrderQuery, OrderQueryTest>();
        return services;
    }
}