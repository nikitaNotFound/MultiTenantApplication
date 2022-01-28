using MultiTenantApp.Contracts;

namespace Portal.Domain;

public class Tenant : BaseEntity
{
    public string Name { get; set; }
}