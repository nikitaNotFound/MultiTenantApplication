using Microsoft.AspNetCore.Builder;
using MultiTenantApp.Infrastructure.Multitenancy.Middlewares;

namespace MultiTenantApp.Infrastructure.Multitenancy.Extensions;

public static class AppBuilderExtensions
{
    public static IApplicationBuilder UseCurrentTenantAccessor(
        this IApplicationBuilder app)
    {
        app.UseMiddleware<CurrentTenantInitializerMiddleware>();

        return app;
    }
}