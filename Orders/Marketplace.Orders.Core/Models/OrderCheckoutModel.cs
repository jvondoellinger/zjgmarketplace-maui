namespace Marketplace.Orders.Core.Models;

public class OrderCheckoutModel
{
    public List<string> ProductIds { get; set; }
    public string Status { get; set; }
    public decimal Total { get; init; }
}
