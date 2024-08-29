using PeriodoAcademico.Models;

namespace periodoAcademico.CQRS.Commands.Prova.Criar
{
    public class CriarProvaCommand
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
    }
}
