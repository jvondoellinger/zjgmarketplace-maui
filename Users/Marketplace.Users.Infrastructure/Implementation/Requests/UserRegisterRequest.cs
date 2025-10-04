using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Marketplace.Users.Infrastructure.Implementation.Utils;
using Marketplace.Users.Infrastructure.Services;
using System.Diagnostics;

namespace Marketplace.Users.Infrastructure.Implementation.Requests;

public class UserRegisterRequest : IUserRegisterRequest
{
    private readonly string url = "http://127.0.0.1:5055/api/user/register";
    private readonly GuestTokenRequest guestTokenRequest;

    public UserRegisterRequest(GuestTokenRequest guestTokenRequest)
    {
        this.guestTokenRequest = guestTokenRequest;
    }

    public async Task SendAsync(UserModel model) 
    {
        var request = UserRegisterRequestModelMapper.Map(model);
        await RequestService.PostAsync<UserRegisterRequestModel>(url, request, await guestTokenRequest.GetGuestTokenAsync());
    }


}
