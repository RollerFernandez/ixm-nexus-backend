using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Ixm.Nexus.Users.Application.Cores;
public static class AddApplicationServices
{
    public static IServiceCollection AddAplicationServices(this IServiceCollection services, IConfiguration configuration) {

        IServiceCollection serviceCollection = services.AddAutoMapper(Assembly.GetExecutingAssembly());

        _ = services.Configure<AppSettings>(opt => configuration.GetSection(AppSettings.Name).Bind(opt));

        return services;
    }
}
