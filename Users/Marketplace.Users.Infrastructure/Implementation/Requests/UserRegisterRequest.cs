using Marketplace.SharedLayer.Services;
using Marketplace.Users.Core.Models;
using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests.Configs;
using Marketplace.Users.Infrastructure.Implementation.Requests.Mapper;
using Marketplace.Users.Infrastructure.Implementation.Requests.RequestModel;
using Microsoft.Extensions.Options;

namespace Marketplace.Users.Infrastructure.Implementation.Requests;

public class UserRegisterRequest : IUserRegisterRequest
{
    private readonly Uri userRegisterUri;
    private readonly IOptionsMonitor<UserRoutesConfig> config;
    private readonly RequestService request;

    public UserRegisterRequest(IOptionsMonitor<UserRoutesConfig> config, RequestService request)
    {
        this.config = config;
        this.request = request;
    }

    public async Task SendAsync(UserModel model) 
    {
        var requestModel = UserRegisterRequestModelMapper.Map(model);
        await request.PostAsync<UserRegisterRequestModel>(config.CurrentValue.RegisterUri, requestModel);
    }
}
