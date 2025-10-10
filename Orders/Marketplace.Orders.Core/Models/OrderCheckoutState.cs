namespace Marketplace.Orders.Core.Models;

public class OrderCheckoutState
{
    private OrderCheckoutState() { }

    public static OrderCheckoutState Instance { get; } = new();

    public event Action<OrderCheckoutModel> OnUpdateState;

    public OrderCheckoutModel Current { get; private set; }

    public void UpdateState(OrderCheckoutModel model)
    {
        Current = model;
        OnUpdateState?.Invoke(model);
    }
}
