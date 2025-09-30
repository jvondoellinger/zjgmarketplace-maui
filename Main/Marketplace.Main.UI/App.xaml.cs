namespace Marketplace.Main.UI
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }
        public App(IServiceProvider provider)
        {
            InitializeComponent();

            Services = provider;
            
            MainPage = new AppShell();
        }
    }
}
