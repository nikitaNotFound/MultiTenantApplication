namespace MultiTenantApp.Infrastructure.Persistence.Models;

public interface ITenantEntity
{
    public Guid TenantId { get; set; }
}