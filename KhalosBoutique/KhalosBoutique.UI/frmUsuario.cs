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
    public partial class frmUsuario : Form
    {
        IUsuario usua;
        IRol rol;
        public frmUsuario()
        {
            InitializeComponent();
            usua = new MUsuario();
            rol = new MRol();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            var roles = rol.ListarRoles().Select(x => x.Nombre).ToList();
            cbxRol.DataSource = roles;
            cbxRolAdmi.DataSource = roles;
            var usuarios = usua.ListarUsuarios();
            dgvUsuario.DataSource = usuarios;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        void ActualizarGridView()
        {
            var usuarios = usua.ListarUsuarios();
            dgvUsuario.DataSource = usuarios;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text;
                var cuenta = txtCuenta.Text;
                var contraseña = txtContraseña.Text;
                if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(cuenta) && !String.IsNullOrEmpty(contraseña))
                {
                    var confirmar = MessageBox.Show("¿Seguro que desea insertar este usuario?", "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                    if (confirmar == DialogResult.Yes)
                    {
                        var usuario = new Usuario
                        {
                            Nombre = txtNombre.Text,
                            Cuenta = txtCuenta.Text,
                            Contraseña = txtContraseña.Text,
                            IdRol = cbxRol.SelectedIndex + 1,
                        };
                        usua.InsertarUsuario(usuario);
                        ActualizarGridView();
                        MessageBox.Show("Usuario insertado exitosamente", "Información",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtCuenta.Clear();
                        txtContraseña.Clear();
                        cbxRolAdmi.SelectedIndex = 0;
                    }
                    else
                    {
                        txtNombre.Clear();
                        txtCuenta.Clear();
                        txtContraseña.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos", "Información",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message,
                  MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdUsuarioAdmi.Enabled = false;
                var usuario = usua.BuscarUsuarioId(Convert.ToInt32(txtIdUsuarioAdmi.Text));
                if (usuario != null)
                {
                    txtNombreAdmi.Text = usuario.Nombre;
                    txtCuentaAdmi.Text = usuario.Cuenta;
                    txtContraseñaAdmi.Text = usuario.Contraseña;
                    cbxRolAdmi.SelectedIndex = usuario.IdRol - 1;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario
                {
                    IdUsuario = Convert.ToInt32(txtIdUsuarioAdmi.Text),
                    Nombre = txtNombreAdmi.Text,
                    Cuenta = txtCuentaAdmi.Text,
                    Contraseña = txtContraseñaAdmi.Text,
                    IdRol = Convert.ToInt32(cbxRolAdmi.SelectedIndex + 1),
                };
                usua.ActualizarUsuario(usuario);
                ActualizarGridView();
                MessageBox.Show("Usuario modificado exitosamente", "Información",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarioBus = usua.BuscarUsuarioId(Convert.ToInt32(txtIdUsuarioAdmi.Text));

                var confirmar = MessageBox.Show("Desea eliminar el usuario seleccionado?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmar == DialogResult.Yes)
                {
                    usua.EliminarUsuario(usuarioBus.IdUsuario);
                    ActualizarGridView();
                    MessageBox.Show("Usuario eliminado exitosamente", "Información",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdUsuarioAdmi.Clear();
            txtNombreAdmi.Clear();
            txtContraseñaAdmi.Clear();
            txtCuentaAdmi.Clear();
            cbxRolAdmi.SelectedIndex = 0;
            txtIdUsuarioAdmi.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
    }
}
