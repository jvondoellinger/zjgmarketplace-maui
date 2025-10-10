using Marketplace.Orders.Core.Models;

namespace Marketplace.Orders.Infrastructure.Implementantion.Requests.Models.Mapper;

public class CreateOrderRequestInputModelMapper
{
    internal static CreateOrderRequestInputModel Map(OrderCheckoutModel model)
    {
        return new CreateOrderRequestInputModel(model.ProductIds, model.Status, model.Total);
    }
}    
