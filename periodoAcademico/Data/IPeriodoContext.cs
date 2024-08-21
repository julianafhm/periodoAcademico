using Microsoft.EntityFrameworkCore;
using PeriodoAcademico.Models;

namespace periodoAcademico.Data {
    public interface IPeriodoContext {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Prova> Provas { get; set; }
    }
}
