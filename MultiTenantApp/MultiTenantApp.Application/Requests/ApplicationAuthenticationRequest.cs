using MediatR;
using MultiTenantApp.Application.Results;

namespace MultiTenantApp.Application.Requests;

public class ApplicationAuthenticationRequest : IRequest<ApplicationAuthenticationResult>
{
    public string Login { get; set; }

    public string Password { get; set; }
}

public class AuthenticationRequestHandler : IRequestHandler<ApplicationAuthenticationRequest, ApplicationAuthenticationResult>
{
    public Task<ApplicationAuthenticationResult> Handle(
        ApplicationAuthenticationRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}