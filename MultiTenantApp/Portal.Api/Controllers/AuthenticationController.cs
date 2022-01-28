using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Infrastructure.Controllers;
using Portal.Application.Requests;
using Portal.Application.Results;

namespace Portal.Api.Controllers;

[ApiController]
[Route("api/authentication")]
public class AuthenticationController : BaseApiController
{
    [HttpPost]
    public Task<AuthenticationResult> AuthenticateAsync([FromBody] AuthenticationRequest request)
    {
        return Mediator.Send(request);
    }
}