namespace projeto_form_camila.Models;

public partial class Disciplina
{
    public int IdDisciplina { get; set; }

    public string Designacao { get; set; } = null!;

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();
}
