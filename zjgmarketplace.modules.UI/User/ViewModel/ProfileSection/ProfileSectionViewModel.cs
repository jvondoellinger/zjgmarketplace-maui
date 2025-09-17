using System.Windows.Input;

namespace zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection
{
    public abstract class ProfileSectionViewModel
    {
        public string Name { get; init; }
        public ICommand RedirectCommand { get; init; }
    }
}
