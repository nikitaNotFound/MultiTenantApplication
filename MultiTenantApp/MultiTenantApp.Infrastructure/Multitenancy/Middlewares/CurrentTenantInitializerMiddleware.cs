using Microsoft.AspNetCore.Http;
using MultiTenantApp.Infrastructure.Multitenancy.Services;

namespace MultiTenantApp.Infrastructure.Multitenancy.Middlewares;

public class CurrentTenantInitializerMiddleware : IMiddleware
{
    private readonly TenantConnectionStringService _connectionStringService;
    private readonly CurrentTenantAccessor _currentTenantAccessor;

    public CurrentTenantInitializerMiddleware(
        TenantConnectionStringService connectionStringService,
        CurrentTenantAccessor currentTenantAccessor)
    {
        _connectionStringService = connectionStringService;
        _currentTenantAccessor = currentTenantAccessor;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var tenantId = Guid.NewGuid(); // then get it from claims
        string tenantConnectionString = await _connectionStringService
            .GetTenantConnectionStringByIdAsync(tenantId);

        _currentTenantAccessor.SetConnectionString(tenantConnectionString);

        await next(context);
    }
}