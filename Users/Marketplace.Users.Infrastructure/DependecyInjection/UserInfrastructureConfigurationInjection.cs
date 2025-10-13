using Marketplace.Users.Infrastructure.Implementation.Requests.Configs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Marketplace.Users.Infrastructure.DependecyInjection;

public static class UserInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureUserInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetRequiredSection("Api:UserRoutes");
        services.Configure<UserRoutesConfig>(opts => section.Bind(opts));
        return services;
    }
}
