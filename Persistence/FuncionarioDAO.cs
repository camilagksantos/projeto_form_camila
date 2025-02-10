using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Business.Models;
using projeto_form_camila.Models;

namespace projeto_form_camila.Persistence
{
    internal class FuncionarioDAO
    {
        //propriedade
        public BdProjetoFormCamilaContext _Context { get; set; }

        //Contrutor que inicializa os obj do tipo "BdProjetoFormCamilaContext" para acessar a base de dados
        public FuncionarioDAO()
        {
            _Context = new BdProjetoFormCamilaContext();
        }

        //método que pede para o _Context para buscar uma lista de Funcionario
        internal List<Funcionario> buscarFuncionarios()
        {
            return _Context.Funcionarios.AsNoTracking().ToList();
        }

        //método que envia ao _context uma Funcionario para salvar
        internal void salvarFuncionarioBd(Funcionario funcionario)
        {
            _Context.Funcionarios.Add(funcionario);
            _Context.SaveChanges();
        }

        //método que envia uma solicitação de atualização de um Funcionario
        internal void atualizarFuncionarioBd(Funcionario funcionario)
        {
            var funcionarioFind = _Context.Funcionarios.Find(funcionario.IdFuncionario); // Encontra a entidade existente
            _Context.Entry(funcionarioFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Funcionarios.Update(funcionario);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Funcionario
        internal void removerFuncionarioBd(Funcionario funcionario)
        {
            var funcionarioFind = _Context.Funcionarios.Find(funcionario.IdFuncionario); // Encontra a entidade existente
            _Context.Entry(funcionarioFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Funcionarios.Remove(funcionario);
            _Context.SaveChanges();
        }

        //método que busca os funcionarios a partir do cargo selecionado
        internal List<Funcionario> buscarFuncionariosFiltrados(string cargoSelecionado)
        {
            return _Context.Funcionarios.AsNoTracking()
                    .Include(funcionario => funcionario.Login) // Inclui o objeto Login na consulta
                    .Where(funcionario => funcionario.Login.Role == cargoSelecionado)
                    .ToList();
        }

        //método que busca um funcionario especifico a parit de um login
        internal Funcionario buscarFuncionarioPorLoginId(Login login)
        {
            return _Context.Funcionarios.FirstOrDefault(funcionario => funcionario.LoginId == login.IdLogin);
        }
    }
}
