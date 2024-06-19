using HealthApp.Service.Commands.MonitoringDevice;
using HealthApp.Service.Queries.MonitoringDevice;
using HealthApp.Storage.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonitoringDeviceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MonitoringDeviceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MonitoringDeviceDto monitoringDeviceDto)
        {
            if (monitoringDeviceDto == null)
                return BadRequest();

            var command = new CreateMonitoringDeviceCommand(monitoringDeviceDto);
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result }, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var command = new DeleteMonitoringDeviceCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var query = new GetMonitoringDeviceByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
