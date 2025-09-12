namespace zjgmarketplace.Modules.UI.Product.Model
{
    public class ProductModelTest
    {
        public static List<ProductModel> Load()
        {
            var list = new List<ProductModel>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new ProductModel()
                {
                    ImageURL = "fallback.png",
                    Price = decimal.Parse("123.11"),
                    Title = "Test"
                });
            }
            return list;
        }
    }
}
