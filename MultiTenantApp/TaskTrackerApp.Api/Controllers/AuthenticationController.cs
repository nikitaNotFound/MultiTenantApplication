using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Infrastructure.Controllers;
using TaskTrackerApp.Application.Requests;
using TaskTrackerApp.Application.Results;

namespace TaskTrackerApp.Api.Controllers;

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