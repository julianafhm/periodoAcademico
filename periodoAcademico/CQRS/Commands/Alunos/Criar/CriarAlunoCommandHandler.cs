using MediatR;
using Microsoft.EntityFrameworkCore;
using PeriodoAcademico.Data;
using PeriodoAcademico.Models;

namespace periodoAcademico.CQRS.Commands.Alunos.Criar
{
    public class CriarAlunoCommandHandler : IRequestHandler<CriarAlunoCommand, bool>
    {
        private readonly PeriodoContext periodoContext;

        public CriarAlunoCommandHandler(PeriodoContext periodoContext)
        {
            this.periodoContext = periodoContext;
        }

        public async Task<bool>Handle(CriarAlunoCommand request, CancellationToken cancellationToken)
        {

            //var turma = await periodoContext.Turmas.FirstOrDefaultAsync(x => x.Id == request.IdTurma);

            var aluno = new Aluno() {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                IdTurma = request.IdTurma
            };

            periodoContext.Alunos.Add(aluno);
            periodoContext.SaveChanges();

            return true;
            
        }
    } 
}
