using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Infrastructure.Controllers;
using PortalService.Application.Requests;
using PortalService.Application.Results;

namespace PortalService.Api.Controllers;

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