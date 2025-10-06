using Marketplace.Products.Core.Model;
using Marketplace.Products.Infrastructure.Implementations.Requests.Commands.Models;

namespace Marketplace.Products.Infrastructure.Implementations.Requests.Commands.Mapper;

public class CreateOrderRequestModelMapper
{
    private CreateOrderRequestModelMapper() { }

    public static CreateOrderRequestModel Map(ProductCart cart)
    {
        var ids = cart.Products.Select(x => x.ProductId).ToList();
        return new(ids);
    }
}
