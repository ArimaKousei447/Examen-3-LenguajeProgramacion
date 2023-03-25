using System;
using System.Windows.Forms;

namespace vista
{
    public partial class formTicket : Form
    {
        double precio;

        public formTicket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese el usuario");
                return;

            }
            errorProvider1.Clear();


            if (comboboxServicio.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese el servicio solicitado");
                return;

            }
            errorProvider1.Clear();


            if (txtDescripcionServicio.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese una descripcion minima");
                return;

            }
            errorProvider1.Clear();


            if (txtDescripcionSolicitud.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese una descripcion minimaIngrese una descripcion minima");
                return;

            }
            errorProvider1.Clear();
        }
    }
}
