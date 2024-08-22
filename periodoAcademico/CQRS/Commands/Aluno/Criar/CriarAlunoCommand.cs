namespace periodoAcademico.CQRS.Commands.Aluno.Criar
{
    public class CriarAlunoCommand
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
    }
}
