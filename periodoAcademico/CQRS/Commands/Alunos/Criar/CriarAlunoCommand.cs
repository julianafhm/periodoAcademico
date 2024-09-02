using MediatR;
using PeriodoAcademico.Models;

namespace periodoAcademico.CQRS.Commands.Alunos.Criar
{
    public class CriarAlunoCommand : IRequest<bool>
    {
        public required string Nome { get; set; }

        public Guid IdTurma { get; set; }
    }
}
