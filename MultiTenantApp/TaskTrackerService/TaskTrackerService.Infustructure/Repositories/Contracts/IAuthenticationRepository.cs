namespace TaskTrackerService.Infustructure.Repositories.Contracts;

public interface IAuthenticationRepository
{
    Task<bool> VerifyCredentialsAsync(string login, byte[] passwordHash);
}