namespace MultiTenantApp.Infrastructure.Persistence.Models;

public interface ISoftDeleteEntity
{
    public bool Deleted { get; set; }

    public DateTime DeleteTime { get; set; }
}