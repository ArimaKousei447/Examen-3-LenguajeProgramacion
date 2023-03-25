using System;
using System.Windows.Forms;

namespace vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void imageStreamer1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese su usuario");
                return;

            }
            errorProvider1.Clear();

            if (txtContra.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese su contraseña");
                return;

            }
            errorProvider1.Clear();

            //Validadar login

            //llamado al menu

            menu menuFormulario = new menu();
            this.Hide();
            menuFormulario.Show();
        }
    }
}
