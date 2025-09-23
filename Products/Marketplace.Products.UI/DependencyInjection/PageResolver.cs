using Marketplace.Products.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Products.Infrastructure.DependecyInjection;

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
