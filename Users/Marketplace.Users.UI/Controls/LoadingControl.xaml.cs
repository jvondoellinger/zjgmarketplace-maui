using System.Diagnostics;

namespace Marketplace.Users.UI.Controls;

public partial class LoadingControl : ContentView
{
    public static readonly BindableProperty IsLoadingProperty =
        BindableProperty.Create(nameof(IsLoading), 
            typeof(bool), 
            typeof(LoadingControl),
            false,
            propertyChanged: OnIsLoadingIsChanged);

    public bool IsLoading
    {
        get => (bool) GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
        
    }

    public LoadingControl()
	{
        InitializeComponent();
    }

    private static void OnIsLoadingIsChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is LoadingControl view)
        {
            var isLoading = (bool) newValue;

            view.LoadingGrid.IsVisible = isLoading;
            view.RunningIndicator.IsRunning = isLoading;
        }
    }
}