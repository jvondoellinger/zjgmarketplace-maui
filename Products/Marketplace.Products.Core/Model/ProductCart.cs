using Marketplace.Products.Core.State;

namespace Marketplace.Products.Core.Model;

public class ProductCart
{
    // Constructor =========================================================
    private ProductCart() { }

    // Singleton instance ==================================================
    private static readonly ProductCart _instance = new();
    public static ProductCart Instance => _instance;

    // Properties ==========================================================
    public List<ProductCartInput> Products { get; } = [];
    public decimal TotalPrice => Products.Sum(x => x.Price);

    // Methods =============================================================
    public void Add(ProductCartInput product)
    {
        ArgumentNullException.ThrowIfNull(product);
        var input = Products.FirstOrDefault(x => x.ProductId == product.ProductId);
        if (input != null)
        {
            input.Quantity++;
            Products[Products.IndexOf(input)] = product;
        } 
        else
        {
            Products.Add(product);
        }
        AddedItem?.Invoke(product);

    }
    public void Remove(ProductCartInput product)
    {
        ArgumentNullException.ThrowIfNull(product);
        if (!Products.Contains(product)) return;
        Products.Remove(product);
        RemovedItem?.Invoke(product);
    }
    public void Remove(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId)) 
            return;
        var product = Products.FirstOrDefault(
            x => x.ProductId.Equals(productId));
        
        if (product == null) 
            return;

        RemovedItem?.Invoke(product); 
    }
    public void ClearProducts() => Products.Clear();

    // Events ===========================================================
    public event Action<ProductCartInput> AddedItem;
    public event Action<ProductCartInput> RemovedItem;
}
