using zjgmarketplace.Modules.UI.Order.ValueObjects.Payment;
using zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection.Sections;

namespace zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection.Test
{
    internal class ProfileSectionViewModelTest
    {
        internal static List<ProfileSectionViewModel> Load()
        {
            return [new AccountSectionViewModel(), new OrdersSectionViewModel() ];
        }
    }
}
