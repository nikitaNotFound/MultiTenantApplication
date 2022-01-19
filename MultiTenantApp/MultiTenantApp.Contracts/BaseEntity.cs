namespace MultiTenantApp.Contracts;

public abstract class BaseEntity : IAuditableEntity, ITenantEntity, ISoftDeleteEntity
{
    public Guid Id { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime ModifiedTime { get; set; }

    public Guid TenantId { get; set; }

    public bool Deleted { get; set; }

    public DateTime DeleteTime { get; set; }
}