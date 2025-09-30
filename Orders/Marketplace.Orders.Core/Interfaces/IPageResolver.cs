namespace Marketplace.Orders.Core.Interfaces
{
    public interface IPageResolver
    {
        T Resolve<T>();
    }
}
