using zjgmarketplace.Modules.UI.User.ViewModel.Signup;

namespace zjgmarketplace.Modules.UI.User.View;

public partial class SignupPage : ContentPage
{
    public UserSignupViewModel UserSignupViewModel { get; set; }
    public SignupPage()
	{
		InitializeComponent();

        // Temporary data loader
        UserSignupViewModel = new();

        BindingContext = this;

    }

    private async void SignupButton_Clicked(object sender, EventArgs e)
    {
        LoadingControl.Start();
        await Task.Delay(1200);
        LoadingControl.Stop();
    }
}