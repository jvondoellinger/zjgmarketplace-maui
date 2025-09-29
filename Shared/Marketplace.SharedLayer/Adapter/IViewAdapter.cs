namespace Marketplace.SharedLayer.Prototype;

public interface IViewAdapter
{
    T GetPage<T>() where T : ContentPage;
    T GetContent<T>() where T : ContentView;
}
