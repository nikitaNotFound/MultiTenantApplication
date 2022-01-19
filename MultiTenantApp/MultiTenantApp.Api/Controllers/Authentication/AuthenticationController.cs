using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Domain.Requests;
using MultiTenantApp.Domain.Results;

namespace MultiTenantApp.Api.Controllers.Authentication;

[ApiController]
[Route("api/authentication")]
public class AuthenticationController : BaseApiController
{
    public Task<AuthenticationResult> AuthenticateAsync([FromBody] AuthenticationRequest request)
    {
        return Mediator.Send(request);
    }
}