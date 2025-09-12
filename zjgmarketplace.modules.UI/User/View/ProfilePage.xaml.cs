using zjgmarketplace.Modules.UI.User.ViewModel;
using zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection;

namespace zjgmarketplace.Modules.UI.User.View;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
		BindingContext = new ProfileSectionViewModel();
	}

    private void OnFrameTapped(object sender, TappedEventArgs e)
    {
		
    }
}