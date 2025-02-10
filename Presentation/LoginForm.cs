using Microsoft.IdentityModel.Tokens;
using projeto_form_camila.Business.Modal;
using projeto_form_camila.Models;
using projeto_form_camila.Presentation;

namespace projeto_form_camila
{
    public partial class LoginForm : Form
    {
        //propriedades
        LoginService loginService;
        Login login { get; set; }

        //contrutor
        public LoginForm()
        {
            InitializeComponent();

            loginService = new LoginService();
            login = new Login();
        }

        //método de carregamento do form
        private void LoginForm_Load(object sender, EventArgs e) { }

        //método do botão aceder que faz as validações para chamar cada form correspondente
        private void btnAceder_Click(object sender, EventArgs e)
        {
            //atribui ao objeto login os valores recebidos das textbox
            //OBS.:O método Trim() é utilizado para remover espaços em branco no início e no final de uma string
            login.Username = txtLogin.Text.Trim();
            login.Password = txtPassword.Text.Trim();

            //verifica se o Username ou a Password são nulos ou vazios
            if (string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.Password))
            {
                MessageBox.Show("Login ou Password vazio ou nulo!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //envia ao loginService para validar as credenciais
                login = loginService.validarCredenciais(login);

                //verifica se o login.Role esta vazio
                if (!login.Role.IsNullOrEmpty())
                {
                    //verifica qual a role do login para redirecionar para o form correto
                    switch (login.Role)
                    {
                        case "Diretor":
                            MessageBox.Show("Login efetuado com sucesso!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Chama DiretorForm
                            DiretorForm diretorForm = new DiretorForm();
                            diretorForm.Show();
                            // Oculta o formulário atual
                            this.Hide();
                            break;
                        case "Professor":
                            MessageBox.Show("Login efetuado com sucesso!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Chama ProfessorForm
                            ProfessorForm professorForm = new ProfessorForm(login);
                            professorForm.Show();
                            // Oculta o formulário atual
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Login efetuado com sucesso!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Chama AlunoForm
                            AlunoForm alunoForm = new AlunoForm(login);
                            alunoForm.Show();
                            // Oculta o formulário atual
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    //se login.Role estiver vazio o objeto fica incompleto e inconsistente com a base que é obrigado a ter uma role para salvar o obj login
                    MessageBox.Show("Login ou senha Invalido!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        //método que encerra toda a aplicação
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}