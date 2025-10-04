using Marketplace.Users.Core.Requests;
using Marketplace.Users.Infrastructure.Implementation.Requests;
using Marketplace.Users.Infrastructure.Implementation.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Users.Infrastructure.DependecyInjection;

public static class UserInfrastructureInjection
{
    public static IServiceCollection RegisterUserInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IUserRegisterRequest, UserRegisterRequest>();
        services.AddSingleton<IUserLoginRequest, UserLoginRequest>();
        services.AddSingleton<GuestTokenRequest>();
        return services;
    }
}
