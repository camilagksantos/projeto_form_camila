using projeto_form_camila.Business.Modal;
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
            //CarregarListaAlunos();
            //// Supondo que você tenha um método para buscar o aluno atual e preencher o ListBox
            //CarregarNotasAluno(alunoLoginId);
        }

        private void AlunoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void CarregarListaAlunos()
        {
            //busca alunos por login_id
            //var aluno = alunoService.buscarAlunoPorLoginId(alunoLoginId);

            //// Limpar o ListBox antes de preenchê-lo
            //lstListaAlunosPorNota.Items.Clear();

            //// Preencher o ListBox com os alunos
            //foreach (var aluno in listaAlunos)
            //{
            //    lstListaAlunosPorNota.Items.Add(aluno.Nome);
            //}
        }

        private void lstListaAlunosPorNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Supondo que você tenha um método para buscar notas por aluno_id
            //var alunoSelecionado = listaAlunos[lstListaAlunosPorNota.SelectedIndex];
            //var listaNotas = notaService.buscarNotasPorAlunoId(alunoSelecionado.IdAluno);

            //// Limpar o DataGridView antes de preenchê-lo
            //dgvAlunoNotas.DataSource = null;
            //dgvAlunoNotas.Rows.Clear();

            //// Preencher o DataGridView com as notas
            //foreach (var nota in listaNotas)
            //{
            //    dgvAlunoNotas.Rows.Add(nota.Disciplina, nota.DataAtribuicao, nota.Nota);
            //}
        }
    }
}
