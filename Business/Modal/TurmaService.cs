﻿using projeto_form_camila.Business.Models;
using projeto_form_camila.Persistence;

namespace projeto_form_camila.Business.Modal
{
    internal class TurmaService
    {
        //propriedade 
        public TurmaDAO turmaDAO { get; set; }

        //construtor que instancia um obj do tipo TurmaDao que é a classe que solicita ao _contexto o acesso a base de dados
        public TurmaService()
        {
            turmaDAO = new TurmaDAO();
        }

        //método que faz a requisição da lista completa de Turmas
        internal List<Turma> buscarTurmas()
        {
            return turmaDAO.buscarTurmas();
        }

        //metodo que cria um obj do tipo Turma, atribui valores recebidos por parametros e solicita ao TurmaDAO para salvar
        internal void salvarTurma(string designacao, int professorId)
        {
            Turma turma = new Turma();
            turma.Designacao = designacao;
            turma.ProfessorId = professorId;

            turmaDAO.salvarTurmaBd(turma);
        }

        //metodo que cria um obj do tipo Turma, atribui valores recebidos por parametros e solicita ao TurmaDAO para atualizar
        internal void atualizarTurma(int idTurma, string designacao, int professorId)
        {
            Turma turma = new Turma();
            turma.IdTurma = idTurma;
            turma.Designacao = designacao;
            turma.ProfessorId = professorId;

            turmaDAO.atualizarTurmaBd(turma);
        }

        //método que cria um obj do tipo Turma para referenciar ao TurmaDAO um obj para remover
        internal void removerTurma(int idTurma, string designacao, int professorId)
        {
            Turma turma = new Turma();
            turma.IdTurma = idTurma;
            turma.Designacao = designacao;
            turma.ProfessorId = professorId;

            turmaDAO.removerTurmaBd(turma);
        }

        //método que busca uma lista de turmas de acordo com uma turma que esta selecionada
        internal List<Turma> buscarTurmasFiltrada(string? turmaSelecionada)
        {
            return turmaDAO.buscarTurmasFiltrada(turmaSelecionada);
        }

        //método que busca uma turma de um funcionario especifico (no caso do funcionario ser um professor)
        internal Turma buscarTurmaPorIdFuncionario(Funcionario funcionarioObj)
        {
            return turmaDAO.buscarTurmaPorIdFuncionario(funcionarioObj);
        }
    }
}
