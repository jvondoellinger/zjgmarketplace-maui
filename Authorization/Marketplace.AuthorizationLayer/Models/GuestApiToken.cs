namespace Marketplace.AuthorizationLayer.Models;

public class GuestApiToken : ApiToken
{
    public override TimeSpan Duration { get; } = TimeSpan.FromMinutes(15);
}
