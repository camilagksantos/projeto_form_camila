using projeto_form_camila.Models;

namespace projeto_form_camila.Persistence
{
    internal class LoginDAO
    {
        //propriedade
        public BdProjetoFormCamilaContext _Context { get; set; }

        //Contrutor que inicializa os obj do tipo "BdProjetoFormCamilaContext" para acessar a base de dados
        public LoginDAO()
        {
            _Context = new BdProjetoFormCamilaContext();
        }

        //método que pede para o _Context para buscar uma lista de Login
        internal List<Login> buscarLogins()
        {
            return _Context.Logins.ToList();
        }

        //método que envia ao _context uma Login para salvar
        internal void salvarLoginBd(Login login)
        {
            _Context.Logins.Add(login);
            _Context.SaveChanges();
        }

        //método que envia uma solicitação de atualização de um Login
        internal void atualizarLoginBd(Login login)
        {
            _Context.Logins.Update(login);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Login
        internal void removerLoginBd(Login user)
        {
            _Context.Logins.Remove(user);
            _Context.SaveChanges();
        }

        //metodo que valida username e password
        internal Login validarCredenciais(Login login)
        {
            var user = _Context.Logins
                .FirstOrDefault(x => x.Username.Equals(login.Username) && x.Password.Equals(login.Password));

            if (user != null)
            {
                // Atribui o valor de Role do usuário encontrado ao objeto login.Role
                login.Role = user.Role;
                return login;
            }
            else
            {
                // Caso não encontre um usuário correspondente, retorna o objeto login sem modificação
                return login;
            }
        }
    }
}
