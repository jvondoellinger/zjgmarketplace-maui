namespace zjgmarketplace.Products.Core.Interface
{
    public interface IProductState
    {
        string? SelectedProductId { get; }

        void SelectProduct(string productId);
    }
}
