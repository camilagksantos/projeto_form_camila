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
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPFuncionarios = new TabPage();
            tabPAlunos = new TabPage();
            gpbFiltrarPorDisciplina = new GroupBox();
            gpbDirFiltrarPorNota = new GroupBox();
            gpbDirFiltroPorTurma = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btnRemover = new Button();
            btnDirAtualizar = new Button();
            btnDirAdicionar = new Button();
            cbxDirLoginId = new ComboBox();
            cbxDirTurma = new ComboBox();
            lblDirAlunoLogin = new Label();
            lblDirAlunoTurma = new Label();
            txtDirAlunoEmail = new TextBox();
            lblDirAlunoEmail = new Label();
            txtDirAlunoIdade = new TextBox();
            lblDirAlunoIdade = new Label();
            txtDirAlunoApelido = new TextBox();
            lblDirAlunoApelido = new Label();
            txtDirAlunoNome = new TextBox();
            lblDirAlunoNome = new Label();
            txtDirIdAluno = new TextBox();
            lblDirIdAluno = new Label();
            dgvDirAlunos = new DataGridView();
            tabPTurmas = new TabPage();
            tabPDisciplinas = new TabPage();
            tabPNotas = new TabPage();
            tabCDiretor.SuspendLayout();
            tabPLogins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPAlunos.SuspendLayout();
            gpbDirFiltroPorTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirAlunos).BeginInit();
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
            tabPLogins.Controls.Add(textBox7);
            tabPLogins.Controls.Add(label7);
            tabPLogins.Controls.Add(textBox6);
            tabPLogins.Controls.Add(label6);
            tabPLogins.Controls.Add(textBox5);
            tabPLogins.Controls.Add(label5);
            tabPLogins.Controls.Add(textBox4);
            tabPLogins.Controls.Add(label4);
            tabPLogins.Controls.Add(textBox3);
            tabPLogins.Controls.Add(label3);
            tabPLogins.Controls.Add(textBox2);
            tabPLogins.Controls.Add(label2);
            tabPLogins.Controls.Add(textBox1);
            tabPLogins.Controls.Add(label1);
            tabPLogins.Controls.Add(dataGridView1);
            tabPLogins.Location = new Point(8, 50);
            tabPLogins.Name = "tabPLogins";
            tabPLogins.Padding = new Padding(3);
            tabPLogins.Size = new Size(1896, 1082);
            tabPLogins.TabIndex = 0;
            tabPLogins.Text = "        Logins        ";
            tabPLogins.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(18, 902);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(385, 44);
            textBox7.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 863);
            label7.Name = "label7";
            label7.Size = new Size(97, 36);
            label7.TabIndex = 13;
            label7.Text = "label7";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(18, 755);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(385, 44);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 716);
            label6.Name = "label6";
            label6.Size = new Size(97, 36);
            label6.TabIndex = 11;
            label6.Text = "label6";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(18, 601);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(385, 44);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 562);
            label5.Name = "label5";
            label5.Size = new Size(97, 36);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 472);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(385, 44);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 433);
            label4.Name = "label4";
            label4.Size = new Size(97, 36);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 341);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(385, 44);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 302);
            label3.Name = "label3";
            label3.Size = new Size(97, 36);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(385, 44);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 162);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 44);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 26);
            label1.Name = "label1";
            label1.Size = new Size(97, 36);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(423, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1467, 938);
            dataGridView1.TabIndex = 0;
            // 
            // tabPFuncionarios
            // 
            tabPFuncionarios.Location = new Point(8, 50);
            tabPFuncionarios.Name = "tabPFuncionarios";
            tabPFuncionarios.Size = new Size(1896, 1082);
            tabPFuncionarios.TabIndex = 1;
            tabPFuncionarios.Text = "        Funcionários        ";
            tabPFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tabPAlunos
            // 
            tabPAlunos.Controls.Add(gpbFiltrarPorDisciplina);
            tabPAlunos.Controls.Add(gpbDirFiltrarPorNota);
            tabPAlunos.Controls.Add(gpbDirFiltroPorTurma);
            tabPAlunos.Controls.Add(btnRemover);
            tabPAlunos.Controls.Add(btnDirAtualizar);
            tabPAlunos.Controls.Add(btnDirAdicionar);
            tabPAlunos.Controls.Add(cbxDirLoginId);
            tabPAlunos.Controls.Add(cbxDirTurma);
            tabPAlunos.Controls.Add(lblDirAlunoLogin);
            tabPAlunos.Controls.Add(lblDirAlunoTurma);
            tabPAlunos.Controls.Add(txtDirAlunoEmail);
            tabPAlunos.Controls.Add(lblDirAlunoEmail);
            tabPAlunos.Controls.Add(txtDirAlunoIdade);
            tabPAlunos.Controls.Add(lblDirAlunoIdade);
            tabPAlunos.Controls.Add(txtDirAlunoApelido);
            tabPAlunos.Controls.Add(lblDirAlunoApelido);
            tabPAlunos.Controls.Add(txtDirAlunoNome);
            tabPAlunos.Controls.Add(lblDirAlunoNome);
            tabPAlunos.Controls.Add(txtDirIdAluno);
            tabPAlunos.Controls.Add(lblDirIdAluno);
            tabPAlunos.Controls.Add(dgvDirAlunos);
            tabPAlunos.Location = new Point(8, 50);
            tabPAlunos.Name = "tabPAlunos";
            tabPAlunos.Size = new Size(1896, 1082);
            tabPAlunos.TabIndex = 2;
            tabPAlunos.Text = "        Alunos            ";
            tabPAlunos.UseVisualStyleBackColor = true;
            // 
            // gpbFiltrarPorDisciplina
            // 
            gpbFiltrarPorDisciplina.Location = new Point(1433, 882);
            gpbFiltrarPorDisciplina.Name = "gpbFiltrarPorDisciplina";
            gpbFiltrarPorDisciplina.Size = new Size(460, 200);
            gpbFiltrarPorDisciplina.TabIndex = 37;
            gpbFiltrarPorDisciplina.TabStop = false;
            gpbFiltrarPorDisciplina.Text = "Filtrar por Disciplina";
            // 
            // gpbDirFiltrarPorNota
            // 
            gpbDirFiltrarPorNota.Location = new Point(957, 882);
            gpbDirFiltrarPorNota.Name = "gpbDirFiltrarPorNota";
            gpbDirFiltrarPorNota.Size = new Size(460, 200);
            gpbDirFiltrarPorNota.TabIndex = 36;
            gpbDirFiltrarPorNota.TabStop = false;
            gpbDirFiltrarPorNota.Text = "Filtrar por Nota";
            // 
            // gpbDirFiltroPorTurma
            // 
            gpbDirFiltroPorTurma.Controls.Add(checkBox2);
            gpbDirFiltroPorTurma.Controls.Add(checkBox1);
            gpbDirFiltroPorTurma.Location = new Point(480, 879);
            gpbDirFiltroPorTurma.Name = "gpbDirFiltroPorTurma";
            gpbDirFiltroPorTurma.Size = new Size(460, 200);
            gpbDirFiltroPorTurma.TabIndex = 35;
            gpbDirFiltroPorTurma.TabStop = false;
            gpbDirFiltroPorTurma.Text = "Filtrar por Turma";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(133, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(194, 40);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(33, 63);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(194, 40);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(67, 1019);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(326, 46);
            btnRemover.TabIndex = 34;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnDirAtualizar
            // 
            btnDirAtualizar.Location = new Point(67, 954);
            btnDirAtualizar.Name = "btnDirAtualizar";
            btnDirAtualizar.Size = new Size(326, 46);
            btnDirAtualizar.TabIndex = 33;
            btnDirAtualizar.Text = "Atualizar";
            btnDirAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnDirAdicionar
            // 
            btnDirAdicionar.Location = new Point(67, 893);
            btnDirAdicionar.Name = "btnDirAdicionar";
            btnDirAdicionar.Size = new Size(326, 46);
            btnDirAdicionar.TabIndex = 32;
            btnDirAdicionar.Text = "Adicionar";
            btnDirAdicionar.UseVisualStyleBackColor = true;
            // 
            // cbxDirLoginId
            // 
            cbxDirLoginId.FormattingEnabled = true;
            cbxDirLoginId.Location = new Point(21, 830);
            cbxDirLoginId.Name = "cbxDirLoginId";
            cbxDirLoginId.Size = new Size(432, 44);
            cbxDirLoginId.TabIndex = 31;
            // 
            // cbxDirTurma
            // 
            cbxDirTurma.FormattingEnabled = true;
            cbxDirTurma.Location = new Point(21, 700);
            cbxDirTurma.Name = "cbxDirTurma";
            cbxDirTurma.Size = new Size(432, 44);
            cbxDirTurma.TabIndex = 30;
            // 
            // lblDirAlunoLogin
            // 
            lblDirAlunoLogin.AutoSize = true;
            lblDirAlunoLogin.Location = new Point(21, 775);
            lblDirAlunoLogin.Name = "lblDirAlunoLogin";
            lblDirAlunoLogin.Size = new Size(246, 36);
            lblDirAlunoLogin.TabIndex = 28;
            lblDirAlunoLogin.Text = "Login Id (Aluno)";
            // 
            // lblDirAlunoTurma
            // 
            lblDirAlunoTurma.AutoSize = true;
            lblDirAlunoTurma.Location = new Point(21, 640);
            lblDirAlunoTurma.Name = "lblDirAlunoTurma";
            lblDirAlunoTurma.Size = new Size(222, 36);
            lblDirAlunoTurma.TabIndex = 26;
            lblDirAlunoTurma.Text = "Turma (Aluno)";
            // 
            // txtDirAlunoEmail
            // 
            txtDirAlunoEmail.Location = new Point(21, 578);
            txtDirAlunoEmail.Name = "txtDirAlunoEmail";
            txtDirAlunoEmail.Size = new Size(432, 44);
            txtDirAlunoEmail.TabIndex = 25;
            // 
            // lblDirAlunoEmail
            // 
            lblDirAlunoEmail.AutoSize = true;
            lblDirAlunoEmail.Location = new Point(21, 528);
            lblDirAlunoEmail.Name = "lblDirAlunoEmail";
            lblDirAlunoEmail.Size = new Size(211, 36);
            lblDirAlunoEmail.TabIndex = 24;
            lblDirAlunoEmail.Text = "Email (Aluno)";
            // 
            // txtDirAlunoIdade
            // 
            txtDirAlunoIdade.Location = new Point(21, 452);
            txtDirAlunoIdade.Name = "txtDirAlunoIdade";
            txtDirAlunoIdade.Size = new Size(432, 44);
            txtDirAlunoIdade.TabIndex = 23;
            // 
            // lblDirAlunoIdade
            // 
            lblDirAlunoIdade.AutoSize = true;
            lblDirAlunoIdade.Location = new Point(21, 396);
            lblDirAlunoIdade.Name = "lblDirAlunoIdade";
            lblDirAlunoIdade.Size = new Size(206, 36);
            lblDirAlunoIdade.TabIndex = 22;
            lblDirAlunoIdade.Text = "Idade (Aluno)";
            // 
            // txtDirAlunoApelido
            // 
            txtDirAlunoApelido.Location = new Point(21, 326);
            txtDirAlunoApelido.Name = "txtDirAlunoApelido";
            txtDirAlunoApelido.Size = new Size(432, 44);
            txtDirAlunoApelido.TabIndex = 21;
            // 
            // lblDirAlunoApelido
            // 
            lblDirAlunoApelido.AutoSize = true;
            lblDirAlunoApelido.Location = new Point(21, 276);
            lblDirAlunoApelido.Name = "lblDirAlunoApelido";
            lblDirAlunoApelido.Size = new Size(236, 36);
            lblDirAlunoApelido.TabIndex = 20;
            lblDirAlunoApelido.Text = "Apelido (Aluno)";
            // 
            // txtDirAlunoNome
            // 
            txtDirAlunoNome.Location = new Point(21, 203);
            txtDirAlunoNome.Name = "txtDirAlunoNome";
            txtDirAlunoNome.Size = new Size(432, 44);
            txtDirAlunoNome.TabIndex = 19;
            // 
            // lblDirAlunoNome
            // 
            lblDirAlunoNome.AutoSize = true;
            lblDirAlunoNome.Location = new Point(21, 152);
            lblDirAlunoNome.Name = "lblDirAlunoNome";
            lblDirAlunoNome.Size = new Size(209, 36);
            lblDirAlunoNome.TabIndex = 18;
            lblDirAlunoNome.Text = "Nome (Aluno)";
            // 
            // txtDirIdAluno
            // 
            txtDirIdAluno.Location = new Point(21, 77);
            txtDirIdAluno.Name = "txtDirIdAluno";
            txtDirIdAluno.Size = new Size(432, 44);
            txtDirIdAluno.TabIndex = 17;
            // 
            // lblDirIdAluno
            // 
            lblDirIdAluno.AutoSize = true;
            lblDirIdAluno.Location = new Point(21, 23);
            lblDirIdAluno.Name = "lblDirIdAluno";
            lblDirIdAluno.Size = new Size(158, 36);
            lblDirIdAluno.TabIndex = 16;
            lblDirIdAluno.Text = "Id (Aluno)";
            // 
            // dgvDirAlunos
            // 
            dgvDirAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirAlunos.Location = new Point(480, 3);
            dgvDirAlunos.Name = "dgvDirAlunos";
            dgvDirAlunos.RowHeadersWidth = 82;
            dgvDirAlunos.Size = new Size(1413, 871);
            dgvDirAlunos.TabIndex = 15;
            // 
            // tabPTurmas
            // 
            tabPTurmas.Location = new Point(8, 50);
            tabPTurmas.Name = "tabPTurmas";
            tabPTurmas.Size = new Size(1896, 1082);
            tabPTurmas.TabIndex = 3;
            tabPTurmas.Text = "        Turmas        ";
            tabPTurmas.UseVisualStyleBackColor = true;
            // 
            // tabPDisciplinas
            // 
            tabPDisciplinas.Location = new Point(8, 50);
            tabPDisciplinas.Name = "tabPDisciplinas";
            tabPDisciplinas.Size = new Size(1896, 1082);
            tabPDisciplinas.TabIndex = 4;
            tabPDisciplinas.Text = "        Disciplinas        ";
            tabPDisciplinas.UseVisualStyleBackColor = true;
            // 
            // tabPNotas
            // 
            tabPNotas.Location = new Point(8, 50);
            tabPNotas.Name = "tabPNotas";
            tabPNotas.Size = new Size(1896, 1082);
            tabPNotas.TabIndex = 5;
            tabPNotas.Text = "        Notas        ";
            tabPNotas.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPAlunos.ResumeLayout(false);
            tabPAlunos.PerformLayout();
            gpbDirFiltroPorTurma.ResumeLayout(false);
            gpbDirFiltroPorTurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirAlunos).EndInit();
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
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox cbxDirTurma;
        private Label lblDirAlunoLogin;
        private Label lblDirAlunoTurma;
        private TextBox txtDirAlunoEmail;
        private Label lblDirAlunoEmail;
        private TextBox txtDirAlunoIdade;
        private Label lblDirAlunoIdade;
        private TextBox txtDirAlunoApelido;
        private Label lblDirAlunoApelido;
        private TextBox txtDirAlunoNome;
        private Label lblDirAlunoNome;
        private TextBox txtDirIdAluno;
        private Label lblDirIdAluno;
        private DataGridView dgvDirAlunos;
        private ComboBox cbxDirLoginId;
        private Button btnRemover;
        private Button btnDirAtualizar;
        private Button btnDirAdicionar;
        private GroupBox gpbFiltrarPorDisciplina;
        private GroupBox gpbDirFiltrarPorNota;
        private GroupBox gpbDirFiltroPorTurma;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}