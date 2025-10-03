using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Marketplace.Users.Infrastructure.Services;
using System.Diagnostics;

namespace Marketplace.Users.Infrastructure.Implementation.Requests;

public class UserRegisterRequest : IUserRegisterRequest
{
    private readonly string url = "http://127.0.0.1:5055/api/user/register";
    private readonly string guestUrl = "http://127.0.0.1:5055/api/guest";
    private string token;
    public UserRegisterRequest()
    {
        
    }

    public async Task SendAsync(UserModel model) 
    {
        await GetGuestTokenAsync();
        var request = UserRegisterRequestModelMapper.Map(model);
        await RequestService.PostAsync<UserRegisterRequestModel>(url, request, token);
    }

    private async Task GetGuestTokenAsync()
    {
        var model = await RequestService.GetAsync<GuestTokenRequest>(guestUrl);
        token = model?.Token;
    }
}
