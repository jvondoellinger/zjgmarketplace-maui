using Marketplace.Products.Core.Events;
using Marketplace.Products.Core.Interfaces;
using Marketplace.Products.Core.Model;
using Marketplace.Products.Core.Query;
using Marketplace.Products.Core.State;
using Marketplace.Products.Core.Workers;
using Marketplace.Products.UI.Interfaces;
using Marketplace.Products.UI.Mapper;
using Marketplace.Products.UI.ViewModel;
using Marketplace.Products.UI.ViewModel.Cards;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Marketplace.Products.UI.Views;

public partial class ProductCartPage : ContentPage
{

    public ProductCartPage(ProductCartViewModel viewModel)
    {
		InitializeComponent();

        BindingContext = viewModel;
    }
}