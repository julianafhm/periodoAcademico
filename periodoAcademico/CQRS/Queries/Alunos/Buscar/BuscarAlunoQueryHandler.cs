using MediatR;
using Microsoft.EntityFrameworkCore;
using PeriodoAcademico.Data;
using PeriodoAcademico.Models;

namespace periodoAcademico.CQRS.Queries.Alunos.Buscar
{
    public class BuscarAlunoQueryHandler : IRequestHandler<BuscarAlunoQuery, List<Aluno>>
    {
        private readonly PeriodoContext periodoContext;

        public BuscarAlunoQueryHandler(PeriodoContext periodoContext)
        {
            this.periodoContext = periodoContext;
        }

        public async Task<List<Aluno>> Handle(BuscarAlunoQuery request, CancellationToken cancellationToken)
        {

            //  var alunos = await periodoContext.Alunos.Where(x => x.Nome.StartsWith(request.Nome)).ToListAsync();
            List<Aluno> alunos = new List<Aluno>();
            return alunos;

        }
    }
}
