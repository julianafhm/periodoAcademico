﻿namespace PeriodoAcademico.Models;
    public class Prova 
    {
    public Guid Id { get; set; }
    public int Avaliacao { get; set; } //av1,av2,av3 ou av4(P. ESP)
    public double Nota { get; set; }
    public int AlunoId { get; set; }

public Prova(Guid id, int tipoAvaliacao, double nota, int alunoId) {
        Id = id;
        Avaliacao = tipoAvaliacao;
        Nota = nota;
        AlunoId = alunoId;
    }
}
