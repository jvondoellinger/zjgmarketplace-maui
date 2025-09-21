using System.Diagnostics;
using zjgmarketplace.Modules.UI.Order.View;
using zjgmarketplace.Modules.UI.Products.View;
using zjgmarketplace.Modules.UI.User.View;

namespace zjgmarketplace.modules.UI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            var page = App.Services.GetService<PreviewProductsPage>();
            _ = Task.Run(async () => await Shell.Current.Navigation.PushAsync(page));
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(LoginPage.Route, typeof(LoginPage));
            Routing.RegisterRoute(OrdersPreviewPage.Route, typeof(OrdersPreviewPage));
            Routing.RegisterRoute(PreviewProductsPage.Route, typeof(PreviewProductsPage));

        }
    }
}
