using MediatR;
using PeriodoAcademico.Models;

namespace periodoAcademico.CQRS.Queries.Alunos.Listar
{
    public class ListarAlunoQuery : IRequest<List<Aluno>>
    {
        
    }

}
