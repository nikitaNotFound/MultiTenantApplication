using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Infrastructure.Controllers;
using TaskTrackerService.Application.Requests;
using TaskTrackerService.Application.Results;

namespace TaskTrackerService.Api.Controllers;

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