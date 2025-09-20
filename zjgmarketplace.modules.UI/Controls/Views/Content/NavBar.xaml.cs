using System.Collections.ObjectModel;
using zjgmarketplace.Modules.UI.Controls.ViewModel;

namespace zjgmarketplace.Modules.UI.Controls.Views.Content;

public partial class NavBar : ContentView
{
	public ObservableCollection<NavBarDialog> NavBarDialogs { get; } = [];
	public NavBar()
	{
		InitializeComponent();
		BindingContext = this;

		// Temporary data loader
        NavBarDialogFactory
			.CreateNavBarDialogs()
			.ForEach(NavBarDialogs.Add);
    }
}