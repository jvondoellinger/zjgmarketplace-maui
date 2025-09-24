using Marketplace.Users.Core.Interfaces;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.User.ViewModel.Login;

namespace Marketplace.Users.UI.Views;

public partial class UserLoginPage : ContentPage
{
    private readonly IPageResolver pageResolver;
    public ICommand SingupRediredtCommand { get; }
    public UserLoginViewModel UserLoginViewModel { get; } = new UserLoginViewModel();
    public UserLoginPage(IPageResolver pageResolver)
	{
        this.pageResolver = pageResolver;
        this.SingupRediredtCommand = new Command(async () =>
        {
            var page = pageResolver.Resolve<UserSignupPage>();
            await Navigation.PushAsync(page);
        });

		InitializeComponent();

        BindingContext = this;
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        await LoadingControlView.RunWithLoadingIndicator(async () =>
        {
            await Task.Delay(1000);
        });
    }
}