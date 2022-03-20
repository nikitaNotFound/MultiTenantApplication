using MultiTenantApp.Infrastructure.Persistence;
using TaskTrackerService.Infustructure.Repositories.Contracts;

namespace TaskTrackerService.Infustructure.Repositories;

public class AuthenticationRepository : BaseRepository<AuthenticationRepository>, IAuthenticationRepository
{
    public Task<bool> VerifyCredentialsAsync(string login, byte[] passwordHash)
    {
        throw new NotImplementedException();
    }
}