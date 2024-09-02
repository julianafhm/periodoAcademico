namespace PeriodoAcademico.Models;
public class Turma {
    public Guid Id { get; set; }
    public int Numero { get; set; } //t1/t2/t3
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();

}

