using Microsoft.EntityFrameworkCore;
using periodoAcademico.Data;
using PeriodoAcademico.Models;

namespace PeriodoAcademico.Data {
    public sealed class PeriodoContext : DbContext, IPeriodoContext {
        private readonly DbContextOptions<PeriodoContext> options;
        private readonly IConfiguration configuration;

        public PeriodoContext(DbContextOptions<PeriodoContext> options, IConfiguration configuration) : base(options) {
            this.options = options;
            this.configuration = configuration;
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Prova> Provas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Aluno).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = this.configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }



    }


}
