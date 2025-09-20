using System.Diagnostics;

namespace zjgmarketplace.Modules.UI.Controls.ViewModel;
public class AccountNavBarDialog : NavBarDialog
{
    public AccountNavBarDialog()
    {
        Title = "Account";
        CommandRedirect = new Command(() => {
            Debug.WriteLine("BATATATATA");
        });
    }
}

