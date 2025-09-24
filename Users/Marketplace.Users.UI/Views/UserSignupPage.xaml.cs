using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.ViewModels;
using System.Windows.Input;

namespace Marketplace.Users.UI.Views;

public partial class UserSignupPage : ContentPage
{
    public ICommand LoginRediredtCommand { get; }
    public UserSignupViewModel UserSignupViewModel { get; } = new UserSignupViewModel();
    public UserSignupPage()
	{
        this.LoginRediredtCommand = new Command(async () => await Navigation.PopAsync());

        InitializeComponent();

        BindingContext = this;
    }

    private async void SignupButton_Clicked(object sender, EventArgs e)
    {
        await LoadingControlView.RunWithLoadingIndicator(async () =>
        {
            await Task.Delay(1000);
        });
    }
}