using Marketplace.AuthorizationLayer.Configs;
using Marketplace.AuthorizationLayer.Models;
using Marketplace.AuthorizationLayer.Models.RequestModel;
using Marketplace.AuthorizationLayer.Utils;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace Marketplace.AuthorizationLayer.Services;

public class UserApiTokenRequest
{
    private readonly HttpClient client;
    private readonly IOptionsMonitor<UserTokenUriConfig> config;
    private readonly BearerTokenApplier tokenApplier;
    private readonly UserApiToken token;

    public UserApiTokenRequest(HttpClient client, IOptionsMonitor<UserTokenUriConfig> config, BearerTokenApplier tokenApplier, UserApiToken token)
    {
        this.client = client;
        this.config = config;
        this.tokenApplier = tokenApplier;
        this.token = token;
    }
    public async Task ConfigureTokenAsync(UserApiCredentials credentials)
    {
        var serialized = JsonSerializer.Serialize(credentials);
        var content = new StringContent(serialized, encoding: Encoding.UTF8, "application/json");
        var result = await client.PostAsync(config.CurrentValue.UserTokenUri, content); // Send credentials and get token (if autentified)

        if (!result.IsSuccessStatusCode) // Throw case isn't a success code
            throw new Exception("The application cannot be initialized because don't have permission to consume the API configured");

        var body = await result.Content.ReadAsStringAsync(); // Get body (JSON)

        var tokenModel = JsonSerializer.Deserialize<TokenRequestModel>(body) ?? throw new Exception("Error on initialize the application, because the recieved token isn't compatible with default model.");

        token.UpdateToken(tokenModel.Token);

        tokenApplier.ApplyOnHttpClient(client, tokenModel); //Apply token on HttpClient
    }
}
