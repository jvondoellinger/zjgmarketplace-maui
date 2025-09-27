namespace Marketplace.Products.Core.State;

public sealed class ProductStateComposite
{
    private static readonly Lazy<ProductStateComposite> _instance = new(() => new ProductStateComposite());
    public static ProductStateComposite Instance => _instance.Value;
    private ProductStateComposite()
    {
        
    }

    public List<IProductState> ProductStates { get; private set; } = [];

    public void AddState(IProductState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (ProductStates.Contains(state)) return;
        ProductStates.Add(state);
    }
    public void RemoveState(IProductState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!ProductStates.Contains(state)) return;
        ProductStates.Remove(state);
    }
    public void ClearStates()
    {
        ProductStates.Clear();
    }

}
