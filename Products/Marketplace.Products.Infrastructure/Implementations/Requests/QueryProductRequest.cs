using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Infrastructure.Implementations.Requests.Configs;
using Marketplace.Products.Infrastructure.Implementations.Requests.Model;
using Marketplace.SharedLayer.Services;
using Microsoft.Extensions.Options;

namespace Marketplace.Products.Infrastructure.Implementations.Requests;

public class QueryProductRequest : IQueryProductRequest
{
    private readonly RequestService request;
    private readonly IOptionsMonitor<ProductRoutesUriConfig> config;
    private readonly ProductRequestMapper mapper;

    public QueryProductRequest(RequestService request, IOptionsMonitor<ProductRoutesUriConfig> config, ProductRequestMapper mapper)
    {
        this.request = request;
        this.config = config;
        this.mapper = mapper;
    }

    public async Task<Product> QueryIdAsync(string id)
    {
        var uri = config.CurrentValue.GetQueryIdentifier(id);
        var data = await request.GetAsync<QueryProductRequestOutputModel>(uri);
        return mapper.Map(data);
    }

    public async Task<IEnumerable<Product>> QueryPaginationAsync(long offset, int limit)
    {
        var uri = config.CurrentValue.QueryPagination;
        var data = await request.GetAsync<List<QueryProductRequestOutputModel>>(uri);

        return mapper.Map(data);
    }
}

public class ProductRequestMapper
{
    public Product Map(QueryProductRequestOutputModel model)
    {
        var paths = model.Paths?.Paths?.Select(x => x.CompletePath).ToList() ?? [];

        return new Product(
            model.Id,
            model.Title,
            model.Description,
            model.Amount,
            "n/a",
            paths);
    }
    public List<Product> Map(IEnumerable<QueryProductRequestOutputModel> models) => [..models.Select(Map)];
}
