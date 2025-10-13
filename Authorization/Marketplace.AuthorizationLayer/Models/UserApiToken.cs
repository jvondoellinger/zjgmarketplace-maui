namespace Marketplace.AuthorizationLayer.Models;

public class UserApiToken : ApiToken
{
    public override TimeSpan Duration { get; } = TimeSpan.FromHours(1);
}
