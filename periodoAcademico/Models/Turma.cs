namespace periodoAcademico.Models;
    public class Turma 
    {
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
}
