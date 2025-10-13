using Marketplace.AuthorizationLayer.Models;
using Marketplace.AuthorizationLayer.Models.RequestModel;
using System.Net.Http.Headers;

namespace Marketplace.AuthorizationLayer.Utils;

public class BearerTokenApplier
{
    public void ApplyOnHttpClient(HttpClient client, TokenRequestModel token)
    {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
    }

    public void ApplyOnHttpClient(HttpClient client, ApiToken token)
    {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
    }
}
