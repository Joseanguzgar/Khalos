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
    public partial class frmInventario : Form
    {
        ICategoria cat;
        IProducto prod;
        IUsuario usu;

        public frmInventario()
        {
            cat = new MCategoria();
            prod = new MProducto();
            usu = new MUsuario();
            InitializeComponent();
        }

        void ActualizarGridView()
        {
            var productos = prod.ListarProductosView();
            dgvInventario.DataSource = productos;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text;
                var descripcion = txtDescripcion.Text;
                var precioCosto = txtPrecioCosto.Text;
                var stock = nupStock.Value;
                var categorias = cbCategorias.SelectedIndex + 1;
                var marca = txtTalla.Text;
                var precioMayor = txtPrecioMayor.Text;
                var precioDetalle = txtPrecioDetalle.Text;
                var color = txtColor.Text;
                if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(descripcion) && !String.IsNullOrEmpty(precioCosto) && !String.IsNullOrEmpty(marca) && !String.IsNullOrEmpty(precioDetalle) && !String.IsNullOrEmpty(precioMayor) && !String.IsNullOrEmpty(color))
                {
                    var producto = new Producto
                    {
                    
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        PrecioCosto = Convert.ToInt32(txtPrecioCosto.Text),
                        Cantidad_Stock = Convert.ToInt32(nupStock.Value),
                        IdCategoria = cbCategorias.SelectedIndex + 1,
                        PrecioDetalle = Convert.ToInt32(txtPrecioDetalle.Text),
                        PrecioMayor = Convert.ToInt32(txtPrecioMayor.Text),
                        Color = txtColor.Text,
                        Talla = txtTalla.Text,
                    };
                    prod.InsertarProducto(producto);
                    MessageBox.Show("Producto insertado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGridView();
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtPrecioCosto.Clear();
                    txtPrecioDetalle.Clear();
                    txtPrecioMayor.Clear();
                    nupStock.Value = 0;
                    txtTalla.Clear();
                    txtColor.Clear();

                }
                else
                {
                    MessageBox.Show("Faltan datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             }//try
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error));
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

        private void btnCategorías_Click(object sender, EventArgs e)
        {
            frmCategoria nav = new frmCategoria();
            nav.Show();
            Hide();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            var categorias = cat.ListarCategorias().Select(x => x.Nombre).ToList();
            cbCategorias.DataSource = categorias;
            ActualizarGridView();
        }

        private void btnAdministrar_Click_1(object sender, EventArgs e)
        {
            frmInventarioAdministrar nav = new frmInventarioAdministrar();
            nav.Show();
            Hide();
        }
    }
}
