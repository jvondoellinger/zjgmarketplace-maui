using zjgmarketplace.Modules.UI.Order.Model;

namespace zjgmarketplace.Modules.UI.Order.Singleton
{
    internal static class StoreOrder
    {
        public static OrderPreviewModel PreviewModel { get; private set; }
        public static OrderModel OrderModel { get; private set; }

        public static void StorePreviewModel(OrderPreviewModel previewModel)
        {
            PreviewModel = previewModel;
        }
        public static void StoreOrderModel(OrderModel orderModel)
        {
            OrderModel = orderModel;
        }
    }
}
