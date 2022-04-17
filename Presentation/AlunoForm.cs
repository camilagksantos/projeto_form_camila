﻿using projeto_form_camila.Business.Modal;
using projeto_form_camila.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_form_camila.Presentation
{
    public partial class AlunoForm : Form
    {
        //declaração dos serviços que gerem os modelos 
        LoginService loginService;
        FuncionarioService funcionarioService;
        AlunoService alunoService;
        TurmaService turmaService;
        DisciplinaService disciplinaService;
        NotaService notaService;
        private Login login;
        public AlunoForm(Login login)
        {
            InitializeComponent();
            loginService = new LoginService();
            funcionarioService = new FuncionarioService();
            alunoService = new AlunoService();
            turmaService = new TurmaService();
            disciplinaService = new DisciplinaService();
            notaService = new NotaService();
            this.login = login;
        }

        private void AlunoForm_Load(object sender, EventArgs e)
        {
            CarregarListaAlunos();
            carregarDgvAlunoNotas();
        }

        private void AlunoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void CarregarListaAlunos()
        {
            //buscar obj login para se ter o id para comparar
            login.IdLogin = loginService.buscarIdLogin(login);

            //busca alunos por login_id
            var alunoObj = alunoService.buscarAlunoPorLoginId(login);

            //busca alunos por turma
            var alunos = alunoService.buscarAlunosFiltrados(alunoObj.TurmaId);

            // Limpar o ListBox antes de preenchê-lo
            lstListaAlunosPorTurma.Items.Clear();

            // Preencher o ListBox com os alunos
            foreach (var aluno in alunos)
            {
                lstListaAlunosPorTurma.Items.Add(aluno.Nome);
            }
        }

        private void carregarDgvAlunoNotas()
        {
            //buscar obj login para se ter o id para comparar
            login.IdLogin = loginService.buscarIdLogin(login);

            //busca alunos por login_id
            var alunoObj = alunoService.buscarAlunoPorLoginId(login);

            //busca notas do aluno
            var listaNotasAluno = notaService.buscarNotasDoAluno(alunoObj); 

            // Limpar o DataGridView antes de preenchê-lo
            dgvAlunoNotas.DataSource = null;
            dgvAlunoNotas.Rows.Clear();

            // Definir as colunas do DataGridView
            dgvAlunoNotas.Columns.Clear();
            dgvAlunoNotas.Columns.Add("Designacao", "Disciplina");
            dgvAlunoNotas.Columns.Add("DataAtribuicao", "Data de Atribuição");
            dgvAlunoNotas.Columns.Add("ValorNota", "Valor da Nota");

            // Preencher o DataGridView com as notas
            foreach (var nota in listaNotasAluno)
            {
                // Busca a designação da disciplina usando o DisciplinaId
                var disciplina = disciplinaService.buscarDisciplinaPorId(nota.DisciplinaId);

                dgvAlunoNotas.Rows.Add(disciplina, nota.DataAtribuicao, nota.ValorNota);
            }
        }
    }
}
