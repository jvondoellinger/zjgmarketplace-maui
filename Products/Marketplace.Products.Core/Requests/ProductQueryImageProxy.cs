using Marketplace.Products.Core.Model;
using System.Collections.Generic;

namespace Marketplace.Products.Core.Requests;

public class ProductQueryImageProxy : IQueryProductRequest
{
    private readonly IQueryProductImageRequest imageRequest;
    private readonly IQueryProductRequest productRequest;

    public ProductQueryImageProxy(IQueryProductImageRequest imageRequest, IQueryProductRequest productRequest)
    {
        this.imageRequest = imageRequest;
        this.productRequest = productRequest;
    }

    public async Task<IEnumerable<Product>> QueryPaginationAsync(long offset, int limit)
    {
        var pagination = await productRequest.QueryPaginationAsync(offset, limit);
        await Parallel.ForEachAsync(pagination, async (product, cancelationToken) =>
        {
            product.Images = await imageRequest.QueryImages(product.ImagesURL);
        });
        return pagination;
    }
    public async Task<Product> QueryIdAsync(string id)
    {
        var product = await productRequest.QueryIdAsync(id);
        product.Images = await imageRequest.QueryImages(product.ImagesURL);
        return product;
    }
}
