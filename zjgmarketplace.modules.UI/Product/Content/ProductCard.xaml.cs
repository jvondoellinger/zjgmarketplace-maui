using System.Threading.Tasks;
using zjgmarketplace.Modules.UI.Order.View;
using zjgmarketplace.Modules.UI.Product.ViewModel;

namespace zjgmarketplace.Modules.UI.Product.Content;

public partial class ProductCard : ContentView
{
	public static BindableProperty ProductViewModelProperty = BindableProperty.Create(
		nameof(ProductViewModel),
		typeof(PreviewProductViewModel),
		typeof(ProductCard),
		default(PreviewProductViewModel),
		propertyChanged: OnProductViewModelChanged);


	private PreviewProductViewModel product;
    public PreviewProductViewModel ProductViewModel { get; set; }

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
        await Task.Delay(10);
    }
}