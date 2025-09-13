namespace zjgmarketplace.Modules.UI.Controls.Views.Content;

public partial class LoadingGrid : ContentView
{
	public LoadingGrid()
	{
		InitializeComponent();
	}

	public void Start() 
	{
        LoadingIndicator.IsRunning = true;
        LoadingGridIndicator.IsVisible = true;
    }

    public void Stop()
    {
        LoadingIndicator.IsRunning = false;
        LoadingGridIndicator.IsVisible = false;
    }
}