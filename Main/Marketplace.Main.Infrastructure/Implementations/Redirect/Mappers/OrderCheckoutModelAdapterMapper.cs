using Marketplace.Orders.Core.Models;
using Marketplace.Products.Core.Model;

namespace Marketplace.Main.Infrastructure.Implementations.Redirect.Mappers;

public class OrderCheckoutModelAdapterMapper
{
    private OrderCheckoutModelAdapterMapper() { }

    internal static OrderCheckoutModel Map(ProductCart cart)
    {
        return new OrderCheckoutModel()
        {
            ProductIds = [.. cart.Products.Select(x => x.ProductId)],
        };
    }
}
