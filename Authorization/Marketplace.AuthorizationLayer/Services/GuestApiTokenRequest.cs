using Marketplace.AuthorizationLayer.Configs;
using Marketplace.AuthorizationLayer.Models;
using Marketplace.AuthorizationLayer.Models.RequestModel;
using Marketplace.AuthorizationLayer.Utils;
using System.Text.Json;

namespace Marketplace.AuthorizationLayer.Services;

public class GuestApiTokenRequest
{
    private readonly HttpClient client;
    private readonly GuestTokenUriConfig config;
    private readonly BearerTokenApplier tokenApplier;
    private readonly GuestApiToken token;

    public GuestApiTokenRequest(HttpClient client, GuestTokenUriConfig config, BearerTokenApplier tokenApplier, GuestApiToken token)
    {
        this.client = client;
        this.config = config;
        this.tokenApplier = tokenApplier;
        this.token = token;
    }

    public async Task ConfigureTokenAsync()
    {
        var result = await client.GetAsync(config.GuestApiRoute); // Get token

        if (!result.IsSuccessStatusCode) // Throw case isn't a success code
            throw new Exception("The application cannot be initialized because don't have permission to consume the API configured");

        var json = await result.Content.ReadAsStringAsync(); // Get body (JSON)
        var tokenModel = JsonSerializer.Deserialize<TokenRequestModel>(json) ?? throw new Exception("Error on initialize the application, because the recieved token isn't compatible with default model.");
        
        token.UpdateToken(tokenModel.Token);
        
        tokenApplier.ApplyOnHttpClient(client, tokenModel); //Apply token on HttpClient
    }
}
