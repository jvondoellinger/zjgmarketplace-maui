namespace Marketplace.Products.Core.State;

public class ProductState : IProductState
{
    public string? SelectedProductId { get; private set; }

    public void SelectProduct(string productId)
    {
        SelectedProductId = productId;
    }
}
