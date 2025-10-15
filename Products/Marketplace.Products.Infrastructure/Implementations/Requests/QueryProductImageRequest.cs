using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Infrastructure.Implementations.Requests.Configs;
using Marketplace.SharedLayer.Services;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace Marketplace.Products.Infrastructure.Implementations.Requests;

public class QueryProductImageRequest : IQueryProductImageRequest
{
    private readonly RequestService requestService;
    private readonly IOptionsMonitor<ImageRouteUriConfig> config;

    public QueryProductImageRequest(RequestService requestService, IOptionsMonitor<ImageRouteUriConfig> config)
    {
        this.requestService = requestService;
        this.config = config;
    }
    public async Task<byte[]> QueryFirstImage(Product product)
    {
        var first = product.ImagesURL.FirstOrDefault() ?? throw new Exception("This product don't have any path to search in API");
        var uri = config.CurrentValue.GetQueryByPath(first);

        return await requestService.GetAsync<byte[]>(uri);
    }

    public async Task<List<byte[]>> QueryImages(Product product)
    {
        var bytes = new List<byte[]>();

        foreach(var path in product.ImagesURL)
        {
            var uri = config.CurrentValue.GetQueryByPath(path);
            var byteArray = await requestService.GetAsync<byte[]>(uri);

            bytes.Add(byteArray);
        }
        return bytes;
    }
}
