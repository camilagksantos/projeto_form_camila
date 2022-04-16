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
            label1 = new Label();
            lblListaAlunos = new Label();
            lblAlunoNotas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlunoNotas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(641, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(456, 55);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Formulário do Aluno";
            // 
            // dgvAlunoNotas
            // 
            dgvAlunoNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunoNotas.Location = new Point(525, 215);
            dgvAlunoNotas.Name = "dgvAlunoNotas";
            dgvAlunoNotas.RowHeadersWidth = 82;
            dgvAlunoNotas.Size = new Size(1383, 993);
            dgvAlunoNotas.TabIndex = 3;
            // 
            // lstListaAlunosPorTurma
            // 
            lstListaAlunosPorTurma.FormattingEnabled = true;
            lstListaAlunosPorTurma.Location = new Point(12, 215);
            lstListaAlunosPorTurma.Name = "lstListaAlunosPorTurma";
            lstListaAlunosPorTurma.Size = new Size(484, 996);
            lstListaAlunosPorTurma.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 223);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // lblListaAlunos
            // 
            lblListaAlunos.AutoSize = true;
            lblListaAlunos.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblListaAlunos.Location = new Point(119, 160);
            lblListaAlunos.Name = "lblListaAlunos";
            lblListaAlunos.Size = new Size(262, 42);
            lblListaAlunos.TabIndex = 6;
            lblListaAlunos.Text = "Lista de Alunos";
            // 
            // lblAlunoNotas
            // 
            lblAlunoNotas.AutoSize = true;
            lblAlunoNotas.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAlunoNotas.Location = new Point(1152, 160);
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
            ClientSize = new Size(1920, 1220);
            Controls.Add(lblAlunoNotas);
            Controls.Add(lblListaAlunos);
            Controls.Add(label1);
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
        private Label label1;
        private Label lblListaAlunos;
        private Label lblAlunoNotas;
    }
}