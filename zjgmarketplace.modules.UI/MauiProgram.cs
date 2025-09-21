using Microsoft.Extensions.Logging;
using System.Diagnostics;
using zjgmarketplace.Modules.UI.DependecyInjection;
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
            var builded = builder.Build();
            var hash = builded.Services.GetHashCode();

            // App.Services = builded.Services;
            
            Debug.WriteLine(hash);
            return builded;
        }
    }
}

