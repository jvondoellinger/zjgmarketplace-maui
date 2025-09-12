namespace zjgmarketplace.Modules.UI.Model
{
    public class CategoriesModel
    {
        private static readonly string _fallBackImage = "fallback.jpeg";

        public required string ImageURL { get; init; } = _fallBackImage;
        public required string CategoryText { get; init; }
    }
}
