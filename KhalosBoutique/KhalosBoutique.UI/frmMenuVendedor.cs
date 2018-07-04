using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DAL.Metodos;

namespace KhalosBoutique.UI
{
    public partial class frmMenuVendedor : Form
    {

        IUsuario usu;
        public string nombre;
        public string usuario;
        public string contrasena;
        public string rol;

        public frmMenuVendedor()
        {
            InitializeComponent();
        }

        private void frmMenuVendedor_Load(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString("g");
            txtRolUsuario.Text = "Vendedor";
           /* var usuario = usu.BuscarUsuario(frmLogin.usuario);
            txtNombreUsuario.Text = usuario.Nombre;*/
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente nav = new frmCliente();
            nav.Show();
            Hide();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            /*frmFacturar nav = new frmFacturar();
            nav.Show();
            Hide();*/
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            /*frmInventario nav = new frmInventario();
            nav.Show();
            Hide();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea salir del sistema?", "Salir del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin nav = new frmLogin();
            nav.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*frmVerPerfilAdmi frm = new frmVerPerfilAdmi();
            frm.Show();
            Hide();*/
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
