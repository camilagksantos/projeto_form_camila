using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Business.Models;
using projeto_form_camila.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var turmaFind = _Context.Turmas.Find(turma.IdTurma); // Encontra a entidade existente
            _Context.Entry(turmaFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Turmas.Update(turma);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Turma
        internal void removerTurmaBd(Turma turma)
        {
            var turmaFind = _Context.Turmas.Find(turma.IdTurma); // Encontra a entidade existente
            _Context.Entry(turmaFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Turmas.Remove(turma);
            _Context.SaveChanges();
        }

        internal List<Turma> buscarTurmasFiltrada(string turmaSelecionada)
        {
            return _Context.Turmas.AsNoTracking().Where(turma => turma.Designacao.Equals(turmaSelecionada)).ToList();
        }

        internal List<Turma> buscarTurmasFiltradas(int idTurma)
        {
            return _Context.Turmas.Where(turma => turma.IdTurma.Equals(idTurma)).ToList();
        }
    }
}
