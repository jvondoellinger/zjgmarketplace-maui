namespace zjgmarketplace.Modules.UI.Order.Model.Tests
{
    public class OrderPreviewModelTest
    {
        internal static List<OrderPreviewModel> Load()
        {
            var list = new List<OrderPreviewModel>();
            for (int i = 1; i <= 50; i++)
            {
                var item = new OrderPreviewModel(i, (i * 100), "Test order", DateTime.Now);
                list.Add(item);
            }
            return list;
        }
    }
}
