namespace Marketplace.Products.Infrastructure.Implementations.Requests.Configs;

public class ImageRouteUriConfig
{
    public Uri QueryByPath { get; init; }

    public Uri GetQueryByPath(string path)
    {
        return new Uri(QueryByPath, path);
    }
}
