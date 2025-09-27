using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.State;
using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.Views.Content;

public partial class ProductCard : ContentView
{
    public static BindableProperty ProductCardViewModelProperty = BindableProperty.Create(
        nameof(ProductCardViewModel),
        typeof(ProductCardViewModel),
        typeof(ProductCard),
        default(ProductCardViewModel),
        propertyChanged: OnProductViewModelChanged);

    public ProductCardViewModel ProductCardViewModel
    {
        get => (ProductCardViewModel)GetValue(ProductCardViewModelProperty);
        set => SetValue(ProductCardViewModelProperty, value);
    }

    public static void OnProductViewModelChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ProductCard control)
        {
            control.BindingContext = newValue;
        }
    }

    public ProductCard()
	{
		InitializeComponent();
	}

    private void ButtonAddToCart_Clicked(object sender, EventArgs e)
    {
        
    }
}