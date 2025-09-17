using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.Modules.UI.Order.ViewModel.Tests
{
    public class OrderPreviewModelTest
    {
        private static List<OrderPreviewModelView> orderPreviewModelViews;
        internal static List<OrderPreviewModelView> Load()
        {
            if(orderPreviewModelViews != null) return orderPreviewModelViews;  
            var list = new List<OrderPreviewModelView>();
            for (int i = 1; i <= 50; i++)
            {
                var item = new OrderPreviewModelView()
                {
                    Id = i,
                    Title = "Testing order; iteraction: " + i,
                    Price = i * 100,
                    CreatedAt = DateTime.Now
                };
                list.Add(item);
            }
            orderPreviewModelViews = list;
            return orderPreviewModelViews;
        }
    }
}
