namespace PeriodoAcademico.Models;
public class Aluno {
    public Guid Id { get; set; }
    public required string Nome { get; set; }
    public List<Prova> Provas { get; set; } = new List<Prova>();
    public double? MediaFinal { get; set; }
    public double? NotaProvaFinal { get; set; }
    public double? NotaProvaEspecial { get; set; }
    public bool? Aprovado { get; set; }

    public Aluno(Guid id, string nomeAluno, List<Prova> provas, double? mediaFinal, double? notaProvaFinal, double? notaProvaEspecial, bool? aprovado) {
        Id = id;
        Nome = nomeAluno;
        Provas = provas;
        MediaFinal = mediaFinal;
        NotaProvaFinal = notaProvaFinal;
        NotaProvaEspecial = notaProvaEspecial;
        Aprovado = aprovado;
    }
}
