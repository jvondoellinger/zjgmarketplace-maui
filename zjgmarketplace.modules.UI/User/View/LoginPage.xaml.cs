using zjgmarketplace.Modules.UI.Controls.Views.Content;
using zjgmarketplace.Modules.UI.User.ViewModel.Login;

namespace zjgmarketplace.Modules.UI.User.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new UserLoginViewModel();

    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        LoadingControl.Start();
        await Task.Delay(1200);
        LoadingControl.Stop();
    }
}