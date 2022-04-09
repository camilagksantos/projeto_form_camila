using projeto_form_camila.Business.Models;
using projeto_form_camila.Models;
using projeto_form_camila.Persistence;

namespace projeto_form_camila.Business.Modal
{
    internal class FuncionarioService
    {
        //propriedade 
        public FuncionarioDAO FuncionarioDAO { get; set; }

        //construtor que instancia um obj do tipo FuncionarioDao que é a classe que solicita ao _contexto o acesso a base de dados
        public FuncionarioService()
        {
            FuncionarioDAO = new FuncionarioDAO();
        }

        //método que faz a requisição da lista completa de Funcionarios
        internal List<Funcionario> buscarFuncionarios()
        {
            return FuncionarioDAO.buscarFuncionarios();
        }

        //metodo que cria um obj do tipo Funcionario, atribui valores recebidos por parametros e solicita ao FuncionarioDAO para salvar
        internal void salvarFuncionario(string nome, int loginId)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nome;
            funcionario.LoginId = loginId;

            FuncionarioDAO.salvarFuncionarioBd(funcionario);
        }

        //metodo que cria um obj do tipo Funcionario, atribui valores recebidos por parametros e solicita ao FuncionarioDAO para atualizar
        internal void atualizarCliente(int idFuncionario, string nome, int loginId)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.IdFuncionario = idFuncionario;
            funcionario.Nome = nome;
            funcionario.LoginId = loginId;

            FuncionarioDAO.atualizarFuncionarioBd(funcionario);
        }

        //método que cria um obj do tipo Funcionario para referenciar ao FuncionarioDAO um obj para remover
        internal void removerCliente(int idFuncionario, string nome, int loginId)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.IdFuncionario = idFuncionario;
            funcionario.Nome = nome;
            funcionario.LoginId = loginId;

            FuncionarioDAO.removerFuncionarioBd(funcionario);
        }
    }
}
