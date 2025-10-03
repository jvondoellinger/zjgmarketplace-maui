using Marketplace.Users.Core.Interfaces;
using Marketplace.Users.UI.ViewModels;
using System.Windows.Input;

namespace Marketplace.Users.UI.Views;

public partial class UserSignupPage : ContentPage
{
    public UserSignupPage(UserSignupViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
    }

    private async void SignupButton_Clicked(object sender, EventArgs e)
    {
        await LoadingControlView.RunWithLoadingIndicator(async () =>
        {
            await Task.Delay(1000);
        });
    }
}