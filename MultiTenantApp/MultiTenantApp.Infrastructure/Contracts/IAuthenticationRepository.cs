namespace MultiTenantApp.Infrastructure.Contracts;

public interface IAuthenticationRepository
{
    Task<bool> VerifyCredentialsAsync(string login, byte[] passwordHash);
}