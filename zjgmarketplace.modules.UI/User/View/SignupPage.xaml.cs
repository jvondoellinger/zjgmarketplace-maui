namespace zjgmarketplace.Modules.UI.User.View;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		InitializeComponent();
	}

    private async void SignupButton_Clicked(object sender, EventArgs e)
    {
        LoadingControl.Start();
        await Task.Delay(1200);
        LoadingControl.Stop();
    }
}