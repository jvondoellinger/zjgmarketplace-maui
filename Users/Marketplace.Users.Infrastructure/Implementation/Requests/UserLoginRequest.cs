using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Marketplace.Users.Infrastructure.Implementation.Utils;
using Marketplace.Users.Infrastructure.Services;

namespace Marketplace.Users.Infrastructure.Implementation.Requests;

public class UserLoginRequest : IUserLoginRequest
{
    private readonly string url = "http://127.0.0.1:5055/api/user/login";
    private readonly GuestTokenRequest request;

    public UserLoginRequest(GuestTokenRequest request)
    {
        this.request = request;
    }

    public async Task SendAsync(UserModel model)
    {
        var requestModel = UserLoginRequestModelMapper.Map(model);
        await RequestService.PostAsync<UserLoginRequestModel>(url, requestModel, await request.GetGuestTokenAsync());
    }
}
