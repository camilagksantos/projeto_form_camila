using projeto_form_camila.Business.Models;

namespace projeto_form_camila.Models;

public partial class Aluno
{
    public int IdAluno { get; set; }

    public string Nome { get; set; } = null!;

    public string Apelido { get; set; } = null!;

    public int Idade { get; set; }

    public string Email { get; set; } = null!;

    public int TurmaId { get; set; }

    public int? LoginId { get; set; }

    public virtual Login? Login { get; set; }

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();

    public virtual Turma Turma { get; set; } = null!;
}
