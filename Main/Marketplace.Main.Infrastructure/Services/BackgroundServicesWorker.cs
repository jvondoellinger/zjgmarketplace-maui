using Microsoft.Extensions.Hosting;

namespace Marketplace.Main.Infrastructure.Services;

public class BackgroundServicesWorker
{
    private readonly IServiceProvider provider;

    public BackgroundServicesWorker(IServiceProvider provider)
    {
        this.provider = provider;
    }
    public void StartHostedServices()
    {
        var services = provider.GetServices<IHostedService>();
        if (! (services.Count() > 0)) return;

        foreach(var service in services)
        {
            _ = Task.Run(() =>
            {
                service.StartAsync(new());
            });
        }
    }
}
