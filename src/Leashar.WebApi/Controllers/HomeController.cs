using Leashar.Application.v1.Ping;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leashar.WebApi.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("~/ping")]
        public async Task<IActionResult> Ping() => Ok(await _mediator.Send(new PingServerCommand()));
    }
}
