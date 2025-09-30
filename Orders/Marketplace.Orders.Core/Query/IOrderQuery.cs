using Marketplace.Orders.Core.Models;

namespace Marketplace.Orders.Core.Query;

public interface IOrderQuery
{
    Task<OrderModel> QueryId(long id);
    Task<IEnumerable<OrderModel>> QueryPagination(int offset, int limit);
}
