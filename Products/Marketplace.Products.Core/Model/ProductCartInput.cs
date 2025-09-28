namespace Marketplace.Products.Core.Model;

public class ProductCartInput
{
    public required string ProductId { get; init; }
    public decimal Price { get; init; }
    public required string Title { get; init; }
    public int Quantity { get; set; } = 1;
}
