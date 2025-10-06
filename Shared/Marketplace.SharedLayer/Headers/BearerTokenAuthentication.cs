namespace Marketplace.SharedLayer.Headers;

public class BearerTokenAuthentication
{
    public static BearerTokenAuthentication Instance { get; } = new BearerTokenAuthentication();

    private BearerTokenAuthentication()
    { }


    public string Token { get; private set; }
    public void UpdateToken(string token)
    {
        Token = token;
        UpdatedToken?.Invoke(this);
    }

    public event Action<BearerTokenAuthentication> UpdatedToken;
}
