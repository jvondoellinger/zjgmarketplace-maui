namespace Marketplace.SharedLayer;

public class UserToken
{
    public static string Token { get; private set; }
    public static void UpdateToken(string token)
    {
        Token = token;
    }
}
