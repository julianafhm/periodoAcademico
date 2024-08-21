namespace PeriodoAcademico.Models;
    public class Turma 
    {
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
}
