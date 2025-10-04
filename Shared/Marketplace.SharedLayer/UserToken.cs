namespace Marketplace.SharedLayer;

public class UserToken
{
    public static UserToken Instance { get; } = new ();
    private UserToken()
    {
        
    }
    public static string Token { get; private set; }
    public static void UpdateToken(string token)
    {
        Token = token;
    }
}
