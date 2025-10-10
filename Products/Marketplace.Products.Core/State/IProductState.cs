namespace Marketplace.Products.Core.State;

public interface IProductState
{
    int? SelectedProductId { get; }
    void SelectProduct(int productId);
}
