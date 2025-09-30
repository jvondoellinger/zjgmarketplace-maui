namespace Marketplace.Orders.Core.Models;

public class OrderModel
{
    public decimal Price { get; init; }
    public long Id { get; init; }
    public string Status { get; init; }
    public string ImagePath { get; init; }
    public string Code { get; init; }
    public string CodeBase64 { get; init; }
    public DateTime CreatedAt { get; init; }
}
