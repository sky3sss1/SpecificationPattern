using Application.Features.Orders.Commands;
using Application.Interfaces;
using Infrastraction.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastraction;

public static class ServiceCollectionExtension
{
    private static readonly string _databaseConnectionString = "PostgreSqlDatabase";
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString(_databaseConnectionString));
        });

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddOrderCommand).Assembly));
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderItemRepository, OrderItemRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IStatusRepository, StatusRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
