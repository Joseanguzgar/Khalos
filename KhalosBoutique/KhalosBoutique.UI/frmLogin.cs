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
    public partial class frmLogin : Form
    {
        public static string usuario;
        public static string contrasena;
        IUsuario usua;


        public frmLogin()
        {
            usua = new MUsuario();
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUser.Text;
            contrasena = txtContra.Text;


            var usuarios = usua.BuscarUsuario(usuario);// Se busca el usuario por nombre en la bd
            if (usuarios == null)
            {
                MessageBox.Show("Usuario no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (usuarios.Cuenta == usuario && usuarios.Contraseña != contrasena)// Se verifica que el nombre de usaurio y contrasena existan en la bd y concuerden
            {
                MessageBox.Show("La contraseña es incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContra.Clear();
                txtUser.Clear();
            }

            else if (usuarios.Cuenta == usuario && usuarios.Contraseña == contrasena && usuarios.IdRol == 2)//Se verifica si existe ese usaurio y contrasea y si es rol admistrador
            {
                frmMenuVendedor nav = new frmMenuVendedor();
                nav.Show();
                Hide();
            }
            else if (usuarios.Cuenta == usuario && usuarios.Contraseña == contrasena && usuarios.IdRol == 1)//Si no es administrador, se verifica que existan usario contrasena y si es rol Administrador
            {
                frmMenuAdmin form = new frmMenuAdmin();//Se envia al menu de administrador
                form.Show();
                Hide();
            }
            else if (usuarios.Contraseña != contrasena)
            {
                MessageBox.Show("Contraseña incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            usuario = txtUser.Text;
            contrasena = txtContra.Text;
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                usuario = txtUser.Text;
                contrasena = txtContra.Text;

                var usuarios = usua.BuscarUsuario(usuario);// Se busca el usuario por nombre en la bd
                if (usuarios == null)
                {
                    MessageBox.Show("Usuario no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (usuarios.Cuenta == usuario && usuarios.Contraseña != contrasena)// Se verifica que el nombre de usaurio y contrasena existan en la bd y concuerden
                {
                    MessageBox.Show("La contraseña es incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContra.Clear();
                    txtUser.Clear();
                }
                else if (usuarios.Cuenta == usuario && usuarios.Contraseña == contrasena && usuarios.IdRol == 2)//Se verifica si existe ese usaurio y contrasea y si es rol admistrador
                {
                    frmMenuVendedor nav = new frmMenuVendedor();
                    nav.Show();
                    Hide();
                }
                else if (usuarios.Cuenta == usuario && usuarios.Contraseña == contrasena && usuarios.IdRol == 1)//Si no es administrador, se verifica que existan usario contrasena y si es rol Administrador
                {
                    frmMenuAdmin form = new frmMenuAdmin();//Se envia al menu de administrador
                    form.Show();
                    Hide();
                }
                else if (usuarios.Contraseña != contrasena)
                {
                    MessageBox.Show("Contraseña incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
