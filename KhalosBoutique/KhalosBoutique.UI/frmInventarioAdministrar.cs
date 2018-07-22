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
    public partial class frmInventarioAdministrar : Form
    {
        ICategoria cat;
        IProducto prod;
        IUsuario usu;

        public frmInventarioAdministrar()
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

        private void frmInventarioAdministrar_Load(object sender, EventArgs e)
        {
            var categorias = cat.ListarCategorias().Select(x => x.Nombre).ToList();
            cbCategorias.DataSource = categorias;
            ActualizarGridView();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = prod.BuscarProductoId(Convert.ToInt32(txtIdProducto.Text));
                txtIdProducto.Enabled = false;
                if (producto != null  )
                {
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    nupStock.Value = producto.Cantidad_Stock;
                    txtPrecioCosto.Text = producto.PrecioCosto.ToString();
                    txtPrecioDetalle.Text = producto.PrecioDetalle.ToString();
                    txtPrecioMayor.Text = producto.PrecioMayor.ToString();
                    cbCategorias.SelectedIndex = producto.IdCategoria - 1;
                    txtTalla.Text = producto.Talla;
                    txtColor.Text = producto.Color;
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

        private void btnCategorías_Click(object sender, EventArgs e)
        {
            frmCategoria nav = new frmCategoria();
            nav.Show();
            Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    IdProducto = Convert.ToInt32(txtIdProducto.Text),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    PrecioCosto = Convert.ToInt32(txtPrecioCosto.Text),
                    PrecioDetalle = Convert.ToInt32(txtPrecioDetalle.Text),
                    PrecioMayor = Convert.ToInt32(txtPrecioMayor.Text),
                    Cantidad_Stock = Convert.ToInt32(nupStock.Value),
                    IdCategoria = cbCategorias.SelectedIndex + 1,
                    Talla = txtTalla.Text,
                    Color = txtColor.Text,
                };
                prod.ActualizarProducto(producto);
                MessageBox.Show("Producto actualizado", "Información",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGridView();
                Limpiar();
            }//try
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message,
                   MessageBoxButtons.OK, MessageBoxIcon.Error));
            }//catch
        }

        void Limpiar()
        {
            txtDescripcion.Clear();
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtPrecioCosto.Clear();
            txtPrecioDetalle.Clear();
            txtPrecioMayor.Clear();
            txtTalla.Clear();
            txtColor.Clear();
            nupStock.Value = 0;
            txtIdProducto.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInventario nav = new frmInventario();
            nav.Show();
            Hide();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var confirmar = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirmar == DialogResult.Yes)
                {
                    prod.EliminarProducto(Convert.ToInt32(txtIdProducto.Text));
                    MessageBox.Show("Cliente eliminado");
                    btnLimpiar_Click_1(sender, e);
                    ActualizarGridView();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Ocurrió el siguiente error: {0}", ex.Message),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
