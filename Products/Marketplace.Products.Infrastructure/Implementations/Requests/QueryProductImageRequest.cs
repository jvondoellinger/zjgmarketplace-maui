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

    public async Task<byte[]> QueryFirstImage(string path)
    {
        var first = (path == null || string.IsNullOrEmpty(path)) 
            ? throw new Exception("This product don't have any path to search in API") 
            : path;
        var uri = config.CurrentValue.GetQueryByPath(first);

        return await requestService.GetByteArrayAsync(uri);
    }


    public async Task<List<byte[]>> QueryImages(IEnumerable<string> paths)
    {
        var list = new List<byte[]>();

        await Parallel.ForEachAsync(paths, async (path, cancelationToken) =>
        {
            var bytes = await QueryFirstImage(path);
            list.Add(bytes);
        });

        return list;
    }
}
