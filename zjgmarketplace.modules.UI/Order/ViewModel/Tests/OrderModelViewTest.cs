using zjgmarketplace.Modules.UI.Order.ValueObjects.Payment;
using zjgmarketplace.Modules.UI.Order.ViewModel;

namespace zjgmarketplace.Modules.UI.Order.ViewModel.Tests
{
    public class OrderModelViewTest
    {
        internal static OrderModelView Load()
        {
            var item = new OrderModelView()
            {
                CreatedAt = DateTime.Now,
                OrderId = 10,
                PaymentMethods = [new PixPaymentMethod()],
                Price = 10 * 100,
                Status = "Aguardando aprovação",
                Title = "SSD Kingston NV3, 1 TB, M.2 2280, PCIe 4.0 x4, NVMe, Leitura: 6000 MB/s, Gravação: 4000 MB/s, Azul - SNV3S/1000G"
            };
            return item;
        }
    }
}
