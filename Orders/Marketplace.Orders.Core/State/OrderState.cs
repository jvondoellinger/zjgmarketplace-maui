using Marketplace.Orders.Core.Models;

namespace Marketplace.Orders.Core.State;

public class OrderState : IOrderState
{
    public OrderModel SelectedOrder { get; private set; }

    public void Select(OrderModel order)
    {
        SelectedOrder = order;
    }
}
