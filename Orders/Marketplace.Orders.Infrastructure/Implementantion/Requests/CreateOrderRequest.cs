using Marketplace.Orders.Core.Models;
using Marketplace.Orders.Core.Requests;
using Marketplace.Orders.Infrastructure.Implementantion.Requests.Config;
using Marketplace.Orders.Infrastructure.Implementantion.Requests.Models;
using Marketplace.SharedLayer.Services;

namespace Marketplace.Orders.Infrastructure.Implementantion.Requests;

public class CreateOrderRequest : ICreateOrderRequest
{
    private readonly RequestService service;
    private readonly OrderRoutesConfig config;

    public CreateOrderRequest(RequestService service, OrderRoutesConfig config)
    {
        this.service = service;
        this.config = config;
    }
    public async Task<OrderCheckoutModel> SendAsync(OrderCheckoutModel model)
    {
        var output = await service.PostAsync<object>(config.QueryOrdersUri, model);
        return model;
    }
}
 