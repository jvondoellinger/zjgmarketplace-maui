using Marketplace.Orders.Core.Models;

namespace Marketplace.Orders.Core.Requests;

public interface ICreateOrderRequest
{
    Task<OrderCheckoutModel> SendAsync(OrderCheckoutModel model);
}
