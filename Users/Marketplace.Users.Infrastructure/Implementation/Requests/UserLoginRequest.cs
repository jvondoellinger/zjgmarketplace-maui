using Marketplace.SharedLayer.Services;
using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests.Configs;
using Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Microsoft.Extensions.Options;

namespace Marketplace.Users.Infrastructure.Implementation.Requests;

public class UserLoginRequest : IUserLoginRequest
{
    private readonly IOptionsMonitor<UserRoutesConfig> config;
    private readonly RequestService request;

    public UserLoginRequest(IOptionsMonitor<UserRoutesConfig> config, RequestService request)
    {
        this.config = config;
        this.request = request;
    }

    public async Task SendAsync(UserModel model)
    {
        var requestModel = UserLoginRequestModelMapper.Map(model);
        
    }
}
