namespace MultiTenantApp.Contracts;

public interface IAuditableEntity
{
    public DateTime CreatedTime { get; set; }

    public DateTime ModifiedTime { get; set; }
}