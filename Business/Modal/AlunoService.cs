using projeto_form_camila.Models;
using projeto_form_camila.Persistence;

namespace projeto_form_camila.Business.Modal
{
    internal class AlunoService
    {
        //propriedade 
        public AlunoDAO alunoDAO { get; set; }

        //construtor que instancia um obj do tipo AlunoDao que é a classe que solicita ao _contexto o acesso a base de dados
        public AlunoService()
        {
            alunoDAO = new AlunoDAO();
        }

        //método que faz a requisição da lista completa de Alunos
        internal List<Aluno> buscarAlunos()
        {
            return alunoDAO.buscarAlunos();
        }

        //metodo que cria um obj do tipo Aluno, atribui valores recebidos por parametros e solicita ao AlunoDAO para salvar
        internal void salvarAluno(string nome, string apelido, int idade, string email, int turmaId, int loginId)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Apelido = apelido;
            aluno.Idade = idade;
            aluno.Email = email;
            aluno.TurmaId = turmaId;
            aluno.LoginId = loginId;

            alunoDAO.salvarAlunoBd(aluno);
        }

        //metodo que cria um obj do tipo Aluno, atribui valores recebidos por parametros e solicita ao AlunoDAO para atualizar
        internal void atualizarAluno(int idAluno, string nome, string apelido, int idade, string email, int turmaId, int loginId)
        {
            Aluno aluno = new Aluno();
            aluno.IdAluno = idAluno;
            aluno.Nome = nome;
            aluno.Apelido = apelido;
            aluno.Idade = idade;
            aluno.Email = email;
            aluno.TurmaId = turmaId;
            aluno.LoginId = loginId;

            alunoDAO.atualizarAlunoBd(aluno);
        }

        //método que cria um obj do tipo Aluno para referenciar ao AlunoDAO um obj para remover
        internal void removerAluno(int idAluno, string nome, string apelido, int idade, string email, int turmaId, int loginId)
        {
            Aluno aluno = new Aluno();
            aluno.IdAluno = idAluno;
            aluno.Nome = nome;
            aluno.Apelido = apelido;
            aluno.Idade = idade;
            aluno.Email = email;
            aluno.TurmaId = turmaId;
            aluno.LoginId = loginId;

            alunoDAO.removerAlunoBd(aluno);
        }

        //método que busca um aluno especifico
        internal Aluno buscarAlunoPorLoginId(Login login)
        {
            return alunoDAO.buscarAlunoPorLoginId(login);
        }

        internal List<Aluno> buscarAlunosFiltrados(int idTurma)
        {
            return alunoDAO.buscarAlunosFiltrados(idTurma);
        }

        internal List<Aluno> FiltrarAlunosPorTurmasSelecionadas(List<int> turmasSelecionadas)
        {
            return alunoDAO.FiltrarAlunosPorTurmasSelecionadas(turmasSelecionadas);
        }

        internal Aluno buscarAlunoPorId(int alunoId)
        {
            return alunoDAO.buscarAlunoPorId(alunoId);
        }
    }
}
