namespace MultiTenantApp.Contracts;

public interface ISoftDeleteEntity
{
    public bool Deleted { get; set; }

    public DateTime DeleteTime { get; set; }
}