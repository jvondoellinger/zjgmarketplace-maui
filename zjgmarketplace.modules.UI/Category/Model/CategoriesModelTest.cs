namespace zjgmarketplace.Modules.UI.Category.Model
{
    internal class CategoriesModelTest
    {
        internal static List<CategoriesModel> Load()
        {
            return new List<CategoriesModel>()
            {
                {
                    new()
                    {
                        CategoryText = "Test",
                        ImageURL = "fallback.png"
                    }
                },
                                {
                    new()
                    {
                        CategoryText = "Test",
                        ImageURL = "fallback.png"
                    }
                },
                                                {
                    new()
                    {
                        CategoryText = "Test",
                        ImageURL = "fallback.png"
                    }
                }
            };
        }
    }
}
