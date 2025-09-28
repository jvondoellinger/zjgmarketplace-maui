using Marketplace.Products.Core.State;

namespace Marketplace.Products.Core.Events;

public interface IAddProductStateEvent
{
    Task AddStateAsync(IProductState state);
}
