using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhalosBoutique.DATA;
using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DAL.Metodos;

namespace KhalosBoutique.UI
{
    public partial class frmCliente : Form
    {
        ICliente cli;
        IUsuario usu;

        public frmCliente()
        {
            cli = new MCliente();
            usu = new MUsuario();
            InitializeComponent();
        }

        void ActualizarGridView()
        {
            dgvClientes.DataSource = cli.ListarClientes();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ActualizarGridView();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = cli.BuscarClienteIdentificacion(Convert.ToString(txtIdentificacion.Text));
                if (cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtTelefono.Text = cliente.Telefono.ToString();
                    txtCorreo.Text = cliente.Correo;
                    txtDireccion.Text = cliente.Direccion;
                    txtId_Cliente.Text = cliente.Id_Cliente.ToString();
                    txtIdentificacion.Enabled = false;
                    txtId_Cliente.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente no existe", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrio el siguiente error: {0}",
                   ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var identi = txtIdentificacion.Text;
                var nomb = txtNombre.Text;
                var tel = txtTelefono.Text;
                var corr = txtCorreo.Text;
                var dire = txtDireccion.Text;
                if (!String.IsNullOrEmpty(identi) && !String.IsNullOrEmpty(nomb) && !String.IsNullOrEmpty(tel) && !String.IsNullOrEmpty(corr) && !String.IsNullOrEmpty(dire))
                {
                    var cliente = new Cliente
                    {
                        Identificacion = txtIdentificacion.Text,
                        Nombre = txtNombre.Text,
                        Telefono = txtTelefono.Text,
                        Correo = txtCorreo.Text,
                        Direccion = txtDireccion.Text
                    };

                    cli.InsertarCliente(cliente);
                    MessageBox.Show("Cliente insertado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    ActualizarGridView();
                    
                }
                else
                {
                    MessageBox.Show("Faltan datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGridView();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrio el siguiente error: {0}",
                  ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    Id_Cliente = Convert.ToInt32(txtId_Cliente.Text),
                    Identificacion = txtIdentificacion.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text

                };
                cli.ActualizarCliente(cliente);
                MessageBox.Show("Cliente modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdentificacion.Enabled = false;
                Limpiar();
                ActualizarGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrio el siguiente error: {0}",
                  ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmar = MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirmar == DialogResult.Yes)
                {
                    cli.EliminarCliente(Convert.ToInt32(txtId_Cliente.Text));
                    MessageBox.Show("Cliente eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpiar_Click(sender, e);
                    ActualizarGridView();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrió el siguiente error: {0}", ex.Message),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtIdentificacion.Enabled = true;
            txtId_Cliente.Enabled = true;
            txtId_Cliente.Clear();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            /*var usuario = usu.BuscarUsuario(frmLogin.usuario);
            if (usuario.Rol == "Administrador")
            {
                frmMenuPrincipalAdmin nav = new frmMenuPrincipalAdmin();
                nav.Show();
                Hide();
            }
            else
            {
                frmMenuPrincipalVendedor nav = new frmMenuPrincipalVendedor();
                nav.Show();
                Hide();
            }*/
        }
    }
}
