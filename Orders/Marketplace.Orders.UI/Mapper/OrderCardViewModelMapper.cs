using Marketplace.Orders.Core.Models;
using Marketplace.Orders.UI.ViewModels.Card;
using Marketplace.Orders.UI.Views.Content;

namespace Marketplace.Orders.UI.Mapper;

public class OrderCardViewModelMapper
{
    private OrderCardViewModelMapper()
    {
        
    }

    public static OrderCardViewModel Map(OrderModel order)
    {
        return new OrderCardViewModel()
        {
            Id = order.Id,
            Price = order.Price,
            Status = order.Status,
            CreatedAt = order.CreatedAt
        };
    }

    public static IEnumerable<OrderCardViewModel> Map(IEnumerable<OrderModel> orders) => orders.Select(Map);
}
