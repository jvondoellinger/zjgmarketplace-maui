using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace Marketplace.Products.UI.Views.Content;

public partial class ProductCard : ContentView
{

    public static BindableProperty PreviewProductViewModelProperty = BindableProperty.Create(
        nameof(PreviewProductViewModel),
        typeof(PreviewProductViewModel),
        typeof(ProductCard),
        default(PreviewProductViewModel),
        propertyChanged: OnProductViewModelChanged);

    public PreviewProductViewModel PreviewProductViewModel
    {
        get => (PreviewProductViewModel)GetValue(PreviewProductViewModelProperty);
        set => SetValue(PreviewProductViewModelProperty, value);
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

    private void ButtonRedirectToOrderPage_Clicked(object sender, EventArgs e)
    {

    }
}