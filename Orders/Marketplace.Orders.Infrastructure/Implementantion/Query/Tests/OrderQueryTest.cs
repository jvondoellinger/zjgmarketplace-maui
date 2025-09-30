using Marketplace.Orders.Core.Models;
using Marketplace.Orders.Core.Query;

namespace Marketplace.Orders.Infrastructure.Implementantion.Query.Tests;

public class OrderQueryTest : IOrderQuery
{
    private static List<OrderModel> Orders { get; } = Load();

    private static List<OrderModel> Load()
    {
        List<OrderModel> orders = [];
        for (int i = 0; i < 50; i++)
        {
            var item = new OrderModel()
            {
                Id = long.Parse(i.ToString()),
                Price = i*100,
                Status = "Developing",
                ImagePath = "fallback.png",
                Code = $"123_{i}" ,
                CreatedAt = DateTime.Now
            };
            orders.Add(item);
        }
        return orders;
    }

    public async Task<OrderModel> QueryId(long id)
    {
        return Orders.FirstOrDefault(x => x.Id.Equals(id));
    }

    public async Task<IEnumerable<OrderModel>> QueryPagination(int offset, int limit)
    {
        return Orders
            .Skip(offset)
            .Take(limit);
    }
}
