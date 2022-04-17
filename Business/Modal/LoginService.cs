using projeto_form_camila.Models;
using projeto_form_camila.Persistence;

namespace projeto_form_camila.Business.Modal
{
    internal class LoginService
    {
        //propriedade 
        public LoginDAO loginDAO { get; set; }

        //construtor que instancia um obj do tipo LoginDao que é a classe que solicita ao _contexto o acesso a base de dados
        public LoginService()
        {
            loginDAO = new LoginDAO();
        }

        //método que faz a requisição da lista completa de Logins
        internal List<Login> buscarLogins()
        {
            return loginDAO.buscarLogins();
        }

        //metodo que cria um obj do tipo Login, atribui valores recebidos por parametros e solicita ao LoginDAO para salvar
        internal void salvarLogin(string username, string password, string role)
        {
            Login login = new Login();
            login.Username = username;
            login.Password = password;
            login.Role = role;

            loginDAO.salvarLoginBd(login);
        }

        //metodo que cria um obj do tipo Login, atribui valores recebidos por parametros e solicita ao LoginDAO para atualizar
        internal void atualizarLogin(int idLogin, string username, string password, string role)
        {
            Login login = new Login();
            login.IdLogin = idLogin;
            login.Username = username;
            login.Password = password;
            login.Role = role;

            loginDAO.atualizarLoginBd(login);
        }

        //método que cria um obj do tipo Login para referenciar ao LoginDAO um obj para remover
        internal void removerLogin(int idLogin, string username, string password, string role)
        {
            Login login = new Login();
            login.IdLogin = idLogin;
            login.Username = username;
            login.Password = password;
            login.Role = role;

            loginDAO.removerLoginBd(login);
        }

        internal Login validarCredenciais(Login login)
        {
            return loginDAO.validarCredenciais(login);
        }

        internal List<string> buscarTodasRoles()
        {
            return loginDAO.buscarTodasRoles();
        }
        internal List<string> buscarRolesSemAluno()
        {
            return loginDAO.buscarRolesSemAluno();
        }

        internal List<Login> buscarLoginsFiltrados(string cargoSelecionado)
        {
            return loginDAO.buscarLoginsFiltrados(cargoSelecionado);
        }

        internal Login buscarUmLogin(string valorSelecionado)
        {
            return loginDAO.buscarUmLogin(valorSelecionado);
        }

        internal int buscarIdLogin(Login login)
        {
            return loginDAO.buscarIdLogin(login);
        }
    }
}
