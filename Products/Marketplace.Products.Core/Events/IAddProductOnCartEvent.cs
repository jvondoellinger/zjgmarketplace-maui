using Marketplace.Products.Core.Model;

namespace Marketplace.Products.Core.Events;

public interface IAddProductOnCartEvent
{
    Task AddItemAsync(ProductCartInput input);
}
