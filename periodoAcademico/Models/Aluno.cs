namespace periodoAcademico.Models;
    public class Aluno 
    {
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public List<Prova> Provas { get; set; } = new List<Prova>();
    public double MediaFinal { get; set; }
    public double? NotaProvaFinal { get; set; }
    public bool Aprovado { get; set; }
}
