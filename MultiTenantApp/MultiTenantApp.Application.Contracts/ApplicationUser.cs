using MultiTenantApp.Contracts;

namespace MultiTenantApp.Application.Contracts;

public class ApplicationUser : BaseEntity
{
    public string Login { get; set; }

    public string Email { get; set; }

    public byte[] PasswordHash { get; set; }
}