namespace Marketplace.Orders.UI.ViewModels.Card;

public class OrderCardViewModel
{
    public long Id { get; init; }
    public decimal Price { get; init; }
    public string Status { get; init; }
    public DateTime CreatedAt { get; init; }
}
