using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastraction;

public static class ServiceCollectionExtension
{
    private static readonly string _databaseConnectionString = "PostgreSqlDatabase";
    public static IServiceCollection AddInfrastructure(this ServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString(_databaseConnectionString));
        });

        return services;
    }
}
