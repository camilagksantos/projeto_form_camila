using projeto_form_camila.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_form_camila.Presentation
{
    public partial class ProfessorForm : Form
    {
        private Login login;
        public ProfessorForm(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {

        }

        private void ProfessorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
