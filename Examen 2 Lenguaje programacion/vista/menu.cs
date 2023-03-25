using System;
using System.Windows.Forms;

namespace vista
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void toolStripTiket_Click(object sender, EventArgs e)
        {
            formTicket formularioTicket = new formTicket();
            formularioTicket.MdiParent = this;
            formularioTicket.Show();
        }
    }
}
