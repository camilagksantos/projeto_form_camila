namespace projeto_form_camila.Models;

public partial class Nota
{
    public int IdNota { get; set; }

    public int AlunoId { get; set; }

    public int DisciplinaId { get; set; }

    public DateTime DataAtribuicao { get; set; }

    public decimal ValorNota { get; set; }

    public virtual Aluno Aluno { get; set; } = null!;

    public virtual Disciplina Disciplina { get; set; } = null!;
}
