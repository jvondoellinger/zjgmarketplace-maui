using Marketplace.SharedLayer.Configs;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Marketplace.Users.Infrastructure.Services;

namespace Marketplace.Users.Infrastructure.Implementation.Utils;

public class GuestTokenRequest
{
    private readonly Uri guestUri;
    public GuestTokenRequest()
    {
        var uri = CurrentRequestURI.Default().Uri;
        guestUri = new(uri, "/api/guest");
    }
    private string CurrentToken { get; set; }
    private DateTime LastUpdate { get; set; }
    private int Duration { get; set; } = 30;

    public async Task<string> GetGuestTokenAsync()
    { 
        var model = await RequestService.GetAsync<GuestTokenRequestModel>(guestUri.ToString());
        CurrentToken = model?.Token;
        LastUpdate = DateTime.Now;
        
        return CurrentToken;
    }
}
