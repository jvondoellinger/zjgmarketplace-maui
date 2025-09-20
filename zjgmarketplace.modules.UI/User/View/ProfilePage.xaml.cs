using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using zjgmarketplace.Modules.UI.User.ViewModel;
using zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection;
using zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection.Test;

namespace zjgmarketplace.Modules.UI.User.View;

public partial class ProfilePage : ContentPage, INotifyPropertyChanged
{

    public ObservableCollection<ProfileSectionViewModel> ProfileSectionViewModel { get; } = new();

    public ProfilePage()
	{
		InitializeComponent();

        // Temporary data loader
        ProfileSectionViewModelTest.Load().ForEach(ProfileSectionViewModel.Add);

        BindingContext = this;
	}
}