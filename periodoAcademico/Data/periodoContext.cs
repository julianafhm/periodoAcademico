using Microsoft.EntityFrameworkCore;
using periodoAcademico.Models;

namespace periodoAcademico.Data {
    public class periodoContext : DbContext {
        public periodoContext(DbContextOptions<periodoContext> options) : base(options) {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Prova> Provas { get; set; }
    }
}
