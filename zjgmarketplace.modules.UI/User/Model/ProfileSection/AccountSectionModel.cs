using System.Diagnostics;
using System.Windows.Input;

namespace zjgmarketplace.Modules.UI.User.Model.ProfileSection
{
    public class AccountSectionModel : ProfileSectionModel
    {
        public AccountSectionModel()
        {
            Name = "Account";
            Command =  new Command(() =>
            {
                Debug.WriteLine("Batata");
            });
        }
    }
}
