namespace Marketplace.Orders.Core.Models;

public class OrderCheckoutModel
{
    public List<int> ProductIds { get; set; }
    public string Status { get; set; }
    public decimal Total { get; init; }
}
