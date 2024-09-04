using MediatR;

namespace periodoAcademico.CQRS.Commands.Alunos.Update {
    public class UpdateAlunoCommand : IRequest<bool> {
        public required string Nome { get; set; }

        public Guid IdTurma { get; set; }
    }
}

