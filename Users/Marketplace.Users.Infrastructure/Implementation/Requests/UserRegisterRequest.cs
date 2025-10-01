using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;
using Marketplace.Users.Infrastructure.Services;

namespace Marketplace.Users.Infrastructure.Implementation.Requests;

public class UserRegisterRequest : IUserRegisterRequest
{
    private readonly string url = "localhost:5055/api/user/register";
    private readonly string guestUrl = "localhost:5055/api/guest";

    public UserRegisterRequest()
    {
        
    }

    public async Task SendAsync(UserModel model) 
    {
        var request = UserRegisterRequestModelMapper.Map(model);
        await RequestService.PostAsync(url, request);
        await RequestService.PostAsync(url, request);
    }

    private async Task GetGuestTokenAsync()
    {
        await RequestService.GetAsync(guestUrl);
    }
}
