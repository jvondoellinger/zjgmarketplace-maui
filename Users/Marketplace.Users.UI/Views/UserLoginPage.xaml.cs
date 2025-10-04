using Marketplace.Users.UI.ViewModels;

namespace Marketplace.Users.UI.Views;

public partial class UserLoginPage : ContentPage
{

    public UserLoginPage(UserLoginViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }

}