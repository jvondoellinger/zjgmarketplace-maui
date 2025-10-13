namespace Marketplace.AuthorizationLayer.Events;

public class TokenRefreshEventArgs
{
    public DateTime OccuredOn { get; }
    public Guid LoginId { get; }
}



