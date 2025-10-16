using Marketplace.Main.Infrastructure.DependecyInjection;
using Marketplace.Main.Infrastructure.Services;
using Marketplace.Main.UI.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Marketplace.Main.UI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        // Add settings file (.json)
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("Marketplace.Main.UI.Settings.settings.json");

        if (stream != null)
            builder
            .Configuration
            .AddJsonStream(stream);

        // Add services on container of injection dependecy
        builder.Services
            .ConfigureLayers(builder.Configuration)
            .RegisterMainOnDependecyInjection();


        var app = builder.Build();

        var background = app.Services.GetRequiredService<BackgroundServicesWorker>();
        background.StartHostedServices();

        return app;
    }
}
