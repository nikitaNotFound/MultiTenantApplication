using MultiTenantApp.Infrastructure.Models;
using MultiTenantApp.Infrastructure.Persistence.Models;

namespace PortalService.Domain.Models;

public class Account : BaseEntity
{
    public string Login { get; set; }

    public string Email { get; set; }

    public byte[] PasswordHash { get; set; }
}