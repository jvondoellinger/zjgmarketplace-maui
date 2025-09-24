using Marketplace.Users.Core.Interfaces;

namespace Marketplace.Users.UI.DependencyInjection;

public class PageResolver : IPageResolver
{
    private readonly IServiceProvider _provider;

    public PageResolver(IServiceProvider provider)
    {
        _provider = provider;
    }
    public T Resolve<T>()
    {
        return _provider.GetRequiredService<T>();
    }
}
