using Marketplace.Orders.Core.Models;
using Marketplace.Orders.Core.Requests;
using Marketplace.Orders.Infrastructure.Implementantion.Requests.Config;
using Marketplace.Orders.Infrastructure.Implementantion.Requests.Models;
using Marketplace.SharedLayer.Services;
using Microsoft.Extensions.Options;

namespace Marketplace.Orders.Infrastructure.Implementantion.Requests;

public class CreateOrderRequest : ICreateOrderRequest
{
    private readonly RequestService service;
    private readonly IOptionsMonitor<OrderRoutesConfig> config;

    public CreateOrderRequest(RequestService service, IOptionsMonitor<OrderRoutesConfig> config)
    {
        this.service = service;
        this.config = config;
    }
    public async Task<OrderCheckoutModel> SendAsync(OrderCheckoutModel model)
    {
        var output = await service.PostAsync<object>(config.CurrentValue.QueryOrdersUri, model);
        return model;
    }
}
 