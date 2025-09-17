using zjgmarketplace.Modules.UI.Order.View;

namespace zjgmarketplace.modules.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
