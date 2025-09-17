using zjgmarketplace.Modules.UI.Order.View;
using zjgmarketplace.Modules.UI.User.View;

namespace zjgmarketplace.Modules.UI.User.ViewModel.ProfileSection.Sections;

public class OrdersSectionViewModel : ProfileSectionViewModel
{
    public OrdersSectionViewModel()
    {
        Name = "Orders";
        RedirectCommand = new Command(async () =>
        {
            await Shell.Current.GoToAsync(OrdersPreviewPage.Route);
        });
    }
}
