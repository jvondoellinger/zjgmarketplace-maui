using System.Diagnostics;

namespace Marketplace.Users.UI.Controls;

public partial class LoadingControl : ContentView
{
    public static readonly BindableProperty IsLoadingProperty =
        BindableProperty.Create(nameof(IsLoading), 
            typeof(bool), 
            typeof(LoadingControl),
            false);

    public bool IsLoading
    {
        get => (bool) GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
    }

    public LoadingControl()
	{
        InitializeComponent();

        BindingContext = this;
    }

	private void Show()
	{
        if (IsLoading) return;
        IsLoading = true;
    }
    private void Hide()
	{
        if (!IsLoading) return;
        IsLoading = false;
    }

    public async Task RunWithLoadingIndicator(Func<Task> action)
    {
        if (!IsLoading)
        {
            Show();
            await action.Invoke(); //Simulação
            Hide();
        }
    }


}