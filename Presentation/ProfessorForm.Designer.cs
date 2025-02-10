namespace projeto_form_camila.Presentation
{
    partial class ProfessorForm
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
            dgvProfessor = new DataGridView();
            dtpProfNotaData = new DateTimePicker();
            btnProfNotasRemover = new Button();
            btnProfNotasAtualizar = new Button();
            btnProfNotasAdicionar = new Button();
            cbxProfNotaDisciplina = new ComboBox();
            cbxProfNotaAluno = new ComboBox();
            txtProfNotaNota = new TextBox();
            lblProfNotaNota = new Label();
            lblProfNotaData = new Label();
            lblProfNotaDisciplina = new Label();
            lblProfNotaAluno = new Label();
            txtProfNotaId = new TextBox();
            lblProfNotaId = new Label();
            gpbProfFiltrarNota = new GroupBox();
            ckxProfNotaPositiva = new CheckBox();
            ckxProfNotaNegativa = new CheckBox();
            lblListaAlunos = new Label();
            btnProfessorLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfessor).BeginInit();
            gpbProfFiltrarNota.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(641, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(528, 55);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Formulário do Professor";
            // 
            // dgvProfessor
            // 
            dgvProfessor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfessor.Location = new Point(493, 175);
            dgvProfessor.Name = "dgvProfessor";
            dgvProfessor.RowHeadersWidth = 82;
            dgvProfessor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProfessor.Size = new Size(1417, 1033);
            dgvProfessor.TabIndex = 3;
            dgvProfessor.SelectionChanged += dgvProfessor_SelectionChanged;
            // 
            // dtpProfNotaData
            // 
            dtpProfNotaData.CustomFormat = "MM-dd-yyyy";
            dtpProfNotaData.Format = DateTimePickerFormat.Custom;
            dtpProfNotaData.Location = new Point(27, 578);
            dtpProfNotaData.Name = "dtpProfNotaData";
            dtpProfNotaData.Size = new Size(432, 39);
            dtpProfNotaData.TabIndex = 71;
            // 
            // btnProfNotasRemover
            // 
            btnProfNotasRemover.Location = new Point(64, 939);
            btnProfNotasRemover.Name = "btnProfNotasRemover";
            btnProfNotasRemover.Size = new Size(326, 46);
            btnProfNotasRemover.TabIndex = 70;
            btnProfNotasRemover.Text = "Remover";
            btnProfNotasRemover.UseVisualStyleBackColor = true;
            btnProfNotasRemover.Click += btnProfNotasRemover_Click;
            // 
            // btnProfNotasAtualizar
            // 
            btnProfNotasAtualizar.Location = new Point(64, 874);
            btnProfNotasAtualizar.Name = "btnProfNotasAtualizar";
            btnProfNotasAtualizar.Size = new Size(326, 46);
            btnProfNotasAtualizar.TabIndex = 69;
            btnProfNotasAtualizar.Text = "Atualizar";
            btnProfNotasAtualizar.UseVisualStyleBackColor = true;
            btnProfNotasAtualizar.Click += btnProfNotasAtualizar_Click;
            // 
            // btnProfNotasAdicionar
            // 
            btnProfNotasAdicionar.Location = new Point(64, 813);
            btnProfNotasAdicionar.Name = "btnProfNotasAdicionar";
            btnProfNotasAdicionar.Size = new Size(326, 46);
            btnProfNotasAdicionar.TabIndex = 68;
            btnProfNotasAdicionar.Text = "Adicionar";
            btnProfNotasAdicionar.UseVisualStyleBackColor = true;
            btnProfNotasAdicionar.Click += btnProfNotasAdicionar_Click;
            // 
            // cbxProfNotaDisciplina
            // 
            cbxProfNotaDisciplina.FormattingEnabled = true;
            cbxProfNotaDisciplina.Location = new Point(27, 457);
            cbxProfNotaDisciplina.Name = "cbxProfNotaDisciplina";
            cbxProfNotaDisciplina.Size = new Size(432, 40);
            cbxProfNotaDisciplina.TabIndex = 67;
            // 
            // cbxProfNotaAluno
            // 
            cbxProfNotaAluno.FormattingEnabled = true;
            cbxProfNotaAluno.Location = new Point(27, 334);
            cbxProfNotaAluno.Name = "cbxProfNotaAluno";
            cbxProfNotaAluno.Size = new Size(432, 40);
            cbxProfNotaAluno.TabIndex = 66;
            // 
            // txtProfNotaNota
            // 
            txtProfNotaNota.Location = new Point(27, 694);
            txtProfNotaNota.Name = "txtProfNotaNota";
            txtProfNotaNota.Size = new Size(432, 39);
            txtProfNotaNota.TabIndex = 65;
            // 
            // lblProfNotaNota
            // 
            lblProfNotaNota.AutoSize = true;
            lblProfNotaNota.Location = new Point(27, 647);
            lblProfNotaNota.Name = "lblProfNotaNota";
            lblProfNotaNota.Size = new Size(173, 32);
            lblProfNotaNota.TabIndex = 64;
            lblProfNotaNota.Text = "Nota (Decimal)";
            // 
            // lblProfNotaData
            // 
            lblProfNotaData.AutoSize = true;
            lblProfNotaData.Location = new Point(27, 520);
            lblProfNotaData.Name = "lblProfNotaData";
            lblProfNotaData.Size = new Size(212, 32);
            lblProfNotaData.TabIndex = 63;
            lblProfNotaData.Text = "Data de Atribuição";
            // 
            // lblProfNotaDisciplina
            // 
            lblProfNotaDisciplina.AutoSize = true;
            lblProfNotaDisciplina.Location = new Point(27, 404);
            lblProfNotaDisciplina.Name = "lblProfNotaDisciplina";
            lblProfNotaDisciplina.Size = new Size(116, 32);
            lblProfNotaDisciplina.TabIndex = 62;
            lblProfNotaDisciplina.Text = "Disciplina";
            // 
            // lblProfNotaAluno
            // 
            lblProfNotaAluno.AutoSize = true;
            lblProfNotaAluno.Location = new Point(27, 290);
            lblProfNotaAluno.Name = "lblProfNotaAluno";
            lblProfNotaAluno.Size = new Size(77, 32);
            lblProfNotaAluno.TabIndex = 61;
            lblProfNotaAluno.Text = "Aluno";
            // 
            // txtProfNotaId
            // 
            txtProfNotaId.Location = new Point(27, 227);
            txtProfNotaId.Name = "txtProfNotaId";
            txtProfNotaId.Size = new Size(432, 39);
            txtProfNotaId.TabIndex = 60;
            // 
            // lblProfNotaId
            // 
            lblProfNotaId.AutoSize = true;
            lblProfNotaId.Location = new Point(27, 171);
            lblProfNotaId.Name = "lblProfNotaId";
            lblProfNotaId.Size = new Size(107, 32);
            lblProfNotaId.TabIndex = 59;
            lblProfNotaId.Text = "Id (Nota)";
            // 
            // gpbProfFiltrarNota
            // 
            gpbProfFiltrarNota.Controls.Add(ckxProfNotaPositiva);
            gpbProfFiltrarNota.Controls.Add(ckxProfNotaNegativa);
            gpbProfFiltrarNota.Location = new Point(12, 1009);
            gpbProfFiltrarNota.Name = "gpbProfFiltrarNota";
            gpbProfFiltrarNota.Size = new Size(460, 200);
            gpbProfFiltrarNota.TabIndex = 72;
            gpbProfFiltrarNota.TabStop = false;
            gpbProfFiltrarNota.Text = "Filtrar por Nota";
            // 
            // ckxProfNotaPositiva
            // 
            ckxProfNotaPositiva.AutoSize = true;
            ckxProfNotaPositiva.Location = new Point(256, 98);
            ckxProfNotaPositiva.Name = "ckxProfNotaPositiva";
            ckxProfNotaPositiva.Size = new Size(126, 36);
            ckxProfNotaPositiva.TabIndex = 1;
            ckxProfNotaPositiva.Text = "Positiva";
            ckxProfNotaPositiva.UseVisualStyleBackColor = true;
            ckxProfNotaPositiva.CheckedChanged += ckxProfNotaPositiva_CheckedChanged;
            // 
            // ckxProfNotaNegativa
            // 
            ckxProfNotaNegativa.AutoSize = true;
            ckxProfNotaNegativa.Location = new Point(52, 98);
            ckxProfNotaNegativa.Name = "ckxProfNotaNegativa";
            ckxProfNotaNegativa.Size = new Size(141, 36);
            ckxProfNotaNegativa.TabIndex = 0;
            ckxProfNotaNegativa.Text = "Negativa";
            ckxProfNotaNegativa.UseVisualStyleBackColor = true;
            ckxProfNotaNegativa.CheckedChanged += ckxProfNotaNegativa_CheckedChanged;
            // 
            // lblListaAlunos
            // 
            lblListaAlunos.AutoSize = true;
            lblListaAlunos.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblListaAlunos.Location = new Point(1022, 118);
            lblListaAlunos.Name = "lblListaAlunos";
            lblListaAlunos.Size = new Size(386, 42);
            lblListaAlunos.TabIndex = 73;
            lblListaAlunos.Text = "Lista de Alunos e Notas";
            // 
            // btnProfessorLimpar
            // 
            btnProfessorLimpar.Location = new Point(64, 753);
            btnProfessorLimpar.Name = "btnProfessorLimpar";
            btnProfessorLimpar.Size = new Size(326, 46);
            btnProfessorLimpar.TabIndex = 74;
            btnProfessorLimpar.Text = "Limpar";
            btnProfessorLimpar.UseVisualStyleBackColor = true;
            btnProfessorLimpar.Click += btnProfessorLimpar_Click;
            // 
            // ProfessorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1220);
            Controls.Add(btnProfessorLimpar);
            Controls.Add(lblListaAlunos);
            Controls.Add(gpbProfFiltrarNota);
            Controls.Add(dtpProfNotaData);
            Controls.Add(btnProfNotasRemover);
            Controls.Add(btnProfNotasAtualizar);
            Controls.Add(btnProfNotasAdicionar);
            Controls.Add(cbxProfNotaDisciplina);
            Controls.Add(cbxProfNotaAluno);
            Controls.Add(txtProfNotaNota);
            Controls.Add(lblProfNotaNota);
            Controls.Add(lblProfNotaData);
            Controls.Add(lblProfNotaDisciplina);
            Controls.Add(lblProfNotaAluno);
            Controls.Add(txtProfNotaId);
            Controls.Add(lblProfNotaId);
            Controls.Add(dgvProfessor);
            Controls.Add(lblTitulo);
            Name = "ProfessorForm";
            Text = "ProfessorForm";
            FormClosed += ProfessorForm_FormClosed;
            Load += ProfessorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfessor).EndInit();
            gpbProfFiltrarNota.ResumeLayout(false);
            gpbProfFiltrarNota.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvProfessor;
        private DateTimePicker dtpProfNotaData;
        private Button btnProfNotasRemover;
        private Button btnProfNotasAtualizar;
        private Button btnProfNotasAdicionar;
        private ComboBox cbxProfNotaDisciplina;
        private ComboBox cbxProfNotaAluno;
        private TextBox txtProfNotaNota;
        private Label lblProfNotaNota;
        private Label lblProfNotaData;
        private Label lblProfNotaDisciplina;
        private Label lblProfNotaAluno;
        private TextBox txtProfNotaId;
        private Label lblProfNotaId;
        private GroupBox gpbProfFiltrarNota;
        private CheckBox ckxProfNotaPositiva;
        private CheckBox ckxProfNotaNegativa;
        private Label lblListaAlunos;
        private Button btnProfessorLimpar;
    }
}