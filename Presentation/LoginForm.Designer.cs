namespace projeto_form_camila
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo1 = new Label();
            lblLogin = new Label();
            lblPassword = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnAceder = new Button();
            lblTitulo2 = new Label();
            SuspendLayout();
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo1.Location = new Point(110, 75);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(558, 61);
            lblTitulo1.TabIndex = 0;
            lblTitulo1.Text = "Escola Básica de Braga\r\n";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(91, 244);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(111, 42);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(91, 394);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(169, 42);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(91, 304);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(558, 61);
            txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(91, 448);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(558, 61);
            txtPassword.TabIndex = 2;
            // 
            // btnAceder
            // 
            btnAceder.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceder.Location = new Point(240, 547);
            btnAceder.Name = "btnAceder";
            btnAceder.Size = new Size(211, 77);
            btnAceder.TabIndex = 3;
            btnAceder.Text = "Aceder";
            btnAceder.UseVisualStyleBackColor = true;
            btnAceder.Click += btnAceder_Click;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo2.Location = new Point(273, 155);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(189, 61);
            lblTitulo2.TabIndex = 6;
            lblTitulo2.Text = "Colibri";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 691);
            Controls.Add(lblTitulo2);
            Controls.Add(btnAceder);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(lblTitulo1);
            Name = "LoginForm";
            Text = "Login";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo1;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnAceder;
        private Label lblTitulo2;
    }
}
