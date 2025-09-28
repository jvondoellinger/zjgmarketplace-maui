using Marketplace.Products.Core.State;

namespace Marketplace.Products.Core.Events;

public interface IRemoveProductStateEvent
{
    Task RemoveStateAsync(IProductState state);
}
