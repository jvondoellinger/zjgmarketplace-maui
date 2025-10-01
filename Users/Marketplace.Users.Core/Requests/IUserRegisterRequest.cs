using Marketplace.Users.Core.Models;

namespace Marketplace.Users.Core.Requests;

public interface IUserRegisterRequest
{
    Task SendAsync(UserModel model);
}
