using projeto_form_camila.Business.Modal;
using projeto_form_camila.Business.Models;
using projeto_form_camila.Models;
using System.Data;

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
            PreencherGridsECombos();
        }

        //este método faz a chamada de todos os metodos de preenchimento
        private void PreencherGridsECombos()
        {
            PreencherDgvs();
            PreencherCombosLogin();
            PreencherCombosFuncionario();
            PreencherCombosTurma();
            PreencherCombosNotas();
            PreencherCombosAlunos();
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

            // Limpa a seleção após carregar os dados
            dgvDirLogins.ClearSelection();
            dgvDirAlunos.ClearSelection();
            dgvDirFuncionarios.ClearSelection();
            dgvDirNotas.ClearSelection();
            dgvDirTurmas.ClearSelection();
            dgvDirDisciplinas.ClearSelection();

            //Esconder as colunas referente aos relacionamentos dos objetos
            // Logins
            dgvDirLogins.Columns["Alunos"].Visible = false;
            dgvDirLogins.Columns["Funcionarios"].Visible = false;

            // Funcionarios
            dgvDirFuncionarios.Columns["Login"].Visible = false;
            dgvDirFuncionarios.Columns["Turmas"].Visible = false;

            // Alunos
            dgvDirAlunos.Columns["Login"].Visible = false;
            dgvDirAlunos.Columns["Nota"].Visible = false;
            dgvDirAlunos.Columns["Turma"].Visible = false;

            // Turmas
            dgvDirTurmas.Columns["Alunos"].Visible = false;
            dgvDirTurmas.Columns["Professor"].Visible = false;

            // Disciplinas
            dgvDirDisciplinas.Columns["Nota"].Visible = false;

            // Notas
            dgvDirNotas.Columns["Aluno"].Visible = false;
            dgvDirNotas.Columns["Disciplina"].Visible = false;
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

        //=======================================================================
        //Login
        //=======================================================================

        //método que preenche as combobox do Login
        public void PreencherCombosLogin()
        {
            //Obtem a lista de roles
            var listaRoles = loginService.buscarTodasRoles();

            //Limpa a combobox antes de preenchê-la
            cbxDirLoginsRole.Items.Clear();
            cbxDirLoginsFiltrarCargo.Items.Clear();

            // Adiciona a opção "Todos" no início da lista
            cbxDirLoginsFiltrarCargo.Items.Add("Todos");

            // Preenche a combobox com os roles
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

        //método que ao selecionar uma lista na dgv preenche os respectivos campos
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

        //método que filtra os logins por cargo
        private void cbxDirLoginsFiltrarCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém o cargo selecionado na ComboBox
            string cargoSelecionado = cbxDirLoginsFiltrarCargo.SelectedItem.ToString();

            // Verifica se a opção "Todos" foi selecionada
            if (cargoSelecionado == "Todos")
            {
                // Carrega todos os logins sem filtro
                dgvDirLogins.DataSource = loginService.buscarLogins();
            }
            else
            {
                // Filtra os logins com base no cargo selecionado
                var loginsFiltrados = loginService.buscarLoginsFiltrados(cargoSelecionado);

                // Atualiza a fonte de dados da DataGridView com os logins filtrados
                dgvDirLogins.DataSource = loginsFiltrados;
            }
        }

        //método do botão limpar
        private void btnDirLoginsLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposLogins();
        }

        //=======================================================================
        //Funcionario
        //=======================================================================

        //método que preenche as combobox do Funcionario
        public void PreencherCombosFuncionario()
        {
            // Obtem a lista de roles  e logins
            var listaLogin = loginService.buscarLogins();
            var listaRoles = loginService.buscarRolesSemAluno();

            // Limpa a combobox antes de preenchê-la
            cbxDirFuncionariosLogin.Items.Clear();
            cbxDirFuncionariosFiltrarCargo.Items.Clear();

            // Adiciona a opção "Todos" no início da lista
            cbxDirFuncionariosFiltrarCargo.Items.Add("Todos");

            // Define o DisplayMember e ValueMember para a combobox
            cbxDirFuncionariosLogin.DisplayMember = "Username";
            cbxDirFuncionariosLogin.ValueMember = "IdLogin";

            // Preenche a combobox com os logins
            foreach (var login in listaLogin)
            {
                cbxDirFuncionariosLogin.Items.Add(login);
            }

            // Preenche a combobox com os roles
            foreach (var role in listaRoles)
            {
                cbxDirFuncionariosFiltrarCargo.Items.Add(role);
            }
        }

        //método que adiciona um funcionario
        private void btnDirFuncionariosAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtDirFuncionarioNome.Text;
            Login login = (Login)cbxDirFuncionariosLogin.SelectedItem;

            funcionarioService.salvarFuncionario(nome, login.IdLogin);

            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();

            LimparCamposFuncionarios();
        }

        //método que atualiza um funcionario
        private void btnDirFuncionariosAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirFuncionarioId.Text);
            string nome = txtDirFuncionarioNome.Text;
            Login login = (Login)cbxDirFuncionariosLogin.SelectedItem;

            funcionarioService.atualizarFuncionario(id, nome, login.IdLogin);

            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();

            LimparCamposFuncionarios();
        }

        //método que Remove um Funcionario
        private void btnDirFuncionariosRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirFuncionarioId.Text);
            string nome = txtDirFuncionarioNome.Text;
            Login login = (Login)cbxDirFuncionariosLogin.SelectedItem;

            funcionarioService.removerFuncionario(id, nome, login.IdLogin);

            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();

            LimparCamposFuncionarios();
        }

        //método que limpa os campos da aba FUncionarios
        public void LimparCamposFuncionarios()
        {
            txtDirFuncionarioId.Text = string.Empty;
            txtDirFuncionarioNome.Text = string.Empty;
            cbxDirFuncionariosLogin.Text = string.Empty;
            cbxDirFuncionariosFiltrarCargo.Text = string.Empty;
        }

        //método que ao selecionar umalista na dgv preenche os respectivos campos
        private void dgvDirFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvDirFuncionarios.SelectedRows.Count > 0)
            {
                // Obtem a linha selecionada
                DataGridViewRow selectedRow = dgvDirFuncionarios.SelectedRows[0];

                // Preenche os campos do formulário com os dados da linha selecionada
                txtDirFuncionarioId.Text = selectedRow.Cells["IdFuncionario"].Value.ToString();
                txtDirFuncionarioNome.Text = selectedRow.Cells["Nome"].Value.ToString();


                // guarda na variavel o valor da celula selecionada no campo "LoginId"
                var valorSelecionado = selectedRow.Cells["LoginId"].Value.ToString();

                //chama o método que procura o valor selecionado dentro  da lista dele e aplica o valor do inx no value member
                SelectItemByValue(cbxDirFuncionariosLogin, valorSelecionado);
            }
        }

        //método que filtra os resultados na grid
        private void cbxDirFuncionariosFiltrarCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém o cargo selecionado na ComboBox
            string cargoSelecionado = cbxDirFuncionariosFiltrarCargo.SelectedItem.ToString();

            // Verifica se a opção "Todos" foi selecionada
            if (cargoSelecionado == "Todos")
            {
                // Carrega todos os funcionários sem filtro
                dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();
            }
            else
            {
                // Filtra os funcionários com base no cargo selecionado, incluindo o objeto Login
                var funcionariosFiltrados = funcionarioService.buscarFuncionariosFiltrados(cargoSelecionado);

                // Atualiza a fonte de dados da DataGridView com os funcionários filtrados
                dgvDirFuncionarios.DataSource = funcionariosFiltrados;
            }
        }

        //método do botão limpar que limpa os campos
        private void btnDirFuncionariosLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposFuncionarios();
        }

        //=======================================================================
        //Turma
        //=======================================================================

        //método que preenche as combobox da Turma
        public void PreencherCombosTurma()
        {
            // Obtem a lista de Professores e Turmas
            var listaProfessores = funcionarioService.buscarFuncionariosFiltrados("Professor");

            // Limpe a combobox antes de preenchê-la
            cbxDirTurmasProfessorId.Items.Clear();

            // Defina o DisplayMember e ValueMember para a combobox de professores
            cbxDirTurmasProfessorId.DisplayMember = "Nome";
            cbxDirTurmasProfessorId.ValueMember = "IdFuncionario";

            // Preencha a combobox com os professores
            foreach (var professor in listaProfessores)
            {
                cbxDirTurmasProfessorId.Items.Add(professor);
            }
        }

        //método que adiciona uma turma
        private void btnDirTurmasAdicionar_Click(object sender, EventArgs e)
        {
            string designacao = txtDirTurmasDesignacao.Text;
            Funcionario funcionario = (Funcionario)cbxDirTurmasProfessorId.SelectedItem;

            turmaService.salvarTurma(designacao, funcionario.IdFuncionario);

            dgvDirTurmas.DataSource = turmaService.buscarTurmas();

            LimparCamposTurmas();
        }

        //método que atualiza uma turma
        private void btnDirTurmasAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirTurmasId.Text);
            string designacao = txtDirTurmasDesignacao.Text;
            Funcionario funcionario = (Funcionario)cbxDirTurmasProfessorId.SelectedItem;

            turmaService.atualizarTurma(id, designacao, funcionario.IdFuncionario);

            dgvDirTurmas.DataSource = turmaService.buscarTurmas();

            LimparCamposTurmas();
        }

        //método que remove uma turma
        private void btnDirTurmasRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirTurmasId.Text);
            string designacao = txtDirTurmasDesignacao.Text;
            Funcionario funcionario = (Funcionario)cbxDirTurmasProfessorId.SelectedItem;

            turmaService.removerTurma(id, designacao, funcionario.IdFuncionario);

            dgvDirTurmas.DataSource = turmaService.buscarTurmas();

        }

        //método que limpa os campos da aba Turmas
        public void LimparCamposTurmas()
        {
            txtDirTurmasId.Text = string.Empty;
            txtDirTurmasDesignacao.Text = string.Empty;
            cbxDirTurmasProfessorId.Text = string.Empty;
        }

        //método que ao selecionar umalista na dgv preenche os respectivos campos
        private void dgvDirTurmas_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvDirTurmas.SelectedRows.Count > 0)
            {
                // Obtem a linha selecionada
                DataGridViewRow selectedRow = dgvDirTurmas.SelectedRows[0];

                // Preenche os campos do formulário com os dados da linha selecionada
                txtDirTurmasId.Text = selectedRow.Cells["IdTurma"].Value.ToString();
                txtDirTurmasDesignacao.Text = selectedRow.Cells["Designacao"].Value.ToString();

                // guarda na variavel o valor da celula selecionada no campo "ProfessorId"
                var valorSelecionado = selectedRow.Cells["ProfessorId"].Value.ToString();

                //chama o método que procura o valor selecionado dentro  da lista dele e aplica o valor do inx no value member
                SelectItemByValue(cbxDirTurmasProfessorId, valorSelecionado);
            }
        }

        //método do botão limpar que limpa os campos
        private void btnDirTurmasLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposTurmas();
        }

        //=======================================================================
        //Aluno
        //=======================================================================

        //método que preenche as combobox da aluno
        public void PreencherCombosAlunos()
        {
            // Obtem a lista de logins, Turmas e disciplinas
            var listaTurmas = turmaService.buscarTurmas();
            var listaLoginAlunos = loginService.buscarLoginsFiltrados("Aluno");
            var listaDisciplinas = disciplinaService.buscarDisciplinas();

            // Limpe a combobox antes de preenchê-la
            cbxDirAlunosTurma.Items.Clear();
            cbxDirAlunosLoginId.Items.Clear();

            // Defina o DisplayMember e ValueMember para a combobox de turmas
            cbxDirAlunosTurma.DisplayMember = "Designacao";
            cbxDirAlunosTurma.ValueMember = "IdTurma";

            // Defina o DisplayMember e ValueMember para a combobox de logins
            cbxDirAlunosLoginId.DisplayMember = "Username";
            cbxDirAlunosLoginId.ValueMember = "IdLogin";

            // Preencha a combobox com as turmas
            foreach (var turma in listaTurmas)
            {
                cbxDirAlunosTurma.Items.Add(turma);
            }

            // Preencha a combobox com os logins
            foreach (var login in listaLoginAlunos)
            {
                cbxDirAlunosLoginId.Items.Add(login);
            }
        }

        //método que limpa os campos da aba Turmas
        public void LimparCamposAlunos()
        {
            txtDirAlunosId.Text = string.Empty;
            txtDirAlunosNome.Text = string.Empty;
            txtDirAlunosApelido.Text = string.Empty;
            txtDirAlunosIdade.Text = string.Empty;
            txtDirAlunosEmail.Text = string.Empty;
            cbxDirAlunosTurma.Text = string.Empty;
            cbxDirAlunosLoginId.Text = string.Empty;
            ckbDirAlunos1Ano.Checked = false;
            ckbDirAlunos2Ano.Checked = false;
            ckbDirAlunos3Ano.Checked = false;
            ckbDirAlunos4Ano.Checked = false;
        }

        //método que ao selecionar uma linha na dgv preenche os respectivos campos
        private void dgvDirAlunos_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvDirAlunos.SelectedRows.Count > 0)
            {
                // Obtem a linha selecionada
                DataGridViewRow selectedRow = dgvDirAlunos.SelectedRows[0];

                // Preenche os campos do formulário com os dados da linha selecionada
                txtDirAlunosId.Text = selectedRow.Cells["IdAluno"].Value.ToString();
                txtDirAlunosNome.Text = selectedRow.Cells["Nome"].Value.ToString();
                txtDirAlunosApelido.Text = selectedRow.Cells["Apelido"].Value.ToString();
                txtDirAlunosIdade.Text = selectedRow.Cells["Idade"].Value.ToString();
                txtDirAlunosEmail.Text = selectedRow.Cells["Email"].Value.ToString();

                // guarda na variavel o valor da celula selecionada no campo "ProfessorId"
                var turmaSelecionada = selectedRow.Cells["TurmaId"].Value.ToString();
                var LoginSelecionado = selectedRow.Cells["LoginId"].Value.ToString();

                //chama o método que procura o valor selecionado dentro  da lista dele e aplica o valor do inx no value member
                SelectItemByValue(cbxDirAlunosTurma, turmaSelecionada);
                SelectItemByValue(cbxDirAlunosLoginId, LoginSelecionado);
            }
        }

        //método que adiciona um aluno
        private void btnDirAlunosAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtDirAlunosNome.Text;
            string apelido = txtDirAlunosApelido.Text;
            int idade = Convert.ToInt32(txtDirAlunosIdade.Text);
            string email = txtDirAlunosEmail.Text;
            Turma turma = (Turma)cbxDirAlunosTurma.SelectedItem;
            Login login = (Login)cbxDirAlunosLoginId.SelectedItem;

            alunoService.salvarAluno(nome, apelido, idade, email, turma.IdTurma, login.IdLogin);

            dgvDirAlunos.DataSource = alunoService.buscarAlunos();

            LimparCamposAlunos();
        }

        //método que atualiza um aluno
        private void btnDirAlunosAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirAlunosId.Text);
            string nome = txtDirAlunosNome.Text;
            string apelido = txtDirAlunosApelido.Text;
            int idade = Convert.ToInt32(txtDirAlunosIdade.Text);
            string email = txtDirAlunosEmail.Text;
            Turma turma = (Turma)cbxDirAlunosTurma.SelectedItem;
            Login login = (Login)cbxDirAlunosLoginId.SelectedItem;

            alunoService.atualizarAluno(id, nome, apelido, idade, email, turma.IdTurma, login.IdLogin);

            dgvDirAlunos.DataSource = alunoService.buscarAlunos();

            LimparCamposAlunos();
        }

        //método que remove um aluno
        private void btnDirAlunosRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirAlunosId.Text);
            string nome = txtDirAlunosNome.Text;
            string apelido = txtDirAlunosApelido.Text;
            int idade = Convert.ToInt32(txtDirAlunosIdade.Text);
            string email = txtDirAlunosEmail.Text;
            Turma turma = (Turma)cbxDirAlunosTurma.SelectedItem;
            Login login = (Login)cbxDirAlunosLoginId.SelectedItem;

            alunoService.removerAluno(id, nome, apelido, idade, email, turma.IdTurma, login.IdLogin);

            dgvDirAlunos.DataSource = alunoService.buscarAlunos();

            LimparCamposAlunos();
        }

        // Lista para armazenar os IDs das turmas selecionadas
        private List<int> turmasSelecionadas = new List<int>();

        private void AtualizarFiltroTurmas()
        {
            // Limpa a lista de turmas selecionadas
            turmasSelecionadas.Clear();

            // Atualizar a lista de turmas selecionadas com base no estado das checkboxes
            if (ckbDirAlunos1Ano.Checked) turmasSelecionadas.Add(1);
            if (ckbDirAlunos2Ano.Checked) turmasSelecionadas.Add(2);
            if (ckbDirAlunos3Ano.Checked) turmasSelecionadas.Add(3);
            if (ckbDirAlunos4Ano.Checked) turmasSelecionadas.Add(4);

            //Se não houver turmas selecionadas, mostrar todos os alunos
            if (!turmasSelecionadas.Any())
            {
                dgvDirAlunos.DataSource = alunoService.buscarAlunos().ToList();
                return;
            } else 
            {
                // Filtrar alunos com base na lista de turmas selecionadas
                dgvDirAlunos.DataSource = alunoService.FiltrarAlunosPorTurmasSelecionadas(turmasSelecionadas);
            }
        }

        //checkbox
        private void ckbDirAlunos1Ano_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarFiltroTurmas();
        }

        private void ckbDirAlunos2Ano_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarFiltroTurmas();
        }

        private void ckbDirAlunos3Ano_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarFiltroTurmas();
        }

        private void ckbDirAlunos4Ano_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarFiltroTurmas();
        }

        //método que filtra as notas em positivas ou negativas
        private void FiltrarNotasNota()
        {
            // Obter a lista de notas
            var listaNotas = notaService.buscarNotas();

            // Verificar se deve filtrar notas positivas
            if (ckxDirNotasFiltrarNotaPositiva.Checked)
            {
                listaNotas = listaNotas.Where(n => n.ValorNota >= 10).ToList();
            }

            // Verificar se deve filtrar notas negativas
            if (ckxDirNotasFiltrarNotaNegativa.Checked)
            {
                listaNotas = listaNotas.Where(n => n.ValorNota < 10).ToList();
            }

            // Atualizar a fonte de dados do DataGridView
            dgvDirNotas.DataSource = listaNotas;
        }

        private void ckxDirAlunosGpbFiltrarNotaNegativa_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarNotasNota();
        }

        private void ckxDirAlunosGpbFiltrarNotaPositiva_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarNotasNota();
        }

        //método do botao limpar que limpa os campos
        private void btnDirAlunosLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposAlunos();
        }

        //=======================================================================
        //Disciplina
        //=======================================================================

        //método que ao selecionar uma linha na dgv atribui o valor de cada celula a peça correspondente
        private void dgvDirDisciplinas_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvDirDisciplinas.SelectedRows.Count > 0)
            {
                // Obtem a linha selecionada
                DataGridViewRow selectedRow = dgvDirDisciplinas.SelectedRows[0];

                // Preenche os campos do formulário com os dados da linha selecionada
                txtDirDisciplinaId.Text = selectedRow.Cells["IdDisciplina"].Value.ToString();
                txtDirDisciplinaDesignacao.Text = selectedRow.Cells["Designacao"].Value.ToString();
            }
        }

        //método que limpa os campos da aba Disciplinas
        public void LimparCamposDisciplinas()
        {
            txtDirDisciplinaId.Text = string.Empty;
            txtDirDisciplinaDesignacao.Text = string.Empty;
        }

        //método que salva uma disciplina
        private void btnDirDisciplinaAdicionar_Click(object sender, EventArgs e)
        {
            string designacao = txtDirDisciplinaDesignacao.Text;

            disciplinaService.salvarDisciplina(designacao);

            dgvDirDisciplinas.DataSource = disciplinaService.buscarDisciplinas();

            LimparCamposDisciplinas();
        }

        //método que atualiza uma disciplina
        private void btnDirDisciplinaAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirDisciplinaId.Text);
            string designacao = txtDirDisciplinaDesignacao.Text;

            disciplinaService.atualizarDisciplina(id, designacao);

            dgvDirDisciplinas.DataSource = disciplinaService.buscarDisciplinas();

            LimparCamposDisciplinas();
        }
        //método que remove uma disciplina
        private void btnDirDisciplinaRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirDisciplinaId.Text);
            string designacao = txtDirTurmasDesignacao.Text;

            disciplinaService.removerDisciplina(id, designacao);

            dgvDirDisciplinas.DataSource = disciplinaService.buscarDisciplinas();

            LimparCamposDisciplinas();
        }

        //método do botao limpar que limpa os campos
        private void btnDirDisciplinasLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposDisciplinas();
        }

        //=======================================================================
        //Nota
        //=======================================================================

        //método que preenche as combobox da Turma
        public void PreencherCombosNotas()
        {
            // Obtem a lista de Alunos e Disciplinas
            var listaAlunos = alunoService.buscarAlunos();
            var listaDisciplinas = disciplinaService.buscarDisciplinas();

            // Limpa a combobox antes de preenchê-la
            cbxDirNotaAluno.Items.Clear();
            cbxDirNotaDisciplina.Items.Clear();

            // Defina o DisplayMember e ValueMember para a combo alunos 
            cbxDirNotaAluno.DisplayMember = "Nome";
            cbxDirNotaAluno.ValueMember = "IdAluno";

            // Defina o DisplayMember e ValueMember para a combo disciplinas
            cbxDirNotaDisciplina.DisplayMember = "Designacao";
            cbxDirNotaDisciplina.ValueMember = "IdDisciplina";

            // Preencha a combobox com os Alunos
            foreach (var aluno in listaAlunos)
            {
                cbxDirNotaAluno.Items.Add(aluno);
            }

            // Preencha a combobox com os Alunos
            foreach (var disciplinas in listaDisciplinas)
            {
                cbxDirNotaDisciplina.Items.Add(disciplinas);
            }
        }

        //método que limpa os campos da aba Notas
        public void LimparCamposNotas()
        {
            txtDirNotaId.Text = string.Empty;
            cbxDirNotaAluno.Text = string.Empty;
            cbxDirNotaDisciplina.Text = string.Empty;
            dtpDirNotaData.Value = DateTime.Now;
            txtDirNotaNota.Text = string.Empty;
            ckxDirNotasFiltrarNotaNegativa.Checked = false;
            ckxDirNotasFiltrarNotaPositiva.Checked = false;
        }

        //método que ao selecionar uma linha na dgv e preenche os respectivos campos
        private void dgvDirNotas_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvDirNotas.SelectedRows.Count > 0)
            {
                // Obtem a linha selecionada
                DataGridViewRow selectedRow = dgvDirNotas.SelectedRows[0];

                // Preenche os campos do formulário com os dados da linha selecionada
                txtDirNotaId.Text = selectedRow.Cells["IdNota"].Value.ToString();
                txtDirNotaNota.Text = selectedRow.Cells["ValorNota"].Value.ToString();
                dtpDirNotaData.Value = Convert.ToDateTime(selectedRow.Cells["DataAtribuicao"].Value);

                // guarda na variavel o valor da celula selecionada 
                var valorAlunoSelecionado = selectedRow.Cells["AlunoId"].Value.ToString();
                var valorDisciplinaSelecionada = selectedRow.Cells["DisciplinaId"].Value.ToString();

                //chama o método que procura o valor selecionado dentro  da lista dele e aplica o valor do inx no value member
                SelectItemByValue(cbxDirNotaAluno, valorAlunoSelecionado);
                SelectItemByValue(cbxDirNotaDisciplina, valorDisciplinaSelecionada);
            }
        }

        //método que adiciona uma nota
        private void btnDirNotasAdicionar_Click(object sender, EventArgs e)
        {
            Aluno aluno = (Aluno)cbxDirNotaAluno.SelectedItem;
            Disciplina disciplina = (Disciplina)cbxDirNotaDisciplina.SelectedItem;
            DateTime dataAtribuicao = dtpDirNotaData.Value;
            decimal nota = Convert.ToDecimal(txtDirNotaNota.Text);

            notaService.salvarNota(aluno.IdAluno, disciplina.IdDisciplina, dataAtribuicao, nota);

            dgvDirNotas.DataSource = notaService.buscarNotas();

            LimparCamposNotas();
        }

        //método que atualiza uma nota
        private void btnDirNotasAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirNotaId.Text);
            Aluno aluno = (Aluno)cbxDirNotaAluno.SelectedItem;
            Disciplina disciplina = (Disciplina)cbxDirNotaDisciplina.SelectedItem;
            DateTime dataAtribuicao = dtpDirNotaData.Value;
            decimal nota = Convert.ToDecimal(txtDirNotaNota.Text);

            notaService.atualizarNota(id, aluno.IdAluno, disciplina.IdDisciplina, dataAtribuicao, nota);

            dgvDirNotas.DataSource = notaService.buscarNotas();

            LimparCamposNotas();
        }

        //método que remove uma nota
        private void btnDirNotasRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDirNotaId.Text);
            Aluno aluno = (Aluno)cbxDirNotaAluno.SelectedItem;
            Disciplina disciplina = (Disciplina)cbxDirNotaDisciplina.SelectedItem;
            DateTime dataAtribuicao = dtpDirNotaData.Value;
            decimal nota = Convert.ToDecimal(txtDirNotaNota.Text);

            notaService.removerNota(id, aluno.IdAluno, disciplina.IdDisciplina, dataAtribuicao, nota);

            dgvDirNotas.DataSource = notaService.buscarNotas();

            LimparCamposNotas();
        }

        //método que filtra as notas em positivas ou negativas
        private void FiltrarNotas()
        {
            // Obter a lista de notas
            List<Nota> listaNotas = null;

            if (ckxDirNotasFiltrarNotaPositiva.Checked && !ckxDirNotasFiltrarNotaNegativa.Checked)
            {
                listaNotas = notaService.FiltrarNotasPositivas();
            }
            else if (ckxDirNotasFiltrarNotaNegativa.Checked && !ckxDirNotasFiltrarNotaPositiva.Checked)
            {
                listaNotas = notaService.FiltrarNotasNegativas();
            } else 
            {
                listaNotas = notaService.buscarNotas();
            }

            // Atualizar a fonte de dados do DataGridView
            dgvDirNotas.DataSource = listaNotas;
        }

        private void ckxDirNotasFiltrarNotaNegativa_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarNotas();
        }

        private void ckxDirNotasFiltrarNotaPositiva_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarNotas();
        }

        //método do botão limpar que limpa os campos
        private void btnDirNotasLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposNotas();
        }
    }
}
