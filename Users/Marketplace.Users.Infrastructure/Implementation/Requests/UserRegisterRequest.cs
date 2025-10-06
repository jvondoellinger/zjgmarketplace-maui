using Marketplace.SharedLayer.Configs;
using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Marketplace.Users.Infrastructure.Implementation.Utils;
using Marketplace.Users.Infrastructure.Services;

namespace Marketplace.Users.Infrastructure.Implementation.Requests;

public class UserRegisterRequest : IUserRegisterRequest
{
    private readonly GuestTokenRequest guestTokenRequest;
    private readonly Uri userRegisterUri;

    public UserRegisterRequest(GuestTokenRequest guestTokenRequest)
    {
        this.guestTokenRequest = guestTokenRequest;
        var uri = CurrentRequestURI.Default().Uri;
        userRegisterUri = new(uri, "/api/user/register");
    }

    public async Task SendAsync(UserModel model) 
    {
        var request = UserRegisterRequestModelMapper.Map(model);
        var token = await guestTokenRequest.GetGuestTokenAsync();
        await RequestService.PostAsync<UserRegisterRequestModel>(userRegisterUri.ToString(), request, token);
    }


}
