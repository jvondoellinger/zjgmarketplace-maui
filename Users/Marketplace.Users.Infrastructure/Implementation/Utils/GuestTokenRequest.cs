using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Marketplace.Users.Infrastructure.Services;

namespace Marketplace.Users.Infrastructure.Implementation.Utils;

public class GuestTokenRequest
{
    private readonly string guestUrl = "http://127.0.0.1:5055/api/guest";
    private string CurrentToken { get; set; }
    private DateTime LastUpdate { get; set; }
    private int Duration { get; set; } = 30;

    public async Task<string> GetGuestTokenAsync()
    {
        var model = await RequestService.GetAsync<GuestTokenRequestModel>(guestUrl);
        CurrentToken = model?.Token;
        LastUpdate = DateTime.Now;
        
        return CurrentToken;
    }
}
