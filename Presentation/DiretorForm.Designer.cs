namespace projeto_form_camila.Presentation
{
    partial class DiretorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            tabCDiretor = new TabControl();
            tabPLogins = new TabPage();
            btnDirLoginsLimpar = new Button();
            gpbDirLoginsFiltrarCargo = new GroupBox();
            cbxDirLoginsFiltrarCargo = new ComboBox();
            btnDirLoginsRemover = new Button();
            btnDirLoginsAtualizar = new Button();
            btnDirLoginsAdicionar = new Button();
            cbxDirLoginsRole = new ComboBox();
            lblDirLoginsRole = new Label();
            txtDirLoginsPassword = new TextBox();
            lblDirLoginsPassword = new Label();
            txtDirLoginsUser = new TextBox();
            lblDirLoginsUser = new Label();
            txtDirLoginsId = new TextBox();
            lblDirLoginsId = new Label();
            dgvDirLogins = new DataGridView();
            tabPFuncionarios = new TabPage();
            btnDirFuncionariosLimpar = new Button();
            gpbDirFuncionariosFiltrarCargo = new GroupBox();
            cbxDirFuncionariosFiltrarCargo = new ComboBox();
            btnDirFuncionariosRemover = new Button();
            btnDirFuncionariosAtualizar = new Button();
            btnDirFuncionariosAdicionar = new Button();
            cbxDirFuncionariosLogin = new ComboBox();
            lblDirFuncionarioLogin = new Label();
            txtDirFuncionarioNome = new TextBox();
            lblDirFuncionarioNome = new Label();
            txtDirFuncionarioId = new TextBox();
            lblDirFuncionarioId = new Label();
            dgvDirFuncionarios = new DataGridView();
            tabPAlunos = new TabPage();
            btnDirAlunosLimpar = new Button();
            gpbDirAlunosFiltrarTurma = new GroupBox();
            ckbDirAlunos4Ano = new CheckBox();
            ckbDirAlunos3Ano = new CheckBox();
            ckbDirAlunos2Ano = new CheckBox();
            ckbDirAlunos1Ano = new CheckBox();
            btnDirAlunosRemover = new Button();
            btnDirAlunosAtualizar = new Button();
            btnDirAlunosAdicionar = new Button();
            cbxDirAlunosLoginId = new ComboBox();
            cbxDirAlunosTurma = new ComboBox();
            lblDirAlunosLogin = new Label();
            lblDirAlunosTurma = new Label();
            txtDirAlunosEmail = new TextBox();
            lblDirAlunosEmail = new Label();
            txtDirAlunosIdade = new TextBox();
            lblDirAlunosIdade = new Label();
            txtDirAlunosApelido = new TextBox();
            lblDirAlunosApelido = new Label();
            txtDirAlunosNome = new TextBox();
            lblDirAlunosNome = new Label();
            txtDirAlunosId = new TextBox();
            lblDirAlunosId = new Label();
            dgvDirAlunos = new DataGridView();
            tabPTurmas = new TabPage();
            btnDirTurmasLimpar = new Button();
            btnDirTurmasRemover = new Button();
            btnDirTurmasAtualizar = new Button();
            btnDirTurmasAdicionar = new Button();
            cbxDirTurmasProfessorId = new ComboBox();
            lblDirTurmasProfessorId = new Label();
            txtDirTurmasDesignacao = new TextBox();
            lblDirTurmasDesignacao = new Label();
            txtDirTurmasId = new TextBox();
            lblDirTurmasId = new Label();
            dgvDirTurmas = new DataGridView();
            tabPDisciplinas = new TabPage();
            btnDirDisciplinasLimpar = new Button();
            btnDirDisciplinaRemover = new Button();
            btnDirDisciplinaAtualizar = new Button();
            btnDirDisciplinaAdicionar = new Button();
            txtDirDisciplinaDesignacao = new TextBox();
            lblDirDisciplinaDesignacao = new Label();
            txtDirDisciplinaId = new TextBox();
            lblDirDisciplinaId = new Label();
            dgvDirDisciplinas = new DataGridView();
            tabPNotas = new TabPage();
            btnDirNotasLimpar = new Button();
            dtpDirNotaData = new DateTimePicker();
            gpbDirNotasFiltrarNota = new GroupBox();
            ckxDirNotasFiltrarNotaPositiva = new CheckBox();
            ckxDirNotasFiltrarNotaNegativa = new CheckBox();
            btnDirNotasRemover = new Button();
            btnDirNotasAtualizar = new Button();
            btnDirNotasAdicionar = new Button();
            cbxDirNotaDisciplina = new ComboBox();
            cbxDirNotaAluno = new ComboBox();
            txtDirNotaNota = new TextBox();
            lblDirNotaNota = new Label();
            lblDirNotaData = new Label();
            lblDirNotaDisciplina = new Label();
            lblDirNotaAluno = new Label();
            txtDirNotaId = new TextBox();
            lblDirNotaId = new Label();
            dgvDirNotas = new DataGridView();
            tabCDiretor.SuspendLayout();
            tabPLogins.SuspendLayout();
            gpbDirLoginsFiltrarCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirLogins).BeginInit();
            tabPFuncionarios.SuspendLayout();
            gpbDirFuncionariosFiltrarCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirFuncionarios).BeginInit();
            tabPAlunos.SuspendLayout();
            gpbDirAlunosFiltrarTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirAlunos).BeginInit();
            tabPTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirTurmas).BeginInit();
            tabPDisciplinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirDisciplinas).BeginInit();
            tabPNotas.SuspendLayout();
            gpbDirNotasFiltrarNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirNotas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(641, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(485, 55);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Formulário do Diretor";
            // 
            // tabCDiretor
            // 
            tabCDiretor.Controls.Add(tabPLogins);
            tabCDiretor.Controls.Add(tabPFuncionarios);
            tabCDiretor.Controls.Add(tabPAlunos);
            tabCDiretor.Controls.Add(tabPTurmas);
            tabCDiretor.Controls.Add(tabPDisciplinas);
            tabCDiretor.Controls.Add(tabPNotas);
            tabCDiretor.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCDiretor.Location = new Point(7, 79);
            tabCDiretor.Name = "tabCDiretor";
            tabCDiretor.SelectedIndex = 0;
            tabCDiretor.Size = new Size(1912, 1140);
            tabCDiretor.TabIndex = 3;
            // 
            // tabPLogins
            // 
            tabPLogins.Controls.Add(btnDirLoginsLimpar);
            tabPLogins.Controls.Add(gpbDirLoginsFiltrarCargo);
            tabPLogins.Controls.Add(btnDirLoginsRemover);
            tabPLogins.Controls.Add(btnDirLoginsAtualizar);
            tabPLogins.Controls.Add(btnDirLoginsAdicionar);
            tabPLogins.Controls.Add(cbxDirLoginsRole);
            tabPLogins.Controls.Add(lblDirLoginsRole);
            tabPLogins.Controls.Add(txtDirLoginsPassword);
            tabPLogins.Controls.Add(lblDirLoginsPassword);
            tabPLogins.Controls.Add(txtDirLoginsUser);
            tabPLogins.Controls.Add(lblDirLoginsUser);
            tabPLogins.Controls.Add(txtDirLoginsId);
            tabPLogins.Controls.Add(lblDirLoginsId);
            tabPLogins.Controls.Add(dgvDirLogins);
            tabPLogins.Location = new Point(8, 50);
            tabPLogins.Name = "tabPLogins";
            tabPLogins.Padding = new Padding(3);
            tabPLogins.Size = new Size(1896, 1082);
            tabPLogins.TabIndex = 0;
            tabPLogins.Text = "        Logins        ";
            tabPLogins.UseVisualStyleBackColor = true;
            // 
            // btnDirLoginsLimpar
            // 
            btnDirLoginsLimpar.Location = new Point(58, 827);
            btnDirLoginsLimpar.Name = "btnDirLoginsLimpar";
            btnDirLoginsLimpar.Size = new Size(326, 46);
            btnDirLoginsLimpar.TabIndex = 58;
            btnDirLoginsLimpar.Text = "Limpar";
            btnDirLoginsLimpar.UseVisualStyleBackColor = true;
            btnDirLoginsLimpar.Click += btnDirLoginsLimpar_Click;
            // 
            // gpbDirLoginsFiltrarCargo
            // 
            gpbDirLoginsFiltrarCargo.Controls.Add(cbxDirLoginsFiltrarCargo);
            gpbDirLoginsFiltrarCargo.Location = new Point(948, 881);
            gpbDirLoginsFiltrarCargo.Name = "gpbDirLoginsFiltrarCargo";
            gpbDirLoginsFiltrarCargo.Size = new Size(460, 200);
            gpbDirLoginsFiltrarCargo.TabIndex = 57;
            gpbDirLoginsFiltrarCargo.TabStop = false;
            gpbDirLoginsFiltrarCargo.Text = "Filtrar por Cargo";
            // 
            // cbxDirLoginsFiltrarCargo
            // 
            cbxDirLoginsFiltrarCargo.FormattingEnabled = true;
            cbxDirLoginsFiltrarCargo.Location = new Point(37, 88);
            cbxDirLoginsFiltrarCargo.Name = "cbxDirLoginsFiltrarCargo";
            cbxDirLoginsFiltrarCargo.Size = new Size(397, 44);
            cbxDirLoginsFiltrarCargo.TabIndex = 31;
            cbxDirLoginsFiltrarCargo.SelectedIndexChanged += cbxDirLoginsFiltrarCargo_SelectedIndexChanged;
            // 
            // btnDirLoginsRemover
            // 
            btnDirLoginsRemover.Location = new Point(58, 1018);
            btnDirLoginsRemover.Name = "btnDirLoginsRemover";
            btnDirLoginsRemover.Size = new Size(326, 46);
            btnDirLoginsRemover.TabIndex = 55;
            btnDirLoginsRemover.Text = "Remover";
            btnDirLoginsRemover.UseVisualStyleBackColor = true;
            btnDirLoginsRemover.Click += btnDirLoginsRemover_Click;
            // 
            // btnDirLoginsAtualizar
            // 
            btnDirLoginsAtualizar.Location = new Point(58, 953);
            btnDirLoginsAtualizar.Name = "btnDirLoginsAtualizar";
            btnDirLoginsAtualizar.Size = new Size(326, 46);
            btnDirLoginsAtualizar.TabIndex = 54;
            btnDirLoginsAtualizar.Text = "Atualizar";
            btnDirLoginsAtualizar.UseVisualStyleBackColor = true;
            btnDirLoginsAtualizar.Click += btnDirLoginsAtualizar_Click;
            // 
            // btnDirLoginsAdicionar
            // 
            btnDirLoginsAdicionar.Location = new Point(58, 892);
            btnDirLoginsAdicionar.Name = "btnDirLoginsAdicionar";
            btnDirLoginsAdicionar.Size = new Size(326, 46);
            btnDirLoginsAdicionar.TabIndex = 53;
            btnDirLoginsAdicionar.Text = "Adicionar";
            btnDirLoginsAdicionar.UseVisualStyleBackColor = true;
            btnDirLoginsAdicionar.Click += btnDirLoginsAdicionar_Click;
            // 
            // cbxDirLoginsRole
            // 
            cbxDirLoginsRole.FormattingEnabled = true;
            cbxDirLoginsRole.Location = new Point(12, 462);
            cbxDirLoginsRole.Name = "cbxDirLoginsRole";
            cbxDirLoginsRole.Size = new Size(432, 44);
            cbxDirLoginsRole.TabIndex = 51;
            // 
            // lblDirLoginsRole
            // 
            lblDirLoginsRole.AutoSize = true;
            lblDirLoginsRole.Location = new Point(12, 395);
            lblDirLoginsRole.Name = "lblDirLoginsRole";
            lblDirLoginsRole.Size = new Size(100, 36);
            lblDirLoginsRole.TabIndex = 45;
            lblDirLoginsRole.Text = "Cargo";
            // 
            // txtDirLoginsPassword
            // 
            txtDirLoginsPassword.Location = new Point(12, 325);
            txtDirLoginsPassword.Name = "txtDirLoginsPassword";
            txtDirLoginsPassword.Size = new Size(432, 44);
            txtDirLoginsPassword.TabIndex = 44;
            // 
            // lblDirLoginsPassword
            // 
            lblDirLoginsPassword.AutoSize = true;
            lblDirLoginsPassword.Location = new Point(12, 275);
            lblDirLoginsPassword.Name = "lblDirLoginsPassword";
            lblDirLoginsPassword.Size = new Size(146, 36);
            lblDirLoginsPassword.TabIndex = 43;
            lblDirLoginsPassword.Text = "Password";
            // 
            // txtDirLoginsUser
            // 
            txtDirLoginsUser.Location = new Point(12, 202);
            txtDirLoginsUser.Name = "txtDirLoginsUser";
            txtDirLoginsUser.Size = new Size(432, 44);
            txtDirLoginsUser.TabIndex = 42;
            // 
            // lblDirLoginsUser
            // 
            lblDirLoginsUser.AutoSize = true;
            lblDirLoginsUser.Location = new Point(12, 151);
            lblDirLoginsUser.Name = "lblDirLoginsUser";
            lblDirLoginsUser.Size = new Size(147, 36);
            lblDirLoginsUser.TabIndex = 41;
            lblDirLoginsUser.Text = "Usersame";
            // 
            // txtDirLoginsId
            // 
            txtDirLoginsId.Location = new Point(12, 76);
            txtDirLoginsId.Name = "txtDirLoginsId";
            txtDirLoginsId.ReadOnly = true;
            txtDirLoginsId.Size = new Size(432, 44);
            txtDirLoginsId.TabIndex = 40;
            // 
            // lblDirLoginsId
            // 
            lblDirLoginsId.AutoSize = true;
            lblDirLoginsId.Location = new Point(12, 22);
            lblDirLoginsId.Name = "lblDirLoginsId";
            lblDirLoginsId.Size = new Size(154, 36);
            lblDirLoginsId.TabIndex = 39;
            lblDirLoginsId.Text = "Id (Login)";
            // 
            // dgvDirLogins
            // 
            dgvDirLogins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirLogins.Location = new Point(471, 2);
            dgvDirLogins.Name = "dgvDirLogins";
            dgvDirLogins.RowHeadersWidth = 82;
            dgvDirLogins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirLogins.Size = new Size(1413, 871);
            dgvDirLogins.TabIndex = 38;
            dgvDirLogins.SelectionChanged += dgvDirLogins_SelectionChanged;
            // 
            // tabPFuncionarios
            // 
            tabPFuncionarios.Controls.Add(btnDirFuncionariosLimpar);
            tabPFuncionarios.Controls.Add(gpbDirFuncionariosFiltrarCargo);
            tabPFuncionarios.Controls.Add(btnDirFuncionariosRemover);
            tabPFuncionarios.Controls.Add(btnDirFuncionariosAtualizar);
            tabPFuncionarios.Controls.Add(btnDirFuncionariosAdicionar);
            tabPFuncionarios.Controls.Add(cbxDirFuncionariosLogin);
            tabPFuncionarios.Controls.Add(lblDirFuncionarioLogin);
            tabPFuncionarios.Controls.Add(txtDirFuncionarioNome);
            tabPFuncionarios.Controls.Add(lblDirFuncionarioNome);
            tabPFuncionarios.Controls.Add(txtDirFuncionarioId);
            tabPFuncionarios.Controls.Add(lblDirFuncionarioId);
            tabPFuncionarios.Controls.Add(dgvDirFuncionarios);
            tabPFuncionarios.Location = new Point(8, 50);
            tabPFuncionarios.Name = "tabPFuncionarios";
            tabPFuncionarios.Size = new Size(1896, 1082);
            tabPFuncionarios.TabIndex = 1;
            tabPFuncionarios.Text = "        Funcionários        ";
            tabPFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnDirFuncionariosLimpar
            // 
            btnDirFuncionariosLimpar.Location = new Point(58, 827);
            btnDirFuncionariosLimpar.Name = "btnDirFuncionariosLimpar";
            btnDirFuncionariosLimpar.Size = new Size(326, 46);
            btnDirFuncionariosLimpar.TabIndex = 59;
            btnDirFuncionariosLimpar.Text = "Limpar";
            btnDirFuncionariosLimpar.UseVisualStyleBackColor = true;
            btnDirFuncionariosLimpar.Click += btnDirFuncionariosLimpar_Click;
            // 
            // gpbDirFuncionariosFiltrarCargo
            // 
            gpbDirFuncionariosFiltrarCargo.Controls.Add(cbxDirFuncionariosFiltrarCargo);
            gpbDirFuncionariosFiltrarCargo.Location = new Point(948, 881);
            gpbDirFuncionariosFiltrarCargo.Name = "gpbDirFuncionariosFiltrarCargo";
            gpbDirFuncionariosFiltrarCargo.Size = new Size(460, 200);
            gpbDirFuncionariosFiltrarCargo.TabIndex = 57;
            gpbDirFuncionariosFiltrarCargo.TabStop = false;
            gpbDirFuncionariosFiltrarCargo.Text = "Filtrar por Cargo";
            // 
            // cbxDirFuncionariosFiltrarCargo
            // 
            cbxDirFuncionariosFiltrarCargo.FormattingEnabled = true;
            cbxDirFuncionariosFiltrarCargo.Location = new Point(32, 74);
            cbxDirFuncionariosFiltrarCargo.Name = "cbxDirFuncionariosFiltrarCargo";
            cbxDirFuncionariosFiltrarCargo.Size = new Size(397, 44);
            cbxDirFuncionariosFiltrarCargo.TabIndex = 31;
            cbxDirFuncionariosFiltrarCargo.SelectedIndexChanged += cbxDirFuncionariosFiltrarCargo_SelectedIndexChanged;
            // 
            // btnDirFuncionariosRemover
            // 
            btnDirFuncionariosRemover.Location = new Point(58, 1018);
            btnDirFuncionariosRemover.Name = "btnDirFuncionariosRemover";
            btnDirFuncionariosRemover.Size = new Size(326, 46);
            btnDirFuncionariosRemover.TabIndex = 55;
            btnDirFuncionariosRemover.Text = "Remover";
            btnDirFuncionariosRemover.UseVisualStyleBackColor = true;
            btnDirFuncionariosRemover.Click += btnDirFuncionariosRemover_Click;
            // 
            // btnDirFuncionariosAtualizar
            // 
            btnDirFuncionariosAtualizar.Location = new Point(58, 953);
            btnDirFuncionariosAtualizar.Name = "btnDirFuncionariosAtualizar";
            btnDirFuncionariosAtualizar.Size = new Size(326, 46);
            btnDirFuncionariosAtualizar.TabIndex = 54;
            btnDirFuncionariosAtualizar.Text = "Atualizar";
            btnDirFuncionariosAtualizar.UseVisualStyleBackColor = true;
            btnDirFuncionariosAtualizar.Click += btnDirFuncionariosAtualizar_Click;
            // 
            // btnDirFuncionariosAdicionar
            // 
            btnDirFuncionariosAdicionar.Location = new Point(58, 892);
            btnDirFuncionariosAdicionar.Name = "btnDirFuncionariosAdicionar";
            btnDirFuncionariosAdicionar.Size = new Size(326, 46);
            btnDirFuncionariosAdicionar.TabIndex = 53;
            btnDirFuncionariosAdicionar.Text = "Adicionar";
            btnDirFuncionariosAdicionar.UseVisualStyleBackColor = true;
            btnDirFuncionariosAdicionar.Click += btnDirFuncionariosAdicionar_Click;
            // 
            // cbxDirFuncionariosLogin
            // 
            cbxDirFuncionariosLogin.FormattingEnabled = true;
            cbxDirFuncionariosLogin.Location = new Point(12, 335);
            cbxDirFuncionariosLogin.Name = "cbxDirFuncionariosLogin";
            cbxDirFuncionariosLogin.Size = new Size(432, 44);
            cbxDirFuncionariosLogin.TabIndex = 51;
            // 
            // lblDirFuncionarioLogin
            // 
            lblDirFuncionarioLogin.AutoSize = true;
            lblDirFuncionarioLogin.Location = new Point(12, 275);
            lblDirFuncionarioLogin.Name = "lblDirFuncionarioLogin";
            lblDirFuncionarioLogin.Size = new Size(95, 36);
            lblDirFuncionarioLogin.TabIndex = 43;
            lblDirFuncionarioLogin.Text = "Login";
            // 
            // txtDirFuncionarioNome
            // 
            txtDirFuncionarioNome.Location = new Point(12, 202);
            txtDirFuncionarioNome.Name = "txtDirFuncionarioNome";
            txtDirFuncionarioNome.Size = new Size(432, 44);
            txtDirFuncionarioNome.TabIndex = 42;
            // 
            // lblDirFuncionarioNome
            // 
            lblDirFuncionarioNome.AutoSize = true;
            lblDirFuncionarioNome.Location = new Point(12, 151);
            lblDirFuncionarioNome.Name = "lblDirFuncionarioNome";
            lblDirFuncionarioNome.Size = new Size(293, 36);
            lblDirFuncionarioNome.TabIndex = 41;
            lblDirFuncionarioNome.Text = "Nome (Funcionario)";
            // 
            // txtDirFuncionarioId
            // 
            txtDirFuncionarioId.Location = new Point(12, 76);
            txtDirFuncionarioId.Name = "txtDirFuncionarioId";
            txtDirFuncionarioId.ReadOnly = true;
            txtDirFuncionarioId.Size = new Size(432, 44);
            txtDirFuncionarioId.TabIndex = 40;
            // 
            // lblDirFuncionarioId
            // 
            lblDirFuncionarioId.AutoSize = true;
            lblDirFuncionarioId.Location = new Point(12, 22);
            lblDirFuncionarioId.Name = "lblDirFuncionarioId";
            lblDirFuncionarioId.Size = new Size(242, 36);
            lblDirFuncionarioId.TabIndex = 39;
            lblDirFuncionarioId.Text = "Id (Funcionário)";
            // 
            // dgvDirFuncionarios
            // 
            dgvDirFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirFuncionarios.Location = new Point(471, 2);
            dgvDirFuncionarios.Name = "dgvDirFuncionarios";
            dgvDirFuncionarios.RowHeadersWidth = 82;
            dgvDirFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirFuncionarios.Size = new Size(1413, 871);
            dgvDirFuncionarios.TabIndex = 38;
            dgvDirFuncionarios.SelectionChanged += dgvDirFuncionarios_SelectionChanged;
            // 
            // tabPAlunos
            // 
            tabPAlunos.Controls.Add(btnDirAlunosLimpar);
            tabPAlunos.Controls.Add(gpbDirAlunosFiltrarTurma);
            tabPAlunos.Controls.Add(btnDirAlunosRemover);
            tabPAlunos.Controls.Add(btnDirAlunosAtualizar);
            tabPAlunos.Controls.Add(btnDirAlunosAdicionar);
            tabPAlunos.Controls.Add(cbxDirAlunosLoginId);
            tabPAlunos.Controls.Add(cbxDirAlunosTurma);
            tabPAlunos.Controls.Add(lblDirAlunosLogin);
            tabPAlunos.Controls.Add(lblDirAlunosTurma);
            tabPAlunos.Controls.Add(txtDirAlunosEmail);
            tabPAlunos.Controls.Add(lblDirAlunosEmail);
            tabPAlunos.Controls.Add(txtDirAlunosIdade);
            tabPAlunos.Controls.Add(lblDirAlunosIdade);
            tabPAlunos.Controls.Add(txtDirAlunosApelido);
            tabPAlunos.Controls.Add(lblDirAlunosApelido);
            tabPAlunos.Controls.Add(txtDirAlunosNome);
            tabPAlunos.Controls.Add(lblDirAlunosNome);
            tabPAlunos.Controls.Add(txtDirAlunosId);
            tabPAlunos.Controls.Add(lblDirAlunosId);
            tabPAlunos.Controls.Add(dgvDirAlunos);
            tabPAlunos.Location = new Point(8, 50);
            tabPAlunos.Name = "tabPAlunos";
            tabPAlunos.Size = new Size(1896, 1082);
            tabPAlunos.TabIndex = 2;
            tabPAlunos.Text = "        Alunos            ";
            tabPAlunos.UseVisualStyleBackColor = true;
            // 
            // btnDirAlunosLimpar
            // 
            btnDirAlunosLimpar.Location = new Point(70, 837);
            btnDirAlunosLimpar.Name = "btnDirAlunosLimpar";
            btnDirAlunosLimpar.Size = new Size(326, 46);
            btnDirAlunosLimpar.TabIndex = 37;
            btnDirAlunosLimpar.Text = "Limpar";
            btnDirAlunosLimpar.UseVisualStyleBackColor = true;
            btnDirAlunosLimpar.Click += btnDirAlunosLimpar_Click;
            // 
            // gpbDirAlunosFiltrarTurma
            // 
            gpbDirAlunosFiltrarTurma.Controls.Add(ckbDirAlunos4Ano);
            gpbDirAlunosFiltrarTurma.Controls.Add(ckbDirAlunos3Ano);
            gpbDirAlunosFiltrarTurma.Controls.Add(ckbDirAlunos2Ano);
            gpbDirAlunosFiltrarTurma.Controls.Add(ckbDirAlunos1Ano);
            gpbDirAlunosFiltrarTurma.Location = new Point(977, 879);
            gpbDirAlunosFiltrarTurma.Name = "gpbDirAlunosFiltrarTurma";
            gpbDirAlunosFiltrarTurma.Size = new Size(460, 200);
            gpbDirAlunosFiltrarTurma.TabIndex = 35;
            gpbDirAlunosFiltrarTurma.TabStop = false;
            gpbDirAlunosFiltrarTurma.Text = "Filtrar por Turma";
            // 
            // ckbDirAlunos4Ano
            // 
            ckbDirAlunos4Ano.AutoSize = true;
            ckbDirAlunos4Ano.Location = new Point(260, 126);
            ckbDirAlunos4Ano.Name = "ckbDirAlunos4Ano";
            ckbDirAlunos4Ano.Size = new Size(137, 40);
            ckbDirAlunos4Ano.TabIndex = 3;
            ckbDirAlunos4Ano.Text = "4º Ano";
            ckbDirAlunos4Ano.UseVisualStyleBackColor = true;
            ckbDirAlunos4Ano.CheckedChanged += ckbDirAlunos4Ano_CheckedChanged;
            // 
            // ckbDirAlunos3Ano
            // 
            ckbDirAlunos3Ano.AutoSize = true;
            ckbDirAlunos3Ano.Location = new Point(260, 63);
            ckbDirAlunos3Ano.Name = "ckbDirAlunos3Ano";
            ckbDirAlunos3Ano.Size = new Size(137, 40);
            ckbDirAlunos3Ano.TabIndex = 2;
            ckbDirAlunos3Ano.Text = "3º Ano";
            ckbDirAlunos3Ano.UseVisualStyleBackColor = true;
            ckbDirAlunos3Ano.CheckedChanged += ckbDirAlunos3Ano_CheckedChanged;
            // 
            // ckbDirAlunos2Ano
            // 
            ckbDirAlunos2Ano.AutoSize = true;
            ckbDirAlunos2Ano.Location = new Point(33, 126);
            ckbDirAlunos2Ano.Name = "ckbDirAlunos2Ano";
            ckbDirAlunos2Ano.Size = new Size(137, 40);
            ckbDirAlunos2Ano.TabIndex = 1;
            ckbDirAlunos2Ano.Text = "2º Ano";
            ckbDirAlunos2Ano.UseVisualStyleBackColor = true;
            ckbDirAlunos2Ano.CheckedChanged += ckbDirAlunos2Ano_CheckedChanged;
            // 
            // ckbDirAlunos1Ano
            // 
            ckbDirAlunos1Ano.AutoSize = true;
            ckbDirAlunos1Ano.Location = new Point(33, 63);
            ckbDirAlunos1Ano.Name = "ckbDirAlunos1Ano";
            ckbDirAlunos1Ano.Size = new Size(137, 40);
            ckbDirAlunos1Ano.TabIndex = 0;
            ckbDirAlunos1Ano.Text = "1º Ano";
            ckbDirAlunos1Ano.UseVisualStyleBackColor = true;
            ckbDirAlunos1Ano.CheckedChanged += ckbDirAlunos1Ano_CheckedChanged;
            // 
            // btnDirAlunosRemover
            // 
            btnDirAlunosRemover.Location = new Point(70, 1024);
            btnDirAlunosRemover.Name = "btnDirAlunosRemover";
            btnDirAlunosRemover.Size = new Size(326, 46);
            btnDirAlunosRemover.TabIndex = 34;
            btnDirAlunosRemover.Text = "Remover";
            btnDirAlunosRemover.UseVisualStyleBackColor = true;
            btnDirAlunosRemover.Click += btnDirAlunosRemover_Click;
            // 
            // btnDirAlunosAtualizar
            // 
            btnDirAlunosAtualizar.Location = new Point(70, 959);
            btnDirAlunosAtualizar.Name = "btnDirAlunosAtualizar";
            btnDirAlunosAtualizar.Size = new Size(326, 46);
            btnDirAlunosAtualizar.TabIndex = 33;
            btnDirAlunosAtualizar.Text = "Atualizar";
            btnDirAlunosAtualizar.UseVisualStyleBackColor = true;
            btnDirAlunosAtualizar.Click += btnDirAlunosAtualizar_Click;
            // 
            // btnDirAlunosAdicionar
            // 
            btnDirAlunosAdicionar.Location = new Point(70, 898);
            btnDirAlunosAdicionar.Name = "btnDirAlunosAdicionar";
            btnDirAlunosAdicionar.Size = new Size(326, 46);
            btnDirAlunosAdicionar.TabIndex = 32;
            btnDirAlunosAdicionar.Text = "Adicionar";
            btnDirAlunosAdicionar.UseVisualStyleBackColor = true;
            btnDirAlunosAdicionar.Click += btnDirAlunosAdicionar_Click;
            // 
            // cbxDirAlunosLoginId
            // 
            cbxDirAlunosLoginId.FormattingEnabled = true;
            cbxDirAlunosLoginId.Location = new Point(21, 744);
            cbxDirAlunosLoginId.Name = "cbxDirAlunosLoginId";
            cbxDirAlunosLoginId.Size = new Size(432, 44);
            cbxDirAlunosLoginId.TabIndex = 31;
            // 
            // cbxDirAlunosTurma
            // 
            cbxDirAlunosTurma.FormattingEnabled = true;
            cbxDirAlunosTurma.Location = new Point(21, 630);
            cbxDirAlunosTurma.Name = "cbxDirAlunosTurma";
            cbxDirAlunosTurma.Size = new Size(432, 44);
            cbxDirAlunosTurma.TabIndex = 30;
            // 
            // lblDirAlunosLogin
            // 
            lblDirAlunosLogin.AutoSize = true;
            lblDirAlunosLogin.Location = new Point(21, 695);
            lblDirAlunosLogin.Name = "lblDirAlunosLogin";
            lblDirAlunosLogin.Size = new Size(132, 36);
            lblDirAlunosLogin.TabIndex = 28;
            lblDirAlunosLogin.Text = "Login Id";
            // 
            // lblDirAlunosTurma
            // 
            lblDirAlunosTurma.AutoSize = true;
            lblDirAlunosTurma.Location = new Point(21, 591);
            lblDirAlunosTurma.Name = "lblDirAlunosTurma";
            lblDirAlunosTurma.Size = new Size(120, 36);
            lblDirAlunosTurma.TabIndex = 26;
            lblDirAlunosTurma.Text = "Turmas";
            // 
            // txtDirAlunosEmail
            // 
            txtDirAlunosEmail.Location = new Point(21, 526);
            txtDirAlunosEmail.Name = "txtDirAlunosEmail";
            txtDirAlunosEmail.Size = new Size(432, 44);
            txtDirAlunosEmail.TabIndex = 25;
            // 
            // lblDirAlunosEmail
            // 
            lblDirAlunosEmail.AutoSize = true;
            lblDirAlunosEmail.Location = new Point(21, 487);
            lblDirAlunosEmail.Name = "lblDirAlunosEmail";
            lblDirAlunosEmail.Size = new Size(97, 36);
            lblDirAlunosEmail.TabIndex = 24;
            lblDirAlunosEmail.Text = "Email";
            // 
            // txtDirAlunosIdade
            // 
            txtDirAlunosIdade.Location = new Point(21, 421);
            txtDirAlunosIdade.Name = "txtDirAlunosIdade";
            txtDirAlunosIdade.Size = new Size(432, 44);
            txtDirAlunosIdade.TabIndex = 23;
            // 
            // lblDirAlunosIdade
            // 
            lblDirAlunosIdade.AutoSize = true;
            lblDirAlunosIdade.Location = new Point(21, 372);
            lblDirAlunosIdade.Name = "lblDirAlunosIdade";
            lblDirAlunosIdade.Size = new Size(92, 36);
            lblDirAlunosIdade.TabIndex = 22;
            lblDirAlunosIdade.Text = "Idade";
            // 
            // txtDirAlunosApelido
            // 
            txtDirAlunosApelido.Location = new Point(21, 303);
            txtDirAlunosApelido.Name = "txtDirAlunosApelido";
            txtDirAlunosApelido.Size = new Size(432, 44);
            txtDirAlunosApelido.TabIndex = 21;
            // 
            // lblDirAlunosApelido
            // 
            lblDirAlunosApelido.AutoSize = true;
            lblDirAlunosApelido.Location = new Point(21, 264);
            lblDirAlunosApelido.Name = "lblDirAlunosApelido";
            lblDirAlunosApelido.Size = new Size(122, 36);
            lblDirAlunosApelido.TabIndex = 20;
            lblDirAlunosApelido.Text = "Apelido";
            // 
            // txtDirAlunosNome
            // 
            txtDirAlunosNome.Location = new Point(21, 195);
            txtDirAlunosNome.Name = "txtDirAlunosNome";
            txtDirAlunosNome.Size = new Size(432, 44);
            txtDirAlunosNome.TabIndex = 19;
            // 
            // lblDirAlunosNome
            // 
            lblDirAlunosNome.AutoSize = true;
            lblDirAlunosNome.Location = new Point(21, 147);
            lblDirAlunosNome.Name = "lblDirAlunosNome";
            lblDirAlunosNome.Size = new Size(103, 36);
            lblDirAlunosNome.TabIndex = 18;
            lblDirAlunosNome.Text = "Nome ";
            // 
            // txtDirAlunosId
            // 
            txtDirAlunosId.Location = new Point(21, 73);
            txtDirAlunosId.Name = "txtDirAlunosId";
            txtDirAlunosId.ReadOnly = true;
            txtDirAlunosId.Size = new Size(432, 44);
            txtDirAlunosId.TabIndex = 17;
            // 
            // lblDirAlunosId
            // 
            lblDirAlunosId.AutoSize = true;
            lblDirAlunosId.Location = new Point(21, 23);
            lblDirAlunosId.Name = "lblDirAlunosId";
            lblDirAlunosId.Size = new Size(158, 36);
            lblDirAlunosId.TabIndex = 16;
            lblDirAlunosId.Text = "Id (Aluno)";
            // 
            // dgvDirAlunos
            // 
            dgvDirAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirAlunos.Location = new Point(480, 3);
            dgvDirAlunos.Name = "dgvDirAlunos";
            dgvDirAlunos.RowHeadersWidth = 82;
            dgvDirAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirAlunos.Size = new Size(1413, 871);
            dgvDirAlunos.TabIndex = 15;
            dgvDirAlunos.SelectionChanged += dgvDirAlunos_SelectionChanged;
            // 
            // tabPTurmas
            // 
            tabPTurmas.Controls.Add(btnDirTurmasLimpar);
            tabPTurmas.Controls.Add(btnDirTurmasRemover);
            tabPTurmas.Controls.Add(btnDirTurmasAtualizar);
            tabPTurmas.Controls.Add(btnDirTurmasAdicionar);
            tabPTurmas.Controls.Add(cbxDirTurmasProfessorId);
            tabPTurmas.Controls.Add(lblDirTurmasProfessorId);
            tabPTurmas.Controls.Add(txtDirTurmasDesignacao);
            tabPTurmas.Controls.Add(lblDirTurmasDesignacao);
            tabPTurmas.Controls.Add(txtDirTurmasId);
            tabPTurmas.Controls.Add(lblDirTurmasId);
            tabPTurmas.Controls.Add(dgvDirTurmas);
            tabPTurmas.Location = new Point(8, 50);
            tabPTurmas.Name = "tabPTurmas";
            tabPTurmas.Size = new Size(1896, 1082);
            tabPTurmas.TabIndex = 3;
            tabPTurmas.Text = "        Turmas        ";
            tabPTurmas.UseVisualStyleBackColor = true;
            // 
            // btnDirTurmasLimpar
            // 
            btnDirTurmasLimpar.Location = new Point(58, 827);
            btnDirTurmasLimpar.Name = "btnDirTurmasLimpar";
            btnDirTurmasLimpar.Size = new Size(326, 46);
            btnDirTurmasLimpar.TabIndex = 60;
            btnDirTurmasLimpar.Text = "Limpar";
            btnDirTurmasLimpar.UseVisualStyleBackColor = true;
            btnDirTurmasLimpar.Click += btnDirTurmasLimpar_Click;
            // 
            // btnDirTurmasRemover
            // 
            btnDirTurmasRemover.Location = new Point(58, 1018);
            btnDirTurmasRemover.Name = "btnDirTurmasRemover";
            btnDirTurmasRemover.Size = new Size(326, 46);
            btnDirTurmasRemover.TabIndex = 55;
            btnDirTurmasRemover.Text = "Remover";
            btnDirTurmasRemover.UseVisualStyleBackColor = true;
            btnDirTurmasRemover.Click += btnDirTurmasRemover_Click;
            // 
            // btnDirTurmasAtualizar
            // 
            btnDirTurmasAtualizar.Location = new Point(58, 953);
            btnDirTurmasAtualizar.Name = "btnDirTurmasAtualizar";
            btnDirTurmasAtualizar.Size = new Size(326, 46);
            btnDirTurmasAtualizar.TabIndex = 54;
            btnDirTurmasAtualizar.Text = "Atualizar";
            btnDirTurmasAtualizar.UseVisualStyleBackColor = true;
            btnDirTurmasAtualizar.Click += btnDirTurmasAtualizar_Click;
            // 
            // btnDirTurmasAdicionar
            // 
            btnDirTurmasAdicionar.Location = new Point(58, 892);
            btnDirTurmasAdicionar.Name = "btnDirTurmasAdicionar";
            btnDirTurmasAdicionar.Size = new Size(326, 46);
            btnDirTurmasAdicionar.TabIndex = 53;
            btnDirTurmasAdicionar.Text = "Adicionar";
            btnDirTurmasAdicionar.UseVisualStyleBackColor = true;
            btnDirTurmasAdicionar.Click += btnDirTurmasAdicionar_Click;
            // 
            // cbxDirTurmasProfessorId
            // 
            cbxDirTurmasProfessorId.FormattingEnabled = true;
            cbxDirTurmasProfessorId.Location = new Point(12, 335);
            cbxDirTurmasProfessorId.Name = "cbxDirTurmasProfessorId";
            cbxDirTurmasProfessorId.Size = new Size(432, 44);
            cbxDirTurmasProfessorId.TabIndex = 51;
            // 
            // lblDirTurmasProfessorId
            // 
            lblDirTurmasProfessorId.AutoSize = true;
            lblDirTurmasProfessorId.Location = new Point(12, 275);
            lblDirTurmasProfessorId.Name = "lblDirTurmasProfessorId";
            lblDirTurmasProfessorId.Size = new Size(144, 36);
            lblDirTurmasProfessorId.TabIndex = 43;
            lblDirTurmasProfessorId.Text = "Professor";
            // 
            // txtDirTurmasDesignacao
            // 
            txtDirTurmasDesignacao.Location = new Point(12, 202);
            txtDirTurmasDesignacao.Name = "txtDirTurmasDesignacao";
            txtDirTurmasDesignacao.Size = new Size(432, 44);
            txtDirTurmasDesignacao.TabIndex = 42;
            // 
            // lblDirTurmasDesignacao
            // 
            lblDirTurmasDesignacao.AutoSize = true;
            lblDirTurmasDesignacao.Location = new Point(12, 151);
            lblDirTurmasDesignacao.Name = "lblDirTurmasDesignacao";
            lblDirTurmasDesignacao.Size = new Size(300, 36);
            lblDirTurmasDesignacao.TabIndex = 41;
            lblDirTurmasDesignacao.Text = "Designação (Turma) ";
            // 
            // txtDirTurmasId
            // 
            txtDirTurmasId.Location = new Point(12, 76);
            txtDirTurmasId.Name = "txtDirTurmasId";
            txtDirTurmasId.ReadOnly = true;
            txtDirTurmasId.Size = new Size(432, 44);
            txtDirTurmasId.TabIndex = 40;
            // 
            // lblDirTurmasId
            // 
            lblDirTurmasId.AutoSize = true;
            lblDirTurmasId.Location = new Point(12, 22);
            lblDirTurmasId.Name = "lblDirTurmasId";
            lblDirTurmasId.Size = new Size(167, 36);
            lblDirTurmasId.TabIndex = 39;
            lblDirTurmasId.Text = "Id (Turma)";
            // 
            // dgvDirTurmas
            // 
            dgvDirTurmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirTurmas.Location = new Point(471, 2);
            dgvDirTurmas.Name = "dgvDirTurmas";
            dgvDirTurmas.RowHeadersWidth = 82;
            dgvDirTurmas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirTurmas.Size = new Size(1413, 871);
            dgvDirTurmas.TabIndex = 38;
            dgvDirTurmas.SelectionChanged += dgvDirTurmas_SelectionChanged;
            // 
            // tabPDisciplinas
            // 
            tabPDisciplinas.Controls.Add(btnDirDisciplinasLimpar);
            tabPDisciplinas.Controls.Add(btnDirDisciplinaRemover);
            tabPDisciplinas.Controls.Add(btnDirDisciplinaAtualizar);
            tabPDisciplinas.Controls.Add(btnDirDisciplinaAdicionar);
            tabPDisciplinas.Controls.Add(txtDirDisciplinaDesignacao);
            tabPDisciplinas.Controls.Add(lblDirDisciplinaDesignacao);
            tabPDisciplinas.Controls.Add(txtDirDisciplinaId);
            tabPDisciplinas.Controls.Add(lblDirDisciplinaId);
            tabPDisciplinas.Controls.Add(dgvDirDisciplinas);
            tabPDisciplinas.Location = new Point(8, 50);
            tabPDisciplinas.Name = "tabPDisciplinas";
            tabPDisciplinas.Size = new Size(1896, 1082);
            tabPDisciplinas.TabIndex = 4;
            tabPDisciplinas.Text = "        Disciplinas        ";
            tabPDisciplinas.UseVisualStyleBackColor = true;
            // 
            // btnDirDisciplinasLimpar
            // 
            btnDirDisciplinasLimpar.Location = new Point(58, 827);
            btnDirDisciplinasLimpar.Name = "btnDirDisciplinasLimpar";
            btnDirDisciplinasLimpar.Size = new Size(326, 46);
            btnDirDisciplinasLimpar.TabIndex = 61;
            btnDirDisciplinasLimpar.Text = "Limpar";
            btnDirDisciplinasLimpar.UseVisualStyleBackColor = true;
            btnDirDisciplinasLimpar.Click += btnDirDisciplinasLimpar_Click;
            // 
            // btnDirDisciplinaRemover
            // 
            btnDirDisciplinaRemover.Location = new Point(58, 1018);
            btnDirDisciplinaRemover.Name = "btnDirDisciplinaRemover";
            btnDirDisciplinaRemover.Size = new Size(326, 46);
            btnDirDisciplinaRemover.TabIndex = 55;
            btnDirDisciplinaRemover.Text = "Remover";
            btnDirDisciplinaRemover.UseVisualStyleBackColor = true;
            btnDirDisciplinaRemover.Click += btnDirDisciplinaRemover_Click;
            // 
            // btnDirDisciplinaAtualizar
            // 
            btnDirDisciplinaAtualizar.Location = new Point(58, 953);
            btnDirDisciplinaAtualizar.Name = "btnDirDisciplinaAtualizar";
            btnDirDisciplinaAtualizar.Size = new Size(326, 46);
            btnDirDisciplinaAtualizar.TabIndex = 54;
            btnDirDisciplinaAtualizar.Text = "Atualizar";
            btnDirDisciplinaAtualizar.UseVisualStyleBackColor = true;
            btnDirDisciplinaAtualizar.Click += btnDirDisciplinaAtualizar_Click;
            // 
            // btnDirDisciplinaAdicionar
            // 
            btnDirDisciplinaAdicionar.Location = new Point(58, 892);
            btnDirDisciplinaAdicionar.Name = "btnDirDisciplinaAdicionar";
            btnDirDisciplinaAdicionar.Size = new Size(326, 46);
            btnDirDisciplinaAdicionar.TabIndex = 53;
            btnDirDisciplinaAdicionar.Text = "Adicionar";
            btnDirDisciplinaAdicionar.UseVisualStyleBackColor = true;
            btnDirDisciplinaAdicionar.Click += btnDirDisciplinaAdicionar_Click;
            // 
            // txtDirDisciplinaDesignacao
            // 
            txtDirDisciplinaDesignacao.Location = new Point(12, 202);
            txtDirDisciplinaDesignacao.Name = "txtDirDisciplinaDesignacao";
            txtDirDisciplinaDesignacao.Size = new Size(432, 44);
            txtDirDisciplinaDesignacao.TabIndex = 42;
            // 
            // lblDirDisciplinaDesignacao
            // 
            lblDirDisciplinaDesignacao.AutoSize = true;
            lblDirDisciplinaDesignacao.Location = new Point(12, 151);
            lblDirDisciplinaDesignacao.Name = "lblDirDisciplinaDesignacao";
            lblDirDisciplinaDesignacao.Size = new Size(336, 36);
            lblDirDisciplinaDesignacao.TabIndex = 41;
            lblDirDisciplinaDesignacao.Text = "Designação (Disciplina)";
            // 
            // txtDirDisciplinaId
            // 
            txtDirDisciplinaId.Location = new Point(12, 76);
            txtDirDisciplinaId.Name = "txtDirDisciplinaId";
            txtDirDisciplinaId.ReadOnly = true;
            txtDirDisciplinaId.Size = new Size(432, 44);
            txtDirDisciplinaId.TabIndex = 40;
            // 
            // lblDirDisciplinaId
            // 
            lblDirDisciplinaId.AutoSize = true;
            lblDirDisciplinaId.Location = new Point(12, 22);
            lblDirDisciplinaId.Name = "lblDirDisciplinaId";
            lblDirDisciplinaId.Size = new Size(211, 36);
            lblDirDisciplinaId.TabIndex = 39;
            lblDirDisciplinaId.Text = "Id (Disciplina)";
            // 
            // dgvDirDisciplinas
            // 
            dgvDirDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirDisciplinas.Location = new Point(471, 2);
            dgvDirDisciplinas.Name = "dgvDirDisciplinas";
            dgvDirDisciplinas.RowHeadersWidth = 82;
            dgvDirDisciplinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirDisciplinas.Size = new Size(1413, 871);
            dgvDirDisciplinas.TabIndex = 38;
            dgvDirDisciplinas.SelectionChanged += dgvDirDisciplinas_SelectionChanged;
            // 
            // tabPNotas
            // 
            tabPNotas.Controls.Add(btnDirNotasLimpar);
            tabPNotas.Controls.Add(dtpDirNotaData);
            tabPNotas.Controls.Add(gpbDirNotasFiltrarNota);
            tabPNotas.Controls.Add(btnDirNotasRemover);
            tabPNotas.Controls.Add(btnDirNotasAtualizar);
            tabPNotas.Controls.Add(btnDirNotasAdicionar);
            tabPNotas.Controls.Add(cbxDirNotaDisciplina);
            tabPNotas.Controls.Add(cbxDirNotaAluno);
            tabPNotas.Controls.Add(txtDirNotaNota);
            tabPNotas.Controls.Add(lblDirNotaNota);
            tabPNotas.Controls.Add(lblDirNotaData);
            tabPNotas.Controls.Add(lblDirNotaDisciplina);
            tabPNotas.Controls.Add(lblDirNotaAluno);
            tabPNotas.Controls.Add(txtDirNotaId);
            tabPNotas.Controls.Add(lblDirNotaId);
            tabPNotas.Controls.Add(dgvDirNotas);
            tabPNotas.Location = new Point(8, 50);
            tabPNotas.Name = "tabPNotas";
            tabPNotas.Size = new Size(1896, 1082);
            tabPNotas.TabIndex = 5;
            tabPNotas.Text = "        Notas        ";
            tabPNotas.UseVisualStyleBackColor = true;
            // 
            // btnDirNotasLimpar
            // 
            btnDirNotasLimpar.Location = new Point(58, 827);
            btnDirNotasLimpar.Name = "btnDirNotasLimpar";
            btnDirNotasLimpar.Size = new Size(326, 46);
            btnDirNotasLimpar.TabIndex = 62;
            btnDirNotasLimpar.Text = "Limpar";
            btnDirNotasLimpar.UseVisualStyleBackColor = true;
            btnDirNotasLimpar.Click += btnDirNotasLimpar_Click;
            // 
            // dtpDirNotaData
            // 
            dtpDirNotaData.Location = new Point(12, 453);
            dtpDirNotaData.Name = "dtpDirNotaData";
            dtpDirNotaData.Size = new Size(432, 44);
            dtpDirNotaData.TabIndex = 58;
            // 
            // gpbDirNotasFiltrarNota
            // 
            gpbDirNotasFiltrarNota.Controls.Add(ckxDirNotasFiltrarNotaPositiva);
            gpbDirNotasFiltrarNota.Controls.Add(ckxDirNotasFiltrarNotaNegativa);
            gpbDirNotasFiltrarNota.Location = new Point(948, 881);
            gpbDirNotasFiltrarNota.Name = "gpbDirNotasFiltrarNota";
            gpbDirNotasFiltrarNota.Size = new Size(460, 200);
            gpbDirNotasFiltrarNota.TabIndex = 57;
            gpbDirNotasFiltrarNota.TabStop = false;
            gpbDirNotasFiltrarNota.Text = "Filtrar por Faixa";
            // 
            // ckxDirNotasFiltrarNotaPositiva
            // 
            ckxDirNotasFiltrarNotaPositiva.AutoSize = true;
            ckxDirNotasFiltrarNotaPositiva.Location = new Point(256, 98);
            ckxDirNotasFiltrarNotaPositiva.Name = "ckxDirNotasFiltrarNotaPositiva";
            ckxDirNotasFiltrarNotaPositiva.Size = new Size(156, 40);
            ckxDirNotasFiltrarNotaPositiva.TabIndex = 1;
            ckxDirNotasFiltrarNotaPositiva.Text = "Positiva";
            ckxDirNotasFiltrarNotaPositiva.UseVisualStyleBackColor = true;
            ckxDirNotasFiltrarNotaPositiva.CheckedChanged += ckxDirNotasFiltrarNotaPositiva_CheckedChanged;
            // 
            // ckxDirNotasFiltrarNotaNegativa
            // 
            ckxDirNotasFiltrarNotaNegativa.AutoSize = true;
            ckxDirNotasFiltrarNotaNegativa.Location = new Point(52, 98);
            ckxDirNotasFiltrarNotaNegativa.Name = "ckxDirNotasFiltrarNotaNegativa";
            ckxDirNotasFiltrarNotaNegativa.Size = new Size(168, 40);
            ckxDirNotasFiltrarNotaNegativa.TabIndex = 0;
            ckxDirNotasFiltrarNotaNegativa.Text = "Negativa";
            ckxDirNotasFiltrarNotaNegativa.UseVisualStyleBackColor = true;
            ckxDirNotasFiltrarNotaNegativa.CheckedChanged += ckxDirNotasFiltrarNotaNegativa_CheckedChanged;
            // 
            // btnDirNotasRemover
            // 
            btnDirNotasRemover.Location = new Point(58, 1018);
            btnDirNotasRemover.Name = "btnDirNotasRemover";
            btnDirNotasRemover.Size = new Size(326, 46);
            btnDirNotasRemover.TabIndex = 55;
            btnDirNotasRemover.Text = "Remover";
            btnDirNotasRemover.UseVisualStyleBackColor = true;
            btnDirNotasRemover.Click += btnDirNotasRemover_Click;
            // 
            // btnDirNotasAtualizar
            // 
            btnDirNotasAtualizar.Location = new Point(58, 953);
            btnDirNotasAtualizar.Name = "btnDirNotasAtualizar";
            btnDirNotasAtualizar.Size = new Size(326, 46);
            btnDirNotasAtualizar.TabIndex = 54;
            btnDirNotasAtualizar.Text = "Atualizar";
            btnDirNotasAtualizar.UseVisualStyleBackColor = true;
            btnDirNotasAtualizar.Click += btnDirNotasAtualizar_Click;
            // 
            // btnDirNotasAdicionar
            // 
            btnDirNotasAdicionar.Location = new Point(58, 892);
            btnDirNotasAdicionar.Name = "btnDirNotasAdicionar";
            btnDirNotasAdicionar.Size = new Size(326, 46);
            btnDirNotasAdicionar.TabIndex = 53;
            btnDirNotasAdicionar.Text = "Adicionar";
            btnDirNotasAdicionar.UseVisualStyleBackColor = true;
            btnDirNotasAdicionar.Click += btnDirNotasAdicionar_Click;
            // 
            // cbxDirNotaDisciplina
            // 
            cbxDirNotaDisciplina.FormattingEnabled = true;
            cbxDirNotaDisciplina.Location = new Point(12, 332);
            cbxDirNotaDisciplina.Name = "cbxDirNotaDisciplina";
            cbxDirNotaDisciplina.Size = new Size(432, 44);
            cbxDirNotaDisciplina.TabIndex = 52;
            // 
            // cbxDirNotaAluno
            // 
            cbxDirNotaAluno.FormattingEnabled = true;
            cbxDirNotaAluno.Location = new Point(12, 200);
            cbxDirNotaAluno.Name = "cbxDirNotaAluno";
            cbxDirNotaAluno.Size = new Size(432, 44);
            cbxDirNotaAluno.TabIndex = 51;
            // 
            // txtDirNotaNota
            // 
            txtDirNotaNota.Location = new Point(12, 577);
            txtDirNotaNota.Name = "txtDirNotaNota";
            txtDirNotaNota.Size = new Size(432, 44);
            txtDirNotaNota.TabIndex = 48;
            // 
            // lblDirNotaNota
            // 
            lblDirNotaNota.AutoSize = true;
            lblDirNotaNota.Location = new Point(12, 527);
            lblDirNotaNota.Name = "lblDirNotaNota";
            lblDirNotaNota.Size = new Size(223, 36);
            lblDirNotaNota.TabIndex = 47;
            lblDirNotaNota.Text = "Nota (Decimal)";
            // 
            // lblDirNotaData
            // 
            lblDirNotaData.AutoSize = true;
            lblDirNotaData.Location = new Point(12, 395);
            lblDirNotaData.Name = "lblDirNotaData";
            lblDirNotaData.Size = new Size(275, 36);
            lblDirNotaData.TabIndex = 45;
            lblDirNotaData.Text = "Data de Atribuição";
            // 
            // lblDirNotaDisciplina
            // 
            lblDirNotaDisciplina.AutoSize = true;
            lblDirNotaDisciplina.Location = new Point(12, 275);
            lblDirNotaDisciplina.Name = "lblDirNotaDisciplina";
            lblDirNotaDisciplina.Size = new Size(152, 36);
            lblDirNotaDisciplina.TabIndex = 43;
            lblDirNotaDisciplina.Text = "Disciplina";
            // 
            // lblDirNotaAluno
            // 
            lblDirNotaAluno.AutoSize = true;
            lblDirNotaAluno.Location = new Point(12, 151);
            lblDirNotaAluno.Name = "lblDirNotaAluno";
            lblDirNotaAluno.Size = new Size(99, 36);
            lblDirNotaAluno.TabIndex = 41;
            lblDirNotaAluno.Text = "Aluno";
            // 
            // txtDirNotaId
            // 
            txtDirNotaId.Location = new Point(12, 76);
            txtDirNotaId.Name = "txtDirNotaId";
            txtDirNotaId.ReadOnly = true;
            txtDirNotaId.Size = new Size(432, 44);
            txtDirNotaId.TabIndex = 40;
            // 
            // lblDirNotaId
            // 
            lblDirNotaId.AutoSize = true;
            lblDirNotaId.Location = new Point(12, 22);
            lblDirNotaId.Name = "lblDirNotaId";
            lblDirNotaId.Size = new Size(140, 36);
            lblDirNotaId.TabIndex = 39;
            lblDirNotaId.Text = "Id (Nota)";
            // 
            // dgvDirNotas
            // 
            dgvDirNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirNotas.Location = new Point(471, 2);
            dgvDirNotas.Name = "dgvDirNotas";
            dgvDirNotas.RowHeadersWidth = 82;
            dgvDirNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirNotas.Size = new Size(1413, 871);
            dgvDirNotas.TabIndex = 38;
            dgvDirNotas.SelectionChanged += dgvDirNotas_SelectionChanged;
            // 
            // DiretorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1220);
            Controls.Add(tabCDiretor);
            Controls.Add(lblTitulo);
            Name = "DiretorForm";
            Text = "DiretorForm";
            FormClosed += DiretorForm_FormClosed;
            Load += DiretorForm_Load;
            tabCDiretor.ResumeLayout(false);
            tabPLogins.ResumeLayout(false);
            tabPLogins.PerformLayout();
            gpbDirLoginsFiltrarCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDirLogins).EndInit();
            tabPFuncionarios.ResumeLayout(false);
            tabPFuncionarios.PerformLayout();
            gpbDirFuncionariosFiltrarCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDirFuncionarios).EndInit();
            tabPAlunos.ResumeLayout(false);
            tabPAlunos.PerformLayout();
            gpbDirAlunosFiltrarTurma.ResumeLayout(false);
            gpbDirAlunosFiltrarTurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirAlunos).EndInit();
            tabPTurmas.ResumeLayout(false);
            tabPTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirTurmas).EndInit();
            tabPDisciplinas.ResumeLayout(false);
            tabPDisciplinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirDisciplinas).EndInit();
            tabPNotas.ResumeLayout(false);
            tabPNotas.PerformLayout();
            gpbDirNotasFiltrarNota.ResumeLayout(false);
            gpbDirNotasFiltrarNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TabControl tabCDiretor;
        private TabPage tabPLogins;
        private TabPage tabPFuncionarios;
        private TabPage tabPAlunos;
        private TabPage tabPTurmas;
        private TabPage tabPDisciplinas;
        private TabPage tabPNotas;
        private ComboBox cbxDirAlunosTurma;
        private Label lblDirAlunosLogin;
        private Label lblDirAlunosTurma;
        private TextBox txtDirAlunosEmail;
        private Label lblDirAlunosEmail;
        private TextBox txtDirAlunosIdade;
        private Label lblDirAlunosIdade;
        private TextBox txtDirAlunosApelido;
        private Label lblDirAlunosApelido;
        private TextBox txtDirAlunosNome;
        private Label lblDirAlunosNome;
        private TextBox txtDirAlunosId;
        private Label lblDirAlunosId;
        private DataGridView dgvDirAlunos;
        private ComboBox cbxDirAlunosLoginId;
        private Button btnDirAlunosRemover;
        private Button btnDirAlunosAtualizar;
        private Button btnDirAlunosAdicionar;
        private GroupBox gpbDirAlunosFiltrarTurma;
        private CheckBox ckbDirAlunos1Ano;
        private TextBox txtDirAlunosFiltrarNotaMaxima;
        private TextBox txtDirAlunosFiltrarNotaMinima;
        private Label lblDirAlunosFiltrarNotaMaxima;
        private Label lblDirAlunosFiltrarNotaMinima;
        private CheckBox ckbDirAlunos4Ano;
        private CheckBox ckbDirAlunos3Ano;
        private CheckBox ckbDirAlunos2Ano;
        private ComboBox cbxDirLoginsFiltrarCargo;
        private GroupBox gpbDirLoginsFiltrarCargo;
        private Button btnDirLoginsRemover;
        private Button btnDirLoginsAtualizar;
        private Button btnDirLoginsAdicionar;
        private ComboBox cbxDirLoginsRole;
        private Label lblDirLoginsRole;
        private TextBox txtDirLoginsPassword;
        private Label lblDirLoginsPassword;
        private TextBox txtDirLoginsUser;
        private Label lblDirLoginsUser;
        private TextBox txtDirLoginsId;
        private Label lblDirLoginsId;
        private DataGridView dgvDirLogins;
        private ComboBox cbxDirFuncionariosFiltrarCargo;
        private GroupBox gpbDirFuncionariosFiltrarCargo;
        private Button btnDirFuncionariosRemover;
        private Button btnDirFuncionariosAtualizar;
        private Button btnDirFuncionariosAdicionar;
        private ComboBox cbxDirFuncionarioCargo;
        private Label lblDirFuncionarioLogin;
        private TextBox txtDirFuncionarioNome;
        private Label lblDirFuncionarioNome;
        private TextBox txtDirFuncionarioId;
        private Label lblDirFuncionarioId;
        private DataGridView dgvDirFuncionarios;
        private GroupBox groupBox7;
        private Button button9;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label19;
        private Label label20;
        private GroupBox groupBox9;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private Button btnDirTurmasRemover;
        private Button btnDirTurmasAtualizar;
        private Button btnDirTurmasAdicionar;
        private ComboBox comboBox8;
        private ComboBox cbxDirTurmasProfessorId;
        private Label label21;
        private Label label22;
        private TextBox textBox17;
        private Label label23;
        private TextBox textBox18;
        private Label label24;
        private TextBox textBox19;
        private Label lblDirTurmasProfessorId;
        private TextBox txtDirTurmasDesignacao;
        private Label lblDirTurmasDesignacao;
        private TextBox txtDirTurmasId;
        private Label lblDirTurmasId;
        private DataGridView dgvDirTurmas;
        private Button btnDirDisciplinaRemover;
        private Button btnDirDisciplinaAtualizar;
        private Button btnDirDisciplinaAdicionar;
        private TextBox txtDirDisciplinaDesignacao;
        private Label lblDirDisciplinaDesignacao;
        private TextBox txtDirDisciplinaId;
        private Label lblDirDisciplinaId;
        private DataGridView dgvDirDisciplinas;
        private GroupBox gpbDirNotasFiltrarNota;
        private CheckBox ckxDirNotasFiltrarFaixa15A20;
        private CheckBox ckxDirNotasFiltrarFaixa10A15;
        private CheckBox ckxDirNotasFiltrarFaixa6A9;
        private CheckBox ckxDirNotasFiltrarNotaNegativa;
        private Button btnDirNotasRemover;
        private Button btnDirNotasAtualizar;
        private Button btnDirNotasAdicionar;
        private ComboBox cbxDirNotaDisciplina;
        private ComboBox cbxDirNotaAluno;
        private TextBox txtDirNotaNota;
        private Label lblDirNotaNota;
        private Label lblDirNotaData;
        private Label lblDirNotaDisciplina;
        private Label lblDirNotaAluno;
        private TextBox txtDirNotaId;
        private Label lblDirNotaId;
        private DataGridView dgvDirNotas;
        private DateTimePicker dtpDirNotaData;
        private ComboBox cbxDirFuncionariosLogin;
        private CheckBox ckxDirNotasFiltrarNotaPositiva;
        private Button btnDirLoginsLimpar;
        private Button btnDirAlunosLimpar;
        private Button btnDirFuncionariosLimpar;
        private Button btnDirTurmasLimpar;
        private Button btnDirDisciplinasLimpar;
        private Button btnDirNotasLimpar;
    }
}