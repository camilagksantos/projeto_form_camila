using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Business.Models;
using projeto_form_camila.Models;

namespace projeto_form_camila.Persistence
{
    internal class TurmaDAO
    {
        //propriedade
        public BdProjetoFormCamilaContext _Context { get; set; }

        //Contrutor que inicializa os obj do tipo "BdProjetoFormCamilaContext" para acessar a base de dados
        public TurmaDAO()
        {
            _Context = new BdProjetoFormCamilaContext();
        }

        //método que pede para o _Context para buscar uma lista de Turma
        internal List<Turma> buscarTurmas()
        {
            return _Context.Turmas.AsNoTracking().ToList();
        }

        //método que envia ao _context uma Turma para salvar
        internal void salvarTurmaBd(Turma turma)
        {
            _Context.Turmas.Add(turma);
            _Context.SaveChanges();
        }

        //método que envia uma solicitação de atualização de um Turma
        internal void atualizarTurmaBd(Turma turma)
        {
            _Context.Turmas.Update(turma);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Turma
        internal void removerTurmaBd(Turma turma)
        {
            _Context.Turmas.Remove(turma);
            _Context.SaveChanges();
        }
    }
}
