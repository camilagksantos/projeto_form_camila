using Microsoft.EntityFrameworkCore;
using projeto_form_camila.Models;


namespace projeto_form_camila.Persistence
{
    internal class NotaDAO
    {
        //propriedade
        public BdProjetoFormCamilaContext _Context { get; set; }

        //Contrutor que inicializa os obj do tipo "BdProjetoFormCamilaContext" para acessar a base de dados
        public NotaDAO()
        {
            _Context = new BdProjetoFormCamilaContext();
        }

        //método que pede para o _Context para buscar uma lista de Nota
        internal List<Nota> buscarNotas()
        {
            return _Context.Nota.AsNoTracking().ToList();
        }

        //método que envia ao _context uma Nota para salvar
        internal void salvarNotaBd(Nota Nota)
        {
            _Context.Nota.Add(Nota);
            _Context.SaveChanges();
        }

        //método que envia uma solicitação de atualização de um Nota
        internal void atualizarNotaBd(Nota Nota)
        {
            _Context.Nota.Update(Nota);
            _Context.SaveChanges();
        }

        //método que pede ao _Context para remover um Nota
        internal void removerNotaBd(Nota Nota)
        {
            _Context.Nota.Remove(Nota);
            _Context.SaveChanges();
        }
    }
}
