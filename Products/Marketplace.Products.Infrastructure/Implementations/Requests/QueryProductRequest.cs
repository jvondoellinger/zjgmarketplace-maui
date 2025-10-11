using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Infrastructure.Implementations.Requests.Model;
using Marketplace.SharedLayer.Configs;
using Marketplace.SharedLayer.Headers;
using Marketplace.SharedLayer.Services;
using System.Diagnostics;

namespace Marketplace.Products.Infrastructure.Implementations.Requests;

public class QueryProductRequest : IQueryProductRequest
{
    private readonly BearerTokenAuthentication authentication;
    private readonly GuestTokenRequest guestTokenRequest;
    private Uri Uri;
    public QueryProductRequest(CurrentRequestURI uri, BearerTokenAuthentication authentication, GuestTokenRequest guestTokenRequest)
    {
        this.Uri = new (uri.Uri, "/api/product");
        this.authentication = authentication;
        this.guestTokenRequest = guestTokenRequest;
    }

    public async Task<List<Product>> SendPaginationAsync(long offset, int limit)
    {
        var token = guestTokenRequest.GetGuestTokenAsync();
        var mapper= new ProductRequestMapper();
        var data = await RequestService.GetAsync<List<QueryProductRequestOutputModel>>(Uri.ToString(), await token);

        if (data == null) throw new Exception("Esta null isso auqi");
        if (data.Count > 0) Debug.WriteLine($"Items: {data.Count}");
        if (data.Count > 0) Debug.WriteLine($"Items: {data.First().Title}");

        return mapper.Map(data);
    }

    
}

public class ProductRequestMapper
{
    public Product Map(QueryProductRequestOutputModel model)
    {
        var paths = model.Paths?.Paths?.Select(x => x.CompletePath).ToList();
        return new Product(
            model.Title,
            model.Description,
            model.Amount,
            "n/a",
            paths ?? [ "fallback.png" ]);
    }
    public List<Product> Map(IEnumerable<QueryProductRequestOutputModel> models) => [..models.Select(Map)];
}
