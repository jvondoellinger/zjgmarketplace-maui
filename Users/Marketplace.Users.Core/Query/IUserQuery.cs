using Marketplace.Users.Core.Models;

namespace Marketplace.Users.Core.Query;

public interface IUserQuery
{
    Task<IEnumerable<UserModel>> QueryPagination(long offset, int limit);
    Task<UserModel> QueryId(string id);
}
