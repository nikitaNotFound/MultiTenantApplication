using MultiTenantApp.Infrastructure.Contracts;
using MultiTenantApp.Infrastructure.Multitenancy;

namespace MultiTenantApp.Repository.Repositories;

public class AuthenticationRepository : BaseRepository<AuthenticationRepository>, IAuthenticationRepository
{
    public Task<bool> VerifyCredentialsAsync(string login, byte[] passwordHash)
    {
        throw new NotImplementedException();
    }
}