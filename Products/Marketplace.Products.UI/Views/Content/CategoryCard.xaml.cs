using Marketplace.Products.UI.ViewModel;

namespace Marketplace.Products.UI.Views.Content;

public partial class CategoryCard : ContentView
{
    public ProductCategoryViewModel ProductCategoryViewModel { get; set; }

	public static BindableProperty ProductCategoryViewModelProperty = BindableProperty.Create(
		nameof(ProductCategoryViewModel),
		typeof(ProductCategoryViewModel),
		typeof(CategoryCard),
		default(ProductCategoryViewModel),
		propertyChanged: OnProductCategoryViewModelChanged);

	public static void OnProductCategoryViewModelChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is CategoryCard control)
		{
			control.BindingContext = newValue;
        }
    }

    public CategoryCard()
	{
		InitializeComponent();
	}
}