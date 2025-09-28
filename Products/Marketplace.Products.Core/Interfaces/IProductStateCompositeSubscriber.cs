namespace Marketplace.Products.Core.Interfaces;

public interface IProductStateCompositeSubscriber
{
    void UpdateCollection();
    Task UpdateCollectionAsync();
}
