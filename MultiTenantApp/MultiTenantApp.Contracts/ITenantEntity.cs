namespace MultiTenantApp.Contracts;

public interface ITenantEntity
{
    public Guid TenantId { get; set; }
}