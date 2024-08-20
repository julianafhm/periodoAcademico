namespace periodoAcademico.Models;
    public class Prova 
    {
    public int Id { get; set; }
    public int Numero { get; set; } // 1, 2 ou 3
    public double Nota { get; set; }
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; } = new Aluno();
}
