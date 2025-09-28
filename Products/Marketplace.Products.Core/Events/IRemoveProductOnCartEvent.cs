using Marketplace.Products.Core.Model;

namespace Marketplace.Products.Core.Events;

public interface IRemoveProductOnCartEvent
{
    Task RemoveItemAsync(ProductCartInput input);
}
