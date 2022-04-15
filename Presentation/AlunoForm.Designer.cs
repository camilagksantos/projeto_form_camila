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
            btnSair = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(697, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(485, 55);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Formulário do Diretor";
            // 
            // AlunoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1220);
            Controls.Add(lblTitulo);
            Controls.Add(btnSair);
            Name = "AlunoForm";
            Text = "AlunoForm";
            FormClosed += AlunoForm_FormClosed;
            Load += AlunoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSair;
        private Label lblTitulo;
    }
}