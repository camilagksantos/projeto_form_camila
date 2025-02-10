namespace projeto_form_camila.Presentation
{
    partial class AlunoForm
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
            dgvAlunoNotas = new DataGridView();
            lstListaAlunosPorTurma = new ListBox();
            lblListaAlunos = new Label();
            lblAlunoNotas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlunoNotas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(474, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(456, 55);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Formulário do Aluno";
            // 
            // dgvAlunoNotas
            // 
            dgvAlunoNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunoNotas.Location = new Point(525, 139);
            dgvAlunoNotas.Name = "dgvAlunoNotas";
            dgvAlunoNotas.RowHeadersWidth = 82;
            dgvAlunoNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunoNotas.Size = new Size(982, 676);
            dgvAlunoNotas.TabIndex = 3;
            // 
            // lstListaAlunosPorTurma
            // 
            lstListaAlunosPorTurma.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstListaAlunosPorTurma.FormattingEnabled = true;
            lstListaAlunosPorTurma.ItemHeight = 42;
            lstListaAlunosPorTurma.Location = new Point(12, 139);
            lstListaAlunosPorTurma.Name = "lstListaAlunosPorTurma";
            lstListaAlunosPorTurma.SelectionMode = SelectionMode.None;
            lstListaAlunosPorTurma.Size = new Size(484, 676);
            lstListaAlunosPorTurma.TabIndex = 4;
            // 
            // lblListaAlunos
            // 
            lblListaAlunos.AutoSize = true;
            lblListaAlunos.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblListaAlunos.Location = new Point(119, 81);
            lblListaAlunos.Name = "lblListaAlunos";
            lblListaAlunos.Size = new Size(262, 42);
            lblListaAlunos.TabIndex = 6;
            lblListaAlunos.Text = "Lista de Alunos";
            // 
            // lblAlunoNotas
            // 
            lblAlunoNotas.AutoSize = true;
            lblAlunoNotas.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAlunoNotas.Location = new Point(949, 81);
            lblAlunoNotas.Name = "lblAlunoNotas";
            lblAlunoNotas.Size = new Size(108, 42);
            lblAlunoNotas.TabIndex = 7;
            lblAlunoNotas.Text = "Notas";
            lblAlunoNotas.TextAlign = ContentAlignment.TopCenter;
            // 
            // AlunoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 840);
            Controls.Add(lblAlunoNotas);
            Controls.Add(lblListaAlunos);
            Controls.Add(lstListaAlunosPorTurma);
            Controls.Add(dgvAlunoNotas);
            Controls.Add(lblTitulo);
            Name = "AlunoForm";
            Text = "AlunoForm";
            FormClosed += AlunoForm_FormClosed;
            Load += AlunoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlunoNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private DataGridView dgvAlunoNotas;
        private ListBox lstListaAlunosPorTurma;
        private Label lblListaAlunos;
        private Label lblAlunoNotas;
    }
}