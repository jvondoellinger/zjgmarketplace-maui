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
    public void AddState(IProductState state)
    {
        ArgumentNullException.ThrowIfNull(state); // Validate input
        if (ProductStates.Contains(state)) return; // If already exists, do nothing.
        ProductStates.Add(state);
        OnAddedState?.Invoke(state); // Trigger event
    }
    public void RemoveState(IProductState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!ProductStates.Contains(state)) return;
        ProductStates.Remove(state);
        OnRemoveState?.Invoke(state);
    }
    public void RemoveState(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId)) return;
        
        ProductStates.RemoveAll(x =>
        {
            var isEquals = productId.Equals(x.SelectedProductId);
            if (!isEquals) return false;
            OnRemoveState?.Invoke(x);
            return true;
        });
    }
    public void ClearStates()
    {
        ProductStates.Clear();
    }

    // Events ===========================================================
    private event Action<IProductState> OnAddedState;
    private event Action<IProductState> OnRemoveState;

    // Subscribers ======================================================
    public void AddAddedStateSubscriber(IAddProductStateEvent stateEvent)
    {
        OnAddedState += async (state)
            => await stateEvent.AddStateAsync(state);
    }
    public void RemoveStateSubscribe(IRemoveProductStateEvent stateEvent)
    {
        OnRemoveState += async (state)
            => await stateEvent.RemoveStateAsync(state);
    }
    public void Unsubscribe(IAddProductStateEvent stateEvent)
    {
        OnAddedState -= async (state)
            => await stateEvent.AddStateAsync(state);
    }
    public void Unsubscribe(IRemoveProductStateEvent stateEvent)
    {
        OnRemoveState -= async (state)
            => await stateEvent.RemoveStateAsync(state);
    }
}
