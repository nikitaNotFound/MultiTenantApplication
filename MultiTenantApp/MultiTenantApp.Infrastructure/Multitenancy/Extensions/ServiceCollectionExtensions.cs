using Microsoft.Extensions.DependencyInjection;
using MultiTenantApp.Infrastructure.Multitenancy.Options;
using MultiTenantApp.Infrastructure.Multitenancy.Services;

namespace MultiTenantApp.Infrastructure.Multitenancy.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCurrentTenantAccessor(
        this IServiceCollection services,
        Action<ManagerDatabaseOptions> configure)
    {
        var options = new ManagerDatabaseOptions();
        configure(options);

        if (string.IsNullOrEmpty(options.ConnectionString))
        {
            throw new ArgumentNullException();
        }

        services.AddScoped<CurrentTenantAccessor>();
        services.AddScoped<TenantConnectionStringService>();

        return services;
    }
}