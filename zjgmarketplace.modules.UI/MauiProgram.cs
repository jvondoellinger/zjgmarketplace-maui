using Microsoft.Extensions.Logging;
using zjgmarketplace.Modules.UI.DependecyInjection;

namespace zjgmarketplace.modules.UI;

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

        builder
            .Services
            .AddAllDependencies();
        return builder.Build();
    }
}

