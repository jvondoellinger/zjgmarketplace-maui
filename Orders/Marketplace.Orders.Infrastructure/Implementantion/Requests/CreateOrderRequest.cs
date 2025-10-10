using Marketplace.Orders.Core.Models;
using Marketplace.Orders.Core.Requests;
using Marketplace.Orders.Infrastructure.Implementantion.Requests.Models;
using Marketplace.SharedLayer.Headers;
using Marketplace.SharedLayer.Services;

namespace Marketplace.Orders.Infrastructure.Implementantion.Requests;

public class CreateOrderRequest : ICreateOrderRequest
{
    private readonly BearerTokenAuthentication authentication;

    public CreateOrderRequest(BearerTokenAuthentication authentication)
    {
        this.authentication = authentication;
    }

    private readonly Uri _default = new ("http://127.0.0.1:5055/api/order");
    public async Task<OrderCheckoutModel> SendAsync(OrderCheckoutModel model)
    {
        var output = await RequestService.PostAsync<CreateOrderRequestOutputModel>(_default.ToString(), model, authentication.Token);
        return model;
    }
}
 