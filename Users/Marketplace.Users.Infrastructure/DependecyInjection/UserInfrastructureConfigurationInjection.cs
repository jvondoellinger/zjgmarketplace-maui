using Marketplace.Users.Infrastructure.Implementation.Requests.Configs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Marketplace.Users.Infrastructure.DependecyInjection;

public static class UserInfrastructureConfigurationInjection
{
    public static IServiceCollection ConfigureUserInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        Debug.WriteLine("Configuring user layer...");
        var section = configuration.GetRequiredSection("Api:UserRoutes");
        services.Configure<UserRoutesConfig>(section.Bind);

        return services;
    }
}
