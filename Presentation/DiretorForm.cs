using projeto_form_camila.Business.Modal;

namespace projeto_form_camila.Presentation
{
    public partial class DiretorForm : Form
    {
        LoginService loginService = new LoginService();
        FuncionarioService funcionarioService = new FuncionarioService();
        AlunoService alunoService = new AlunoService();
        TurmaService turmaService = new TurmaService();
        DisciplinaService disciplinaService = new DisciplinaService();
        NotaService notaService = new NotaService();

        public DiretorForm()
        {
            InitializeComponent();
        }

        private void DiretorForm_Load(object sender, EventArgs e)
        {
            PreencherDgvs();
        }

        private void DiretorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public void PreencherDgvs()
        {
            dgvDirLogins.DataSource = loginService.buscarLogins();
            dgvDirFuncionarios.DataSource = funcionarioService.buscarFuncionarios();
            dgvDirAlunos.DataSource = alunoService.buscarAlunos();
            dgvDirTurmas.DataSource = turmaService.buscarTurmas();
            dgvDirDisciplinas.DataSource = disciplinaService.buscarDisciplinas();
            dgvDirNotas.DataSource = notaService.buscarNotas();
        }
    }
}
