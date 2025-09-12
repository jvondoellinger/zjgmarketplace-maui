using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.User.Model.ProfileSection;

namespace zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection
{
    public class ProfileSectionViewModel
    {
        public ProfileSectionViewModel() { }

        public ObservableCollection<ProfileSectionModel> ProfileSections { get; } = new (ProfileSectionModelTest.Load());
    }
}
