using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Infrastructure.Implementations.Requests.Configs;
using Marketplace.Products.Infrastructure.Implementations.Requests.Model;
using Marketplace.SharedLayer.Services;

namespace Marketplace.Products.Infrastructure.Implementations.Requests;

public class QueryProductRequest : IQueryProductRequest
{
    private readonly RequestService request;
    private readonly ProductRoutesUriConfig config;
    private readonly ProductRequestMapper mapper;

    public QueryProductRequest(RequestService request, ProductRoutesUriConfig config, ProductRequestMapper mapper)
    {
        this.request = request;
        this.config = config;
        this.mapper = mapper;
    }

    public async Task<List<Product>> SendPaginationAsync(long offset, int limit)
    {
        var data = await request.GetAsync<List<QueryProductRequestOutputModel>>(config.QueryPagination);

        return mapper.Map(data);
    }
}

public class ProductRequestMapper
{
    public Product Map(QueryProductRequestOutputModel model)
    {
        var paths = model.Paths?.Paths?.Select(x => x.CompletePath).ToList() ?? [];

        return new Product(
            model.Title,
            model.Description,
            model.Amount,
            "n/a",
            paths);
    }
    public List<Product> Map(IEnumerable<QueryProductRequestOutputModel> models) => [..models.Select(Map)];
}
