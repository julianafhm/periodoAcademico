using MediatR;
using Microsoft.AspNetCore.Mvc;



namespace periodoAcademico.Controllers {

    [Route("api/activitySettings")]
    [ApiController]
    public class AlunoController : ControllerBase {

        private readonly IMediator mediator;

        public AlunoController(IMediator mediator) {

            this.mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateActivitySettingsCommand command) {
            return Created(string.Empty, await this.mediator.Send(command));
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] UpdateActivitySettingsCommand command) {
            return Ok(await this.mediator.Send(command));    
        }
    }
}
