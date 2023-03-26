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

        private void comboboxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio = 0;
            double ISV = 0;
            double descuento = 0;
            double total = 0;

            descuento = Convert.ToDouble(txtDescuento.Text);

            if (comboboxServicio.Text == "Diagnostico")
            {
                precio = 500;
                txtPrecio.Text = "500";
                ISV = precio * 0.15;
                txtISV.Text = Convert.ToString(ISV);
                total = precio + ISV - descuento;

            }
            else if (comboboxServicio.Text == "Mantenimiento")
            {
                precio = 700;
                txtPrecio.Text = "700";
                ISV = precio * 0.15;
                txtISV.Text = Convert.ToString(ISV);
                total = precio + ISV - descuento;
            }
            else if (comboboxServicio.Text == "Mantenimiento Impresoras")
            {
                precio = 1000;
                txtPrecio.Text = "1000";
                ISV = precio * 0.15;
                txtISV.Text = Convert.ToString(ISV);
                total = precio + ISV - descuento;
            }
            else if (comboboxServicio.Text == "Servicio Tecnico")
            {
                precio = 1500;
                txtPrecio.Text = "1500";
                ISV = precio * 0.15;
                txtISV.Text = Convert.ToString(ISV);
                total = precio + ISV - descuento;
            }

            txtTotalPagar.Text = Convert.ToString(total);

        }
    }
}
