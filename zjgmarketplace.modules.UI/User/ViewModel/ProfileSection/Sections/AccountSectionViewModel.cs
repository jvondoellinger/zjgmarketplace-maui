using System.Diagnostics;
using System.Windows.Input;
using zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection;

namespace zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection.Sections;

public class AccountSectionViewModel : ProfileSectionViewModel
{
    public AccountSectionViewModel()
    {
        Name = "Account";
        RedirectCommand =  new Command(() =>
        {
            Debug.WriteLine("Batata");
        });
    }
}
