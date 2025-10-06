namespace Marketplace.SharedLayer.Configs;

public class CurrentRequestURI
{
    public Uri Uri { get; init; } = new Uri("http://127.0.0.1:5055");

    public static CurrentRequestURI Default() => new ();
}
