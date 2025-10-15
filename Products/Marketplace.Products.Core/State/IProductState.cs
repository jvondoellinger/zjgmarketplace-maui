namespace Marketplace.Products.Core.State;

public interface IProductState
{
    string? SelectedProductId { get; }
    void SelectProduct(string productId);
}
