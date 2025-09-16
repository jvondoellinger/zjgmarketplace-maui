using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zjgmarketplace.Modules.UI.Order.ValueObjects.Payment;

namespace zjgmarketplace.Modules.UI.Order.Model.Tests
{
    public class OrderModelTest
    {
        internal static OrderModel Load()
        {
            var item = new OrderModel()
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
