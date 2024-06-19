using HealthApp.Service.Commands.HeatlhReport;
using HealthApp.Service.Queries.HealthReport;
using HealthApp.Storage.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthReportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HealthReportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] HealthReportDto healthReportDto)
        {
            if (healthReportDto == null)
                return BadRequest();

            var command = new CreateHealthReportCommand(healthReportDto);
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result }, result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var query = new GetHealthReportByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllHealthReportQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
