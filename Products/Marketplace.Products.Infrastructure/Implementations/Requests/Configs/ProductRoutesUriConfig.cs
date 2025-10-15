namespace Marketplace.Products.Infrastructure.Implementations.Requests.Configs;

public class ProductRoutesUriConfig
{
    public Uri QueryPagination { get; init; }
    public Uri QueryIdentifier { get; init; }

    public Uri GetQueryIdentifier(string identifier)
    {
        return new Uri(QueryIdentifier, identifier);
    }
}
