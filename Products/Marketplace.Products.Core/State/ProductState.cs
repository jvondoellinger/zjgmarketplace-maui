namespace Marketplace.Products.Core.State;

public class ProductState : IProductState
{
    public int? SelectedProductId { get; private set; }

    public void SelectProduct(int productId)
    {
        SelectedProductId = productId;
    }
}
