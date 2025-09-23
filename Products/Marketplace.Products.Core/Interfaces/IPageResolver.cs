namespace Marketplace.Products.Core.Interfaces
{
    public interface IPageResolver
    {
        T Resolve<T>();
    }
}
