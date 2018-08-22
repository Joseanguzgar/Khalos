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
using KhalosBoutique.DATA;

namespace KhalosBoutique.UI
{
    public partial class frmFactura : Form
    {
        DateTime hoy = DateTime.Now;
        ICliente cli;
        IFactura fac;
        IUsuario usu;
        public frmFactura()
        {
            InitializeComponent();
            cli = new MCliente();
            fac = new MFactura();
            usu = new MUsuario();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = cli.BuscarCliente((int)nupIdCliente.Value);
                if (cliente != null)
                {
                    var factura = new Factura
                    {
                        Id_Cliente = cliente.Id_Cliente,
                        PrecioTotal = 0,
                        Fecha = hoy
                    };
                    fac.Facturar(factura);
                    MessageBox.Show("Seleccionemos los productos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCompra form = new frmCompra();
                    form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Cliente no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error));
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var usuario = usu.BuscarUsuario(frmLogin.usuario);
            if (usuario.IdRol == 1)
            {
                frmMenuAdmin nav = new frmMenuAdmin();
                nav.Show();
                Hide();
            }
            else
            {
                frmMenuVendedor nav = new frmMenuVendedor();
                nav.Show();
                Hide();
            }

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            txtFecha.Text = hoy.ToShortDateString();
            dgvClientes.DataSource = cli.ListarClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nupIdCliente.Value = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value);
        }
    }
}
