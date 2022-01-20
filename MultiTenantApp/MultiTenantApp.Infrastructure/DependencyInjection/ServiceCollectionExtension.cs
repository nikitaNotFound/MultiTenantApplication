using Microsoft.Extensions.DependencyInjection;
using MultiTenantApp.Infrastructure.Multitenancy;

namespace MultiTenantApp.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<CurrentTenant>();
        services.AddScoped<TenantConnectionStringService>();

        return services;
    }
}