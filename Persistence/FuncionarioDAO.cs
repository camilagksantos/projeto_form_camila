﻿using Microsoft.EntityFrameworkCore;
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
            _Context.Funcionarios.Update(funcionario);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Funcionario
        internal void removerFuncionarioBd(Funcionario funcionario)
        {
            _Context.Funcionarios.Remove(funcionario);
            _Context.SaveChanges();
        }
    }
}
