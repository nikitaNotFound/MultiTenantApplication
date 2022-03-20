using MediatR;
using TaskTrackerService.Application.Results;

namespace TaskTrackerService.Application.Requests;

public class AuthenticationRequest : IRequest<AuthenticationResult>
{
    public string Login { get; set; }

    public string Password { get; set; }
}

public class AuthenticationRequestHandler : IRequestHandler<AuthenticationRequest, AuthenticationResult>
{
    public async Task<AuthenticationResult> Handle(
        AuthenticationRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}