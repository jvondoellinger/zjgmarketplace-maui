using System.Collections.ObjectModel;
using System.Diagnostics;
using zjgmarketplace.Modules.UI.User.ViewModel;
using zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection;
using zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection.Test;

namespace zjgmarketplace.Modules.UI.User.View;

public partial class ProfilePage : ContentPage
{
    public ObservableCollection<ProfileSectionViewModel> ProfileSectionViewModel { get; } = new();
    public ProfileSectionViewModel? selectedProfileSectionViewModel;
    public ProfileSectionViewModel? SelectedProfileSectionViewModel
    {
        get => selectedProfileSectionViewModel;
        set
        {
            if (value == null) return;
            if (!value.Equals(selectedProfileSectionViewModel))
            {
                Debug.WriteLine("Acha que é facil?");
                value.RedirectCommand.Execute(null);
                selectedProfileSectionViewModel = value;    
            }
        }
    }

    public ProfilePage()
	{
		InitializeComponent();

        // Temporary data loader
        ProfileSectionViewModelTest.Load().ForEach(ProfileSectionViewModel.Add);

        BindingContext = this;
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Debug.WriteLine("Acha que é facil?");
        Debug.WriteLine("Acha que é facil?");
        Debug.WriteLine("Acha que é facil?");
        Debug.WriteLine("Acha que é facil?");
        Debug.WriteLine("Acha que é facil?");

        var selected = e.CurrentSelection.FirstOrDefault() as ProfileSectionViewModel;
        Debug.WriteLine(selected?.Name);
    }
}