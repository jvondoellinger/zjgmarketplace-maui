using System.Diagnostics;

namespace zjgmarketplace.Modules.UI.User.Model.ProfileSection
{
    public class OrdersSectionModel : ProfileSectionModel
    {
        public OrdersSectionModel()
        {
            Name = "Orders";
            Command = new Command(() =>
            {
                Debug.WriteLine("Batata");
            });
        }
    }
}
