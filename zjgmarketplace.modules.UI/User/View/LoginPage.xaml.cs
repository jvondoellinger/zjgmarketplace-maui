using zjgmarketplace.Modules.UI.User.ViewModel.Login;

namespace zjgmarketplace.Modules.UI.User.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new UserLoginViewModel();

    }
}