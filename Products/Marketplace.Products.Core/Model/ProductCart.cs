using Marketplace.Products.Core.State;
using System.Diagnostics;

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
    public decimal TotalPrice => Products.Sum(x => x.Price * x.Quantity); //Permanece com bug com +1 de um item - verificar posteriormente


    // Methods =============================================================
    public void Add(ref ProductCartInput product)
    {
        ArgumentNullException.ThrowIfNull(product);
        var index = Products.IndexOf(product);
        if (index != -1)
        {
            product.Quantity++;
            Products[index] = product;
            Debug.WriteLine("Caiu aqui.");
        } 
        else
        {
            Products.Add(product);
        }
        AddedItem?.Invoke(product);

    }
    public void Remove(ref ProductCartInput product)
    {
        ArgumentNullException.ThrowIfNull(product);
        
        Products.Remove(product);

        RemovedItem?.Invoke(product);
    }
    public void Remove(string productId)
    {
        if (productId.Length == 0) 
            return;
        var product = Products.FirstOrDefault(x => x.ProductId.Equals(productId));
        
        Products.Remove(product);

        RemovedItem?.Invoke(product); 
    }
    public void ClearProducts() => Products.Clear();

    // Events ===========================================================
    public event Action<ProductCartInput> AddedItem;
    public event Action<ProductCartInput> RemovedItem;
}
