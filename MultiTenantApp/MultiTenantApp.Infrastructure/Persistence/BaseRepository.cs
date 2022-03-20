using System.Data.SqlClient;

namespace MultiTenantApp.Infrastructure.Persistence;

public abstract class BaseRepository<T> where T : class
{
    private string _connectionString = null!;

    public void SetConnectionString(string connectionString) => _connectionString = connectionString;

    protected BaseRepository()
    {
    }

    protected BaseRepository(string connectionString) => _connectionString = connectionString;

    protected SqlConnection Connection => new(_connectionString);

    public T WithConnectionString(string connectionString)
    {
        _connectionString = connectionString;

        return this as T;
    }
}