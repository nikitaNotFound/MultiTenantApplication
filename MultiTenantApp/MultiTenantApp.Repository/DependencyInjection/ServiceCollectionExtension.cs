using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MultiTenantApp.Infrastructure.Contracts;
using MultiTenantApp.Infrastructure.Multitenancy;
using MultiTenantApp.Repository.Repositories;

namespace MultiTenantApp.Repository.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddRepositories(
        this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationRepository, AuthenticationRepository>(sp => new AuthenticationRepository()
            .WithConnectionString(sp.GetRequiredService<CurrentTenant>().ConnectionString));

        services.AddScoped<IApplicationAuthenticationRepository, ApplicationAuthenticationRepository>(sp => new ApplicationAuthenticationRepository()
            .WithConnectionString(sp.GetRequiredService<CurrentTenant>().ConnectionString));

        services.AddScoped<ITenantRepository, TenantRepository>(sp => new TenantRepository()
            .WithConnectionString(sp.GetRequiredService<CurrentTenant>().ConnectionString));

        return services;
    }
}