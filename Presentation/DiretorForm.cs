using projeto_form_camila.Business.Modal;
using projeto_form_camila.Models;
using System.Data;
using System.Windows.Forms;

namespace projeto_form_camila.Presentation
{
    public partial class DiretorForm : Form
    {
        //declaração dos serviços que gerem os modelos 
        LoginService loginService;
        FuncionarioService funcionarioService;
        AlunoService alunoService;
        TurmaService turmaService;
        DisciplinaService disciplinaService;
        NotaService notaService;
        //=======================================================================
        //construtor
        //=======================================================================
        public DiretorForm()
        {
            InitializeComponent();
            loginService = new LoginService();
            funcionarioService = new FuncionarioService();
            alunoService = new AlunoService();
            turmaService = new TurmaService();
            disciplinaService = new DisciplinaService();
            notaService = new NotaService();
        }

        //=======================================================================
        //FormLoad
        //=======================================================================

        //método que inicializa os componentes do form
        private void DiretorForm_Load(object sender, EventArgs e)
        {
            PreencherDgvs();
            PreencherCombosLogin();
            PreencherCombosFuncionario();
        }

        //=======================================================================
        //Aplication.Exit
        //=======================================================================

        //método que ao carregar em fechar chama o LoginForm
        private void DiretorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        //=======================================================================
        //Preencheimento
        //=======================================================================

        //método que preenche todas as DataGridViews
        public void PreencherDgvs()
        {
            //==============================================
            //DataGridViews
            //==============================================

            dgvDirLogins.DataSource = loginService.buscarLogins();
            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();
            dgvDirAlunos.DataSource = alunoService.buscarAlunos();
            dgvDirTurmas.DataSource = turmaService.buscarTurmas();
            dgvDirDisciplinas.DataSource = disciplinaService.buscarDisciplinas();
            dgvDirNotas.DataSource = notaService.buscarNotas();

            // Limpar a seleção após carregar os dados
            dgvDirLogins.ClearSelection();
            dgvDirAlunos.ClearSelection();
            dgvDirFuncionarios.ClearSelection();
            dgvDirNotas.ClearSelection();
            dgvDirTurmas.ClearSelection();
            dgvDirDisciplinas.ClearSelection();
        }

        //=======================================================================
        //Login
        //=======================================================================

        //método que preenche as combobox do Login
        public void PreencherCombosLogin()
        {
            //Obtenha a lista de roles
           var listaRoles = loginService.buscarRoles();

            //Limpe a combobox antes de preenchê - la
            cbxDirLoginsRole.Items.Clear();
            cbxDirLoginsFiltrarCargo.Items.Clear();

            // Preencha a combobox com os roles
            foreach (var role in listaRoles)
            {
                cbxDirLoginsRole.Items.Add(role);
                cbxDirLoginsFiltrarCargo.Items.Add(role);
            }
        }

        //método que adiciona um Login
        private void btnDirLoginsAdicionar_Click(object sender, EventArgs e)
        {
            string username = txtDirLoginsPassword.Text;
            string password = txtDirLoginsPassword.Text;
            string role = cbxDirLoginsRole.Text;

            loginService.salvarLogin(username, password, role);

            dgvDirLogins.DataSource = loginService.buscarLogins();

            LimparCamposLogins();
        }

        //método que atualiza um Login
        private void btnDirLoginsAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirLoginsId.Text);
            string username = txtDirLoginsUser.Text;
            string password = txtDirLoginsPassword.Text;
            string role = cbxDirLoginsRole.Text;

            loginService.atualizarLogin(id, username, password, role);

            dgvDirLogins.DataSource = loginService.buscarLogins();

            LimparCamposLogins();
        }

        //método que Remove um login
        private void btnDirLoginsRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirLoginsId.Text);
            string username = txtDirLoginsPassword.Text;
            string password = txtDirLoginsPassword.Text;
            string role = cbxDirLoginsRole.Text;

            loginService.removerLogin(id, username, password, role);

            dgvDirLogins.DataSource = loginService.buscarLogins();

            LimparCamposLogins();
        }

        //método que limpa os campos da aba Login
        public void LimparCamposLogins()
        {
            txtDirLoginsId.Text = string.Empty;
            txtDirLoginsUser.Text = string.Empty;
            txtDirLoginsPassword.Text = string.Empty;
            cbxDirLoginsRole.Text = string.Empty;
            cbxDirLoginsFiltrarCargo.Text = string.Empty;
        }

        //método que ao selecionar umalista na dgv preenche os respectivos campos
        private void dgvDirLogins_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvDirLogins.SelectedRows.Count > 0)
            {
                // Obtem a linha selecionada
                DataGridViewRow selectedRow = dgvDirLogins.SelectedRows[0];

                // Preenche os campos do formulário com os dados da linha selecionada
                txtDirLoginsId.Text = selectedRow.Cells["IdLogin"].Value.ToString();
                txtDirLoginsUser.Text = selectedRow.Cells["Username"].Value.ToString();
                txtDirLoginsPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                cbxDirLoginsRole.Text = selectedRow.Cells["Role"].Value.ToString();
            }
        }

        //=======================================================================
        //Funcionario
        //=======================================================================

        //método que preenche as combobox do Funcionario
        public void PreencherCombosFuncionario()
        {
            // Obtenha a lista de roles  e logins
            var listaLogin = loginService.buscarLogins();
            var listaRoles = loginService.buscarRoles();

            // Limpe a combobox antes de preenchê-la
            cbxDirFuncionariosLogin.Items.Clear();
            cbxDirFuncionariosFiltrarCargo.Items.Clear();

            // Defina o DisplayMember e ValueMember para a combobox
            cbxDirFuncionariosLogin.DisplayMember = "Username";
            cbxDirFuncionariosLogin.ValueMember = "IdLogin";

            // Preencha a combobox com os logins
            foreach (var login in listaLogin)
            {
                cbxDirFuncionariosLogin.Items.Add(login);
            }

            // Preencha a combobox com os roles
            foreach (var role in listaRoles)
            {
                cbxDirFuncionariosFiltrarCargo.Items.Add(role);
            }
        }

        //método que adiciona um funcionario
        private void btnDirFuncionariosAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtDirFuncionarioNome.Text;
            int login = Convert.ToInt32(cbxDirFuncionariosLogin.SelectedIndex);

            funcionarioService.salvarFuncionario(nome, login);

            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();

            LimparCamposFuncionarios();
        }

        //método que atualiza um funcionario
        private void btnDirFuncionariosAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirFuncionarioId.Text);
            string nome = txtDirFuncionarioNome.Text;
            int login = Convert.ToInt32(cbxDirFuncionariosLogin.SelectedIndex);

            funcionarioService.atualizarFuncionario(id, nome, login);

            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();

            LimparCamposFuncionarios();
        }

        //método que Remove um Funcionario
        private void btnDirFuncionariosRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirFuncionarioId.Text);
            string nome = txtDirFuncionarioNome.Text;
            int login = Convert.ToInt32(cbxDirFuncionariosLogin.SelectedIndex);

            funcionarioService.removerFuncionario(id, nome, login);

            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();

            LimparCamposFuncionarios();
        }

        //método que limpa os campos da aba FUncionarios
        public void LimparCamposFuncionarios()
        {
            txtDirFuncionarioId.Text = string.Empty;
            txtDirFuncionarioNome.Text = string.Empty;
            cbxDirFuncionariosLogin.Text = string.Empty;
            cbxDirFuncionariosFiltrarCargo.Text= string.Empty;
        }

        //método que ao selecionar umalista na dgv preenche os respectivos campos
        private void dgvDirFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            //// Verifica se há uma linha selecionada
            //if (dgvDirFuncionarios.SelectedRows.Count > 0)
            //{
            //    // Obtem a linha selecionada
            //    DataGridViewRow selectedRow = dgvDirFuncionarios.SelectedRows[0];

            //    // Preenche os campos do formulário com os dados da linha selecionada
            //    txtDirFuncionarioId.Text = selectedRow.Cells["IdFuncionario"].Value.ToString();
            //    txtDirFuncionarioNome.Text = selectedRow.Cells["Nome"].Value.ToString();
            //    cbxDirFuncionarioCargo.Text = selectedRow.Cells["LoginId"].Value.ToString();
            //}
        }

        //=======================================================================
        //Turma
        //=======================================================================

        //=======================================================================
        //Aluno
        //=======================================================================

        //=======================================================================
        //Disciplina
        //=======================================================================

        //=======================================================================
        //Nota
        //=======================================================================
    }
}
