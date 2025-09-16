using Microsoft.Extensions.Logging;
using zjgmarketplace.Modules.UI.DependecyInjection;
using zjgmarketplace.Modules.UI.Order.Model.Tests;
using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.modules.UI
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
            builder
                .Services
                .AddAllDependencies();
            return builder.Build();
        }
    }
}

