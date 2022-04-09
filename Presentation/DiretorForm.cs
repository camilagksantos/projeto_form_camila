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
    public partial class DiretorForm : Form
    {
        public DiretorForm()
        {
            InitializeComponent();
        }

        private void DiretorForm_Load(object sender, EventArgs e)
        {
        }

        private void DiretorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
