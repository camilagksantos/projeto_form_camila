using projeto_form_camila.Models;
using projeto_form_camila.Persistence;

namespace projeto_form_camila.Business.Modal
{
    internal class NotaService
    {
        //propriedade 
        public NotaDAO notaDAO { get; set; }

        //construtor que instancia um obj do tipo NotaDao que é a classe que solicita ao _contexto o acesso a base de dados
        public NotaService()
        {
            notaDAO = new NotaDAO();
        }

        //método que faz a requisição da lista completa de Notas
        internal List<Nota> buscarNotas()
        {
            return notaDAO.buscarNotas();
        }

        //metodo que cria um obj do tipo Nota, atribui valores recebidos por parametros e solicita ao NotaDAO para salvar
        internal void salvarNota(int alunoId, int disciplinaId, DateTime dataAtribuicao, decimal valorNota)
        {
            Nota nota = new Nota();
            nota.AlunoId = alunoId;
            nota.DisciplinaId = disciplinaId;
            nota.DataAtribuicao = dataAtribuicao;
            nota.ValorNota = valorNota;

            notaDAO.salvarNotaBd(nota);
        }

        //metodo que cria um obj do tipo Nota, atribui valores recebidos por parametros e solicita ao NotaDAO para atualizar
        internal void atualizarNota(int idNota, int alunoId, int disciplinaId, DateTime dataAtribuicao, decimal valorNota)
        {
            Nota nota = new Nota();
            nota.IdNota = idNota;
            nota.AlunoId = alunoId;
            nota.DisciplinaId = disciplinaId;
            nota.DataAtribuicao = dataAtribuicao;
            nota.ValorNota = valorNota;

            notaDAO.atualizarNotaBd(nota);
        }

        //método que cria um obj do tipo Nota para referenciar ao NotaDAO um obj para remover
        internal void removerNota(int idNota, int alunoId, int disciplinaId, DateTime dataAtribuicao, decimal valorNota)
        {
            Nota nota = new Nota();
            nota.IdNota = idNota;
            nota.AlunoId = alunoId;
            nota.DisciplinaId = disciplinaId;
            nota.DataAtribuicao = dataAtribuicao;
            nota.ValorNota = valorNota;

            notaDAO.removerNotaBd(nota);
        }

        internal List<Nota> FiltrarNotasPositivas()
        {
            return notaDAO.FiltrarNotasPositivas();
        }

        internal List<Nota> FiltrarNotasNegativas()
        {
            return notaDAO.FiltrarNotasNegativas();
        }
    }
}
