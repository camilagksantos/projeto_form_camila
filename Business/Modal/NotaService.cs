using projeto_form_camila.Models;
using projeto_form_camila.Persistence;
using projeto_form_camila.Presentation;

namespace projeto_form_camila.Business.Modal
{
    internal class NotaService
    {
        //declaração dos serviços que gerem os modelos 
        LoginService loginService;
        FuncionarioService funcionarioService;
        AlunoService alunoService;
        TurmaService turmaService;
        DisciplinaService disciplinaService;
        public NotaDAO notaDAO { get; set; }

        //construtor que instancia um obj do tipo NotaDao que é a classe que solicita ao _contexto o acesso a base de dados e também dos outros serviços
        public NotaService()
        {
            loginService = new LoginService();
            funcionarioService = new FuncionarioService();
            alunoService = new AlunoService();
            turmaService = new TurmaService();
            disciplinaService = new DisciplinaService();
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

        //método que filtra apenas as notas positivas
        internal List<Nota> FiltrarNotasPositivas()
        {
            return notaDAO.FiltrarNotasPositivas();
        }

        //método que filtra apenas as notas negativas
        internal List<Nota> FiltrarNotasNegativas()
        {
            return notaDAO.FiltrarNotasNegativas();
        }

        //método que busca as notas de um aluno especifico
        internal List<Nota> buscarNotasDoAluno(Aluno aluno)
        {
            return notaDAO.FiltrarNotasDoAluno(aluno);
        }

        // método que busca as notas de todos os alunos de uma turma 
        internal List<NotasDTO> buscarNotasPorTurma(Login login)
        {
            //buscar obj login para se ter o id para comparar
            login.IdLogin = loginService.buscarIdLogin(login);

            //busca funcionario por login_id
            var funcionarioObj = funcionarioService.buscarFuncionarioPorLoginId(login);

            //busca turma comparando o id do funcionario
            var turmaobj = turmaService.buscarTurmaPorIdFuncionario(funcionarioObj);

            //buscar notas dos alunos de uma determinada turma por turma
            var listaNotas = notaDAO.FiltrarNotasPorTurma(turmaobj.IdTurma);

            List<NotasDTO> notasDTOs = new List<NotasDTO>();

            // Preencher o DataGridView com as notas
            foreach (var nota in listaNotas)
            {
                // Busca o aluno usando o AlunoId
                var aluno = alunoService.buscarAlunoPorId(nota.AlunoId);

                // Busca a disciplina usando o DisciplinaId
                var disciplina = disciplinaService.buscarDisciplinaPorId(nota.DisciplinaId);

                NotasDTO notasDTO = new NotasDTO();
                notasDTO.TurmaDesignacao = turmaobj.Designacao;
                notasDTO.IdNota = nota.IdNota;
                notasDTO.IdAluno = aluno.IdAluno;
                notasDTO.NomeAluno = aluno.Nome;
                notasDTO.DisciplinaDesignacao = disciplina;
                notasDTO.DataAtribuicao = nota.DataAtribuicao;
                notasDTO.ValorNota = nota.ValorNota;

                notasDTOs.Add(notasDTO);
            }
            return notasDTOs;
        }

        //método que busca as notas negativas
        internal List<NotasDTO> buscarNotasPorFiltroNegativas(Login login)
        {
            
            return buscarNotasPorTurma(login).Where(nota => nota.ValorNota < 10).ToList();

        }

        //método que busca as notas positivas
        internal List<NotasDTO>  buscarNotasPorFiltroPositivas(Login login)
        {

            return buscarNotasPorTurma(login).Where(nota => nota.ValorNota >= 10).ToList();

        }
    }
}
