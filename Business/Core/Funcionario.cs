using projeto_form_camila.Models;

namespace projeto_form_camila.Business.Models;

public partial class Funcionario
{
    public int IdFuncionario { get; set; }

    public string Nome { get; set; } = null!;

    public int LoginId { get; set; }

    public virtual Login Login { get; set; } = null!;

    public virtual ICollection<Turma> Turmas { get; set; } = new List<Turma>();
}
