using HealthApp.Service.Commands.HealthData;
using HealthApp.Service.Queries.HealthData;
using HealthApp.Storage.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthDataController : ControllerBase
    {
       private readonly IMediator _mediator;

        public HealthDataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] HealthDataDto healthDataDto)
        {
            if (healthDataDto == null)
                return BadRequest();

            var command = new CreateHealthDataCommand(healthDataDto);
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] HealthDataDto healthDataDto)
        {
            if (healthDataDto == null && id == Guid.Empty)
                return BadRequest();

            healthDataDto.Id = id;
            var command = new UpdateHealthDataCommand(healthDataDto);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var command = new DeleteHealthDataCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var query = new GetHealthDataByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllHealthDataQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
