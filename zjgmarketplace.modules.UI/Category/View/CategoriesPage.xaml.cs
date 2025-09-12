using System.Diagnostics;
using zjgmarketplace.Modules.UI.Category.ViewModel;

namespace zjgmarketplace.Modules.UI.Category.View;

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