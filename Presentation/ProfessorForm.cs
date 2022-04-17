using projeto_form_camila.Business.Modal;
using projeto_form_camila.Models;

namespace projeto_form_camila.Presentation
{
    public partial class ProfessorForm : Form
    {
        //declaração dos serviços que gerem os modelos 
        LoginService loginService;
        FuncionarioService funcionarioService;
        AlunoService alunoService;
        TurmaService turmaService;
        DisciplinaService disciplinaService;
        NotaService notaService;
        private Login login;
        public ProfessorForm(Login login)
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

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            carregarDgvProfessores();
            PreencherCombosNotas();
        }

        private void ProfessorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void carregarDgvProfessores()
        {
            dgvProfessor.DataSource = notaService.buscarNotasPorTurma(login);
        }

        public void PreencherCombosNotas()
        {
            // Obtem a lista de Alunos e Disciplinas
            var listaAlunos = alunoService.buscarAlunos();
            var listaDisciplinas = disciplinaService.buscarDisciplinas();

            // Limpa a combobox antes de preenchê-la
            cbxProfNotaAluno.Items.Clear();
            cbxProfNotaDisciplina.Items.Clear();

            // Defina o DisplayMember e ValueMember para a combo alunos 
            cbxProfNotaAluno.DisplayMember = "Nome";
            cbxProfNotaAluno.ValueMember = "IdAluno";

            // Defina o DisplayMember e ValueMember para a combo disciplinas
            cbxProfNotaDisciplina.DisplayMember = "Designacao";
            cbxProfNotaDisciplina.ValueMember = "IdDisciplina";

            // Preencha a combobox com os Alunos
            foreach (var aluno in listaAlunos)
            {
                cbxProfNotaAluno.Items.Add(aluno);
            }

            // Preencha a combobox com os Alunos
            foreach (var disciplinas in listaDisciplinas)
            {
                cbxProfNotaDisciplina.Items.Add(disciplinas);
            }
        }

        //método que limpa os campos da aba Notas
        public void LimparCamposProfessor()
        {
            txtProfNotaId.Text = string.Empty;
            cbxProfNotaAluno.Text = string.Empty;
            cbxProfNotaDisciplina.Text = string.Empty;
            dtpProfNotaData.Value = DateTime.Now;
            txtProfNotaNota.Text = string.Empty;
            ckxProfNotaNegativa.Checked = false;
            ckxProfNotaPositiva.Checked = false;
        }

        //método que procura dentro da coleção de uma combobox o index para buscar o index do valor selecionado na dgv
        public void SelectItemByValue(System.Windows.Forms.ComboBox cbo, string value)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                var prop = cbo.Items[i].GetType().GetProperty(cbo.ValueMember);
                if (prop != null && prop.GetValue(cbo.Items[i], null).ToString() == value)
                {
                    cbo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void dgvProfessor_SelectionChanged(object sender, EventArgs e)
        {
            //// Verifica se há uma linha selecionada
            //if (dgvProfessor.SelectedRows.Count > 0)
            //{
            //    // Obtem a linha selecionada
            //    DataGridViewRow selectedRow = dgvProfessor.SelectedRows[0];

            //    // Preenche os campos do formulário com os dados da linha selecionada
            //    txtProfNotaId.Text = selectedRow.Cells["IdNota"].Value.ToString();
            //    txtProfNotaNota.Text = selectedRow.Cells["ValorNota"].Value.ToString();
            //    dtpProfNotaData.Value = Convert.ToDateTime(selectedRow.Cells["DataAtribuicao"].Value);

            //    // guarda na variavel o valor da celula selecionada 
            //    var valorAlunoSelecionado = selectedRow.Cells["AlunoId"].Value.ToString();
            //    var valorDisciplinaSelecionada = selectedRow.Cells["DisciplinaId"].Value.ToString();

            //    //chama o método que procura o valor selecionado dentro  da lista dele e aplica o valor do inx no value member
            //    SelectItemByValue(cbxProfNotaAluno, valorAlunoSelecionado);
            //    SelectItemByValue(cbxProfNotaDisciplina, valorDisciplinaSelecionada);
            //}
        }

        private void ckxProfNotaNegativa_CheckedChanged(object sender, EventArgs e)
        {
            dgvProfessor.DataSource = notaService.buscarNotasPorFiltroNegativas(login);
        }

        private void ckxProfNotaPositiva_CheckedChanged(object sender, EventArgs e)
        {
            dgvProfessor.DataSource = notaService.buscarNotasPorFiltroPositivas(login);
        }

        //método do botão limpar que limpa os campos
        private void btnProfessorLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposProfessor();
        }

        private void btnProfNotasAdicionar_Click(object sender, EventArgs e)
        {
            Aluno aluno = (Aluno)cbxProfNotaAluno.SelectedItem;
            Disciplina disciplina = (Disciplina)cbxProfNotaDisciplina.SelectedItem;
            DateTime dataAtribuicao = dtpProfNotaData.Value;
            decimal nota = Convert.ToDecimal(txtProfNotaNota.Text);

            notaService.salvarNota(aluno.IdAluno, disciplina.IdDisciplina, dataAtribuicao, nota);

            carregarDgvProfessores();

            LimparCamposProfessor();
        }

        private void btnProfNotasAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProfNotaId.Text);
            Aluno aluno = (Aluno)cbxProfNotaAluno.SelectedItem;
            Disciplina disciplina = (Disciplina)cbxProfNotaDisciplina.SelectedItem;
            DateTime dataAtribuicao = dtpProfNotaData.Value;
            decimal nota = Convert.ToDecimal(txtProfNotaNota.Text);

            notaService.atualizarNota(id, aluno.IdAluno, disciplina.IdDisciplina, dataAtribuicao, nota);

            carregarDgvProfessores();

            LimparCamposProfessor();
        }

        private void btnProfNotasRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProfNotaId.Text);
            Aluno aluno = (Aluno)cbxProfNotaAluno.SelectedItem;
            Disciplina disciplina = (Disciplina)cbxProfNotaDisciplina.SelectedItem;
            DateTime dataAtribuicao = dtpProfNotaData.Value;
            decimal nota = Convert.ToDecimal(txtProfNotaNota.Text);

            notaService.removerNota(id, aluno.IdAluno, disciplina.IdDisciplina, dataAtribuicao, nota);

            carregarDgvProfessores();

            LimparCamposProfessor();
        }
    }
}
