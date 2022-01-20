using MultiTenantApp.Application.Contracts;

namespace MultiTenantApp.Infrastructure.Multitenancy;

public class CurrentTenant
{
    private string _connectionString;

    public Tenant Tenant => Tenant ?? throw new ArgumentNullException();

    public string Name => Tenant?.Name ?? throw new ArgumentNullException();

    public string ConnectionString => _connectionString ?? throw new ArgumentNullException();

    public void SetConnectionString(string connectionString) => _connectionString = connectionString;
}