using Marketplace.Users.Core.Models;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;

namespace Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;

public class UserLoginRequestModelMapper
{
    public static UserLoginRequestModel Map(UserModel user)
    {
        return new UserLoginRequestModel(user.Email, user.Password);
    } 
}
