namespace PeriodoAcademico.Models;
public class Aluno {
    public Guid Id { get; set; }
   
    public required string Nome { get; set; }
    
    public List<Prova>? Provas { get; set; } = new List<Prova>();
    
    public double? MediaFinal { get; set; }
    
    public double? NotaProvaFinal { get; set; }
    
    public double? NotaProvaEspecial { get; set; }
    
    public bool? Aprovado { get; set; }

    public Guid IdTurma { get; set; }

}
