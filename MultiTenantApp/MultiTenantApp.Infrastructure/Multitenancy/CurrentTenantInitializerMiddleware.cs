using Microsoft.AspNetCore.Http;

namespace MultiTenantApp.Infrastructure.Multitenancy;

public class CurrentTenantInitializerMiddleware : IMiddleware
{
    private readonly TenantConnectionStringService _connectionStringService;
    private readonly CurrentTenant _currentTenant;

    public CurrentTenantInitializerMiddleware(
        TenantConnectionStringService connectionStringService,
        CurrentTenant currentTenant)
    {
        _connectionStringService = connectionStringService;
        _currentTenant = currentTenant;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var tenantId = Guid.NewGuid(); // then get it from claims
        string tenantConnectionString = await _connectionStringService
            .GetTenantConnectionStringByIdAsync(tenantId);

        _currentTenant.SetConnectionString(tenantConnectionString);

        await next(context);
    }
}