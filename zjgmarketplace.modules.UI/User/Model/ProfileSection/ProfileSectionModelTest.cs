namespace zjgmarketplace.Modules.UI.User.Model.ProfileSection
{
    public class ProfileSectionModelTest
    {
        internal static List<ProfileSectionModel> Load()
        {
            return new List<ProfileSectionModel>() { new AccountSectionModel(), new OrdersSectionModel() };
        }
    }
}
