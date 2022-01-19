using MultiTenantApp.Contracts;

namespace MultiTenantApp.Application.Contracts;

public class Tenant : BaseEntity
{
    public string Name { get; set; }
}