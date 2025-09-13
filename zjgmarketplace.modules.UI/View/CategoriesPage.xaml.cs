using System.Diagnostics;
using zjgmarketplace.Modules.UI.ViewModels;

namespace zjgmarketplace.Modules.UI.View;

public partial class CategoriesPage : ContentPage
{
	public CategoriesPage()
	{
		InitializeComponent();
		var m = new CategoriesViewModel();

        BindingContext = m;

		Debug.WriteLine(m.Categories.ToList());
    }
}