namespace MultiTenantApp.Infrastructure.Persistence.Models;

public abstract class BaseEntity : IAuditableEntity, ITenantEntity, ISoftDeleteEntity
{
    public Guid Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime ModifyTime { get; set; }

    public Guid TenantId { get; set; }

    public bool Deleted { get; set; }

    public DateTime DeleteTime { get; set; }
}