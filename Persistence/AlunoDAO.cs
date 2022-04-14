using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Business.Models;
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
    }
}
