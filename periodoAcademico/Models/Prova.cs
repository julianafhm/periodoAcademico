namespace periodoAcademico.Models;
    public class Prova 
    {
    public int Id { get; set; }
    public int Avaliacao { get; set; } //av1,av2,av3 ou av4(P. ESP)
    public double Nota { get; set; }
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; } = new Aluno();
}
