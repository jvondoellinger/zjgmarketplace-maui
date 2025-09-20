using System.Windows.Input;

namespace zjgmarketplace.Modules.UI.Controls.ViewModel
{
    public abstract class NavBarDialog
    {
        public string Title { get; protected init; }
        public ICommand CommandRedirect { get; protected init; }
    }
}
