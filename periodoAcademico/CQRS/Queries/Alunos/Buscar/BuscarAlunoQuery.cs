using MediatR;
using PeriodoAcademico.Models;

namespace periodoAcademico.CQRS.Queries.Alunos.Buscar
{
    public class BuscarAlunoQuery : IRequest<List<Aluno>>
    {
        public required string Nome { get; set; }
    }
}
