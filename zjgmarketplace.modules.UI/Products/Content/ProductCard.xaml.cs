using zjgmarketplace.Modules.UI.Products.ViewModel;

namespace zjgmarketplace.Modules.UI.Products.Content;

public partial class ProductCard : ContentView
{
	public static BindableProperty ProductViewModelProperty = BindableProperty.Create(
		nameof(ProductViewModel),
		typeof(PreviewProductViewModel),
		typeof(ProductCard),
		default(PreviewProductViewModel),
		propertyChanged: OnProductViewModelChanged);

    public PreviewProductViewModel ProductViewModel
    {
        get => (PreviewProductViewModel)GetValue(ProductViewModelProperty);
        set => SetValue(ProductViewModelProperty, value);
    }

    public ProductCard()
	{
        InitializeComponent();
    }

    public static void OnProductViewModelChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ProductCard control)
        {
            control.BindingContext = newValue;
        }
    }

    private async void ButtonRedirectToOrderPage_Clicked(object sender, EventArgs e)
    {
        //var model = ProductViewModelMapper.Map(ProductViewModel); // Interface que vai capturar esse item no backend/cache do app (usando o padrão proxy)
        // state.SelectProduct(ProductViewModel.Id);
        // await Navigation.PushAsync(productPage);
    }
}