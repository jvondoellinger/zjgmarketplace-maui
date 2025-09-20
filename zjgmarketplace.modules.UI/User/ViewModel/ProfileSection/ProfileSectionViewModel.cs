using System.Windows.Input;
using zjgmarketplace.Modules.UI.Global.BaseModel;

namespace zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection
{
    public abstract class ProfileSectionViewModel : PropertyNotifier
    {
        public string Name { get; init; }
        public ICommand RedirectCommand { get; init; }

        public ProfileSectionViewModel selectedItem;
        public ProfileSectionViewModel SelectedItem
        {
            get => selectedItem;
            set
            {
                if (!value.Equals(selectedItem))
                {
                    selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }


    }
}
