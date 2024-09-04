using MediatR;
using Microsoft.AspNetCore.Mvc;
using periodoAcademico.CQRS.Commands.Alunos.Criar;
using periodoAcademico.CQRS.Queries.Alunos.Listar;



namespace periodoAcademico.Controllers
{

    [Route("api/aluno")]
    [Produces("application/json")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly IMediator mediator;

        public AlunoController(IMediator mediator)
        {

            this.mediator = mediator;
        }
        [HttpGet("list")]
        public async Task<IActionResult> Create([FromQuery] ListarAlunoQuery command)
        {
            return Created(string.Empty, await this.mediator.Send(command));
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CriarAlunoCommand command)
        {
            return Created(string.Empty, await this.mediator.Send(command));
        }



    }


}
