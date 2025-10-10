namespace Marketplace.Orders.UI.ViewModels.Card;

public class ItemOnOrderViewModel
{
    public int ProductId { get; init; }
    public string Title { get; init; }
    public decimal Price { get; init; }
    public short Quantity { get; init; }
}
