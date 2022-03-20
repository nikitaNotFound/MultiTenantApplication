using MultiTenantApp.Infrastructure.Models;
using MultiTenantApp.Infrastructure.Persistence.Models;

namespace PortalService.Domain.Models;

public class Tenant : BaseEntity
{
    public string Name { get; set; }
}