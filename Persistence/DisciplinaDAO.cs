using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Business.Models;
using projeto_form_camila.Models;

namespace projeto_form_camila.Persistence
{
    internal class DisciplinaDAO
    {
        //propriedade
        public BdProjetoFormCamilaContext _Context { get; set; }

        //Contrutor que inicializa os obj do tipo "BdProjetoFormCamilaContext" para acessar a base de dados
        public DisciplinaDAO()
        {
            _Context = new BdProjetoFormCamilaContext();
        }

        //método que pede para o _Context para buscar uma lista de Disciplinas
        internal List<Disciplina> buscarDisciplinas()
        {
            return _Context.Disciplinas.AsNoTracking().ToList();
        }

        //método que envia ao _context uma Disciplina para salvar
        internal void salvarDisciplinaBd(Disciplina disciplina)
        {
            _Context.Disciplinas.Add(disciplina);
            _Context.SaveChanges();
        }

        //método que envia uma solicitação de atualização de um Disciplina
        internal void atualizarDisciplinaBd(Disciplina disciplina)
        {
            var disciplinaFind = _Context.Disciplinas.Find(disciplina.IdDisciplina); // Encontra a entidade existente
            _Context.Entry(disciplinaFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Disciplinas.Update(disciplina);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Disciplina
        internal void removerDisciplinaBd(Disciplina disciplina)
        {
            _Context.Disciplinas.Remove(disciplina);
            _Context.SaveChanges();
        }
    }
}
