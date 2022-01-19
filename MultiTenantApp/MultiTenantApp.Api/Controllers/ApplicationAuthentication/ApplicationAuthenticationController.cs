using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Application.Requests;
using MultiTenantApp.Application.Results;

namespace MultiTenantApp.Api.Controllers.ApplicationAuthentication;

[ApiController]
[Route("api/application-authentication")]
public class ApplicationAuthenticationController : BaseApiController
{
    [HttpPost]
    public Task<ApplicationAuthenticationResult> AuthenticateAsync([FromBody] ApplicationAuthenticationRequest request)
    {
        return Mediator.Send(request);
    }
}