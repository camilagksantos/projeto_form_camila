using projeto_form_camila.Business.Models;
using projeto_form_camila.Persistence;

namespace projeto_form_camila.Business.Modal
{
    internal class TurmaService
    {
        //propriedade 
        public TurmaDAO TurmaDAO { get; set; }

        //construtor que instancia um obj do tipo TurmaDao que é a classe que solicita ao _contexto o acesso a base de dados
        public TurmaService()
        {
            TurmaDAO = new TurmaDAO();
        }

        //método que faz a requisição da lista completa de Turmas
        internal List<Turma> buscarTurmas()
        {
            return TurmaDAO.buscarTurmas();
        }

        //metodo que cria um obj do tipo Turma, atribui valores recebidos por parametros e solicita ao TurmaDAO para salvar
        internal void salvarTurma(string designacao, int professorId)
        {
            Turma turma = new Turma();
            turma.Designacao = designacao;
            turma.ProfessorId = professorId;

            TurmaDAO.salvarTurmaBd(turma);
        }

        //metodo que cria um obj do tipo Turma, atribui valores recebidos por parametros e solicita ao TurmaDAO para atualizar
        internal void atualizarCliente(int idTurma, string designacao, int professorId)
        {
            Turma turma = new Turma();
            turma.Designacao = designacao;
            turma.ProfessorId = professorId;

            TurmaDAO.atualizarTurmaBd(turma);
        }

        //método que cria um obj do tipo Turma para referenciar ao TurmaDAO um obj para remover
        internal void removerCliente(int idTurma, string designacao, int professorId)
        {
            Turma turma = new Turma();
            turma.Designacao = designacao;
            turma.ProfessorId = professorId;

            TurmaDAO.removerTurmaBd(turma);
        }
    }
}
