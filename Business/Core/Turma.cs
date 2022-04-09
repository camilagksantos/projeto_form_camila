using projeto_form_camila.Models;

namespace projeto_form_camila.Business.Models;

public partial class Turma
{
    public int IdTurma { get; set; }

    public string Designacao { get; set; } = null!;

    public int ProfessorId { get; set; }

    public virtual ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

    public virtual Funcionario Professor { get; set; } = null!;
}
