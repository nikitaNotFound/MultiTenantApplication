namespace MultiTenantApp.Infrastructure.Persistence.Models;

public interface IAuditableEntity
{
    public DateTime CreateTime { get; set; }

    public DateTime ModifyTime { get; set; }
}