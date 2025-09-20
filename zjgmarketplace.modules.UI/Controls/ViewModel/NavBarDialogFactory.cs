namespace zjgmarketplace.Modules.UI.Controls.ViewModel
{
    public class NavBarDialogFactory
    {
        public static List<NavBarDialog> CreateNavBarDialogs()
        {
            return new List<NavBarDialog>
            {
                new MainNavBarDialog(),
                new CartNavBarDialog(),
                new AccountNavBarDialog()
            };
        }
    }
}
