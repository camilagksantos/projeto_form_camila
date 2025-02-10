using projeto_form_camila.Models;
using projeto_form_camila.Persistence;

namespace projeto_form_camila.Business.Modal
{
    internal class DisciplinaService
    {
        //propriedade 
        public DisciplinaDAO disciplinaDAO { get; set; }

        //construtor que instancia um obj do tipo DisciplinaDao que é a classe que solicita ao _contexto o acesso a base de dados
        public DisciplinaService()
        {
            disciplinaDAO = new DisciplinaDAO();
        }

        //método que faz a requisição da lista completa de Disciplinas
        internal List<Disciplina> buscarDisciplinas()
        {
            return disciplinaDAO.buscarDisciplinas();
        }

        //metodo que cria um obj do tipo Disciplina, atribui valores recebidos por parametros e solicita ao DisciplinaDAO para salvar
        internal void salvarDisciplina(string designacao)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.Designacao = designacao;

            disciplinaDAO.salvarDisciplinaBd(disciplina);
        }

        //metodo que cria um obj do tipo Disciplina, atribui valores recebidos por parametros e solicita ao DisciplinaDAO para atualizar
        internal void atualizarDisciplina(int idDisciplina, string designacao)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.IdDisciplina = idDisciplina;
            disciplina.Designacao = designacao;

            disciplinaDAO.atualizarDisciplinaBd(disciplina);
        }

        //método que cria um obj do tipo Disciplina para referenciar ao DisciplinaDAO um obj para remover
        internal void removerDisciplina(int idDisciplina, string designacao)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.IdDisciplina = idDisciplina;
            disciplina.Designacao = designacao;

            disciplinaDAO.removerDisciplinaBd(disciplina);
        }

        //método que busca uma disciplina pelo id
        internal string buscarDisciplinaPorId(int disciplinaId)
        {
            return disciplinaDAO.buscarDisciplinasPorId(disciplinaId);
        }
    }
}
