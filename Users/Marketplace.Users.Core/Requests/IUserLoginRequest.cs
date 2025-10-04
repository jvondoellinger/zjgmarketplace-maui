using Marketplace.Users.Core.Models;

namespace Marketplace.Users.Core.Requests;

public interface IUserLoginRequest
{
    Task SendAsync(UserModel model);
}
