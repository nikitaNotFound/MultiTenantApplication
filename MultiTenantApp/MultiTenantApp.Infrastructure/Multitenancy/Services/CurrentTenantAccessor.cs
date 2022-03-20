namespace MultiTenantApp.Infrastructure.Multitenancy.Services;

public class CurrentTenantAccessor
{
    private string _connectionString;

    public string ConnectionString => _connectionString ?? throw new ArgumentNullException();

    public CurrentTenantAccessor SetConnectionString(string connectionString)
    {
        _connectionString = connectionString;

        return this;
    }
}