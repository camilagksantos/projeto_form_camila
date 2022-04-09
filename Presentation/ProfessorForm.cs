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
        public ProfessorForm()
        {
            InitializeComponent();
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
