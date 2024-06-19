using HealthApp.Service.Commands.User;
using HealthApp.Service.Queries.User;
using HealthApp.Storage.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDto userDto)
        {
            if (userDto == null)
                return BadRequest();

            var command = new CreateUserCommand(userDto);
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result }, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var query = new GetUserByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
