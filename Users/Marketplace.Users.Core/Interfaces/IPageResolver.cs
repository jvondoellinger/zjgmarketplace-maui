namespace Marketplace.Users.Core.Interfaces;

public interface IPageResolver
{
    T Resolve<T>();
}
