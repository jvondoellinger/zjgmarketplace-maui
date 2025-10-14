using Marketplace.Main.Infrastructure.DependecyInjection;
using Marketplace.Main.UI.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Marketplace.Main.UI
{
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
            builder
                .Configuration
                .AddJsonFile("Settings/settings.json", optional: false, reloadOnChange: true);

            // Add services on container of injection dependecy
            builder.Services
                .ConfigureLayers(builder.Configuration)
                .RegisterMainOnDependecyInjection();


            return builder.Build();
        }
    }
}
