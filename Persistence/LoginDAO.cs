﻿using Microsoft.EntityFrameworkCore;
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
            return _Context.Logins.AsNoTracking().ToList();
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
            var loginFind = _Context.Logins.Find(login.IdLogin); // Encontra a entidade existente
            _Context.Entry(loginFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Logins.Update(login);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Login
        internal void removerLoginBd(Login login)
        {
            var loginFind = _Context.Logins.Find(login.IdLogin); // Encontra a entidade existente
            _Context.Entry(loginFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Logins.Remove(login);
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

        //método que busca todas as roles
        internal List<string> buscarTodasRoles()
        {
            return _Context.Logins
                .Select(login => login.Role).Distinct().ToList();
        }

        //método que busca as roles sem alunos
        internal List<string> buscarRolesSemAluno()
        {
            return _Context.Logins
                .Where(login => !login.Role.Equals("Aluno"))
                .Select(login => login.Role).Distinct().ToList();
        }

        //método que busca os logins de um cargo especifico
        internal List<Login> buscarLoginsFiltrados(string cargoSelecionado)
        {
            return _Context.Logins.AsNoTracking().Where(login => login.Role == cargoSelecionado).ToList();
        }

        //método que busca um login a partir de uma seleção
        internal Login buscarUmLogin(string valorSelecionado)
        {
            var id = Convert.ToInt32(valorSelecionado); 
            return _Context.Logins.Find(id);
        }

        //método que busca o id de um obj login a partir da comparação do username e da password 
        internal int buscarIdLogin(Login login)
        {
            return _Context.Logins
                            .Where(u => u.Username == login.Username && u.Password == login.Password)
                            .Select(u => u.IdLogin)
                            .FirstOrDefault();
        }
    }
}
