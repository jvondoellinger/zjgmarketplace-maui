using zjgmarketplace.Modules.UI.Order.View;

namespace zjgmarketplace.modules.UI
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }
        public App(IServiceProvider provider)
        {
            Services = provider;
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
