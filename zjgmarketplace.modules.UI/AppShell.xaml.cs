using zjgmarketplace.Modules.UI.Order.View;
using zjgmarketplace.Modules.UI.User.View;

namespace zjgmarketplace.modules.UI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(LoginPage.Route, typeof(LoginPage));
            Routing.RegisterRoute(OrdersPreviewPage.Route, typeof(OrdersPreviewPage));
        }
    }
}
