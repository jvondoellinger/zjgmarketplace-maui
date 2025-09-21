using zjgmarketplace.Products.Core.Interface;

namespace zjgmarketplace.Products.Core.Entity;

public class ProductState : IProductState
{
    public string? SelectedProductId { get; private set; }

    public void SelectProduct(string productId)
    {
        SelectedProductId = productId;
    }
}
