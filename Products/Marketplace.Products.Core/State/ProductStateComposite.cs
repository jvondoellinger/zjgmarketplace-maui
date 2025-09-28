using Marketplace.Products.Core.Events;
using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Workers;
using System.Diagnostics;
using System.Linq;

namespace Marketplace.Products.Core.State;

public sealed class ProductStateComposite
{
    // Instances ================================================
    private static readonly Lazy<ProductStateComposite> _instance = new(() => new ProductStateComposite());
    public static ProductStateComposite Instance => _instance.Value;

    // Properties ====================================================
    public List<IProductState> ProductStates { get; private set; } = [];

    // Constructors ====================================================
    private ProductStateComposite()
    {

    }



    // Composite operations ==================================================
    public void Add(IProductState state)
    {
        ArgumentNullException.ThrowIfNull(state); // Validate input
        if (ProductStates.Contains(state)) return; // If already exists, do nothing.
        ProductStates.Add(state);
        AddedState?.Invoke(state); // Trigger event
    }
    public void Remove(IProductState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!ProductStates.Contains(state)) return;
        ProductStates.Remove(state);
        RemoveState?.Invoke(state);
    }
    public void Remove(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId)) return;

        ProductStates.RemoveAll((Predicate<IProductState>) (x =>
        {
            var isEquals = productId.Equals(x.SelectedProductId);
            if (!isEquals) return false;
            RemoveState?.Invoke(x);
            return true;
        }));
    }
    public void ClearStates()
    {
        ProductStates.Clear();
    }

    // Events ===========================================================
    public event Action<IProductState> AddedState;
    public event Action<IProductState> RemoveState;
}
