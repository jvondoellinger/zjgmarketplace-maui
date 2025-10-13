using Marketplace.AuthorizationLayer.Configs;
using Marketplace.AuthorizationLayer.Models;
using Marketplace.AuthorizationLayer.Services;
using Marketplace.AuthorizationLayer.Utils;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Marketplace.AuthorizationLayer.Startup;

public class LoadGuestApiToken : BackgroundService
{
    private readonly GuestApiTokenRequest guestApiTokenRequest;

    public LoadGuestApiToken(GuestApiTokenRequest guestApiTokenRequest)
    {
        this.guestApiTokenRequest = guestApiTokenRequest;
    }

    public override async Task StartAsync(CancellationToken stoppingToken)
    {
        Debug.WriteLine("Starting service...");
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await guestApiTokenRequest.ConfigureTokenAsync();
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        Debug.WriteLine("Stopping service...");

    }
}
