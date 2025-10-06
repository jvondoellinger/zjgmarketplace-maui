using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Requests;
using Marketplace.Products.Infrastructure.Implementations.Requests.Commands.Models;
using Marketplace.SharedLayer.Configs;
using Marketplace.SharedLayer.Headers;
using Marketplace.SharedLayer.Services;

namespace Marketplace.Products.Infrastructure.Implementations.Requests.Commands;

public class ProductCartCommandRequest : IProductCartCommandRequest
{

    private readonly BearerTokenAuthentication header = BearerTokenAuthentication.Instance;
    private readonly Uri cartUri;
    public ProductCartCommandRequest()
    {
        var uri = CurrentRequestURI.Default().Uri;
        cartUri = new Uri(uri, "/api/order");
    }

    public async Task SendAsync(ProductCart model)
    {
        await RequestService.PostAsync<CreateOrderRequestOutputModel>(cartUri.ToString(), model, header.Token);
    }
}
