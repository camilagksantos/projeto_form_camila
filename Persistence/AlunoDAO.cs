﻿using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Models;

namespace projeto_form_camila.Persistence
{
    internal class AlunoDAO
    {
        //propriedade
        public BdProjetoFormCamilaContext _Context { get; set; }

        //Contrutor que inicializa os obj do tipo "BdProjetoFormCamilaContext" para acessar a base de dados
        public AlunoDAO() 
        {
            _Context = new BdProjetoFormCamilaContext();
        }

        //método que pede para o _Context para buscar uma lista de alunos
        internal List<Aluno> buscarAlunos() 
        { 
            return _Context.Alunos.AsNoTracking().ToList();
        }

        //método que envia ao _context um aluno para salvar
        internal void salvarAlunoBd(Aluno aluno)
        {
            _Context.Alunos.Add(aluno);
            _Context.SaveChanges();
        }

        //método que envia uma solicitação de atualização de um aluno
        internal void atualizarAlunoBd(Aluno aluno)
        {
            var alunoFind = _Context.Alunos.Find(aluno.IdAluno); // Encontra a entidade existente
            _Context.Entry(alunoFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Alunos.Update(aluno);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um aluno
        internal void removerAlunoBd(Aluno aluno)
        {
            var alunoFind = _Context.Alunos.Find(aluno.IdAluno); // Encontra a entidade existente
            _Context.Entry(alunoFind).State = EntityState.Detached; // Desanexa a entidade

            _Context.Alunos.Remove(aluno);
            _Context.SaveChanges();
        }

        //método que busca um aluno a partir do id
        internal Aluno buscarAlunoPorLoginId(Login login)
        {
            return _Context.Alunos.SingleOrDefault(aluno => aluno.LoginId == login.IdLogin);
        }

        //método que que busca os alunos de uma turma especifica a partir do id
        internal List<Aluno> buscarAlunosFiltrados(int idTurma)
        {
            return _Context.Alunos.Where(aluno => aluno.TurmaId == idTurma).ToList();
        }

        //método que busca os alunos de uma turma especifica
        internal List<Aluno> FiltrarAlunosPorTurmasSelecionadas(List<int> turmasSelecionadas)
        {
            return _Context.Alunos.Where(aluno => turmasSelecionadas.Contains(aluno.TurmaId)).ToList();
        }

        //método que busca um aluno especifico a partir de um id
        internal Aluno buscarAlunoPorId(int alunoId)
        {
            return _Context.Alunos.SingleOrDefault(aluno => aluno.IdAluno == alunoId);
        }
    }
}
