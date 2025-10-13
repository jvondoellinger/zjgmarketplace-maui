using Marketplace.AuthorizationLayer.Events;
using System.Diagnostics;

namespace Marketplace.AuthorizationLayer.Models;

public abstract class ApiToken
{
    public string Token { get; protected set; }
    public abstract TimeSpan Duration { get; }
    public void UpdateToken(string token)
    {
        Token = token;
        OnTokenRefresh(this, new());
    }

    // Delegates ------------------------------------------------------
    public delegate Task RefreshTokenAsync(string token);

    // Event ----------------------------------------------------------
    public event RefreshTokenAsync OnApiTokenRefresh;
    protected virtual void OnTokenRefresh(object sender, TokenRefreshEventArgs args)
    {
        Debug.WriteLine($"Token refreshied. OccorredOn: {args.OccuredOn} ID: {args.LoginId} By: {sender.GetType()}");
    }
}
