using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.Modules.UI.Order.Mapper
{
    internal class OrderModelViewTransformer
    {
        private OrderModelViewTransformer()
        {
            
        }
        internal static OrderModelView Transform(OrderPreviewModelView modelView)
        {
            return new OrderModelView()
            {
                Title = modelView.Title,
                CreatedAt = modelView.CreatedAt,
                OrderId = modelView.Id,
                Price = modelView.Price
            };
        }
    }
}
