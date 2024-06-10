using Leashar.Application.v1.Users.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leashar.WebApi.Controllers;
[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;
    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserCommand command)
    {
        var rs = await _mediator.Send(command);
        return Ok(rs);
    }
    
}