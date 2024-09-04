using MediatR;
using Microsoft.EntityFrameworkCore;
using PeriodoAcademico.Data;
using PeriodoAcademico.Models;

namespace periodoAcademico.CQRS.Queries.Alunos.Listar {
    public class ListarAlunoQueryHandler : IRequestHandler<ListarAlunoQuery, List<Aluno>> {
        private readonly PeriodoContext context;

        public ListarAlunoQueryHandler(PeriodoContext context) {
            this.context = context;
        }

        public async Task<List<Aluno>> Handle(ListarAlunoQuery request, CancellationToken cancellationToken) {
            var alunos = await context.Alunos.ToListAsync();

            return alunos;

        }
    }
}
