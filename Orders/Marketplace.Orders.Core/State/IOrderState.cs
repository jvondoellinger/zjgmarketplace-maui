using Marketplace.Orders.Core.Models;

namespace Marketplace.Orders.Core.State;

public interface IOrderState
{
    OrderModel SelectedOrder { get; }

    void Select(OrderModel order);

    event Action<OrderModel> SelectOrder;
}
